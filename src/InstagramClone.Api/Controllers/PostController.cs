using InstagramClone.Api.Database;
using InstagramClone.Api.DTOs;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InstagramClone.Api.Controllers
{

    [ApiController]
    [Route("api/posts")]
    public class PostController : Controller
    {
        private readonly InstagramCloneDbContext context;
        public PostController(InstagramCloneDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult PostedItem(Guid id)
        {
            var post = context.Posts.Find(id);

            if (post == null)
            {
                return BadRequest();
            }
            return Ok(post);
        }

        [HttpPost("")]
        public IActionResult CreatePost([FromBody]PostCreateDto postCreateDto)
        {
            if (postCreateDto == null)
            {
                return BadRequest();
            }

            Post postToInsert = new Post()
            {
                Id = postCreateDto.Id,
                Content = postCreateDto.Content,
                AuthorId = postCreateDto.AuthorId,
                CreatedDate = postCreateDto.CreatedDate,
            };
            var postIdExist = context.Posts.Any(p=>p.Id == postCreateDto.Id);
            var authorIdExist = context.Posts.Any(a=>a.AuthorId == postCreateDto.AuthorId);

            // if there is post id return conflct
            if (postIdExist)
            {
                return Conflict();
            }

            // author id must exit in the database
            if (authorIdExist == false)
            {
                return NotFound();
            }
            this.context.Posts.Add(postToInsert);
            context.SaveChanges();
            
            
           
            return Ok(postToInsert);
        }
       
    }
}
