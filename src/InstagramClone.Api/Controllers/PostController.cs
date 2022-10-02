using InstagramClone.Api.Database;
using InstagramClone.Api.DTOs;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InstagramClone.Api.Controllers
{

    [ApiController]
    [Authorize]
    [Route("api/posts")]
    public class PostController : Controller
    {
        private readonly InstagramCloneDbContext context;
        private readonly UserManager<User> userManager;
        public PostController(InstagramCloneDbContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
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
        public async Task<IActionResult> CreatePost([FromBody]PostCreateDto postCreateDto)
        {
            if (postCreateDto == null)
            {
                return BadRequest();
            }
            var loggedInUserEmail = Request.HttpContext.User.Identity.Name;
            var loggedInUser = await userManager.FindByEmailAsync(loggedInUserEmail);


            Post postToInsert = new Post()
            {
                Id = postCreateDto.Id,
                Content = postCreateDto.Content,
                AuthorId = loggedInUser.Id,
                CreatedDate = postCreateDto.CreatedDate,
            };
            var postIdExist = context.Posts.Any(p=>p.Id == postCreateDto.Id);
            

            // if there is post id return conflct
            if (postIdExist)
            {
                return Conflict();
            }

           
            this.context.Posts.Add(postToInsert);
            context.SaveChanges();
            
            
           
            return Ok(postToInsert);
        }
       
    }
}
