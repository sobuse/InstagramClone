using InstagramClone.Api.Database;
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
       
    }
}
