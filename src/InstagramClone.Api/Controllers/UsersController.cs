
using InstagramClone.Api.Database;
using InstagramClone.Api.DTOs;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InstagramClone.Api.Controllers
{

    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly InstagramCloneDbContext _context;
       
        public UsersController(InstagramCloneDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(Guid id)
        {
            // user variable is used to store the value of a particuler user from the database
            // This finds a user by id from the db set user property from the context class
            var user = _context.Users.Find(id);
            if (user == null)
            {
                // this give a 404 error response when the user they searched for by id could not be found 
                return NotFound();
            }
            // returns the user that was searched for
            return Ok(user);
        }



        [HttpPost("")]
        public IActionResult CreateUsers([FromBody] UserCreateDTO userDto)
        {
            // check if the userDto is empty
            if (userDto == null)
                //if its empty return a bad request error 400
                return BadRequest();

            // created an object from User and called it userToInsert then passed properties from the user class to the new property using dtos
            User userToInsert = new User() 
            {
                Id = userDto.Id,
                Email = userDto.Email,
                Password = userDto.Password,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Avatar = userDto.Avatar,
                CreatedDate = DateTime.Now,
            };
            this._context.Users.Add(userToInsert);
            this._context.SaveChanges();

            // returns a url of the user that was created 
            // https://www.code4it.dev/blog/createdAtRoute-createdAtAction
            // https://stackoverflow.com/questions/47939945/how-to-use-created-or-createdataction-createdatroute-in-an-asp-net-core-api#64315534
            return CreatedAtAction(nameof(GetUser),new {id = userDto.Id },  userDto);
        } 

        [HttpPost("follow")]
        public IActionResult Follow([FromBody]FollowersDto followersDto)
        {

            // "helped me alot" https://www.youtube.com/watch?v=j1e6Z-7QNpk

            var followed = followersDto.FollowedUserId; // 
            var following = followersDto.FollowerId;

            var followerUser = _context.Users.Find(followersDto.FollowerId);
            if (followerUser == null)
            {
                return BadRequest();
            }
            var followedUser = _context.Users.Find(followersDto.FollowedUserId);
            if (followedUser == null)
            {
                return BadRequest();
            }

           
            var isAlreadyFollowed = _context.UserFollowers.Any(uf => uf.FollowedUserId == followersDto.FollowedUserId
             && uf.FollowerId == followersDto.FollowerId);

            if(isAlreadyFollowed)
            {
                return Conflict();
            }
            var followersTofollow = new UserFollower()
            {
                FollowerId = followersDto.FollowerId,
                FollowedUserId = followersDto.FollowedUserId,
                CreatedDate = followersDto.CreatedDate.Date
            };
            this._context.UserFollowers.Add(followersTofollow);
            this._context.SaveChanges();

            return Ok("Created");
           

        }

    }
} 