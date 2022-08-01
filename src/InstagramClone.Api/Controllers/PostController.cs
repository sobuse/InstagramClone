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

            Post InsertPost = new Post()
            {
                Id = postCreateDto.Id,
                Content = postCreateDto.Content,
                AuthorId = postCreateDto.AuthorId,
                CreatedDate = postCreateDto.CreatedDate,
            };
            var postIdExist = context.Posts.Any(p=>p.Id == postCreateDto.Id);
            var authorIdExist = context.Posts.Any(a=>a.AuthorId == postCreateDto.AuthorId);
            if (postIdExist)
            {
                return Conflict();
            }
            if (authorIdExist == null)
            {
                return NotFound();
            }
            this.context.Posts.Add(InsertPost);// [Guid("4794A969-7DE6-4E00-8FBE-D515BE13B596")]
            context.SaveChanges();

            // if there is post id return conflct
            // author id must exixt in the database
            return Ok(InsertPost);
        }
       
    }
}
