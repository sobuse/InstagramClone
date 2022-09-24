
using InstagramClone.Api.Database;
using InstagramClone.Api.DTOs;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace InstagramClone.Api.Controllers
{

    [ApiController]
    [Authorize]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly InstagramCloneDbContext _context;
        private readonly UserManager<User> userManager;
        private readonly PasswordHasher<User> hasher;

        public UsersController(InstagramCloneDbContext context, UserManager<User> userManager)
        {
            _context = context;
            this.userManager = userManager;
            this.hasher = new PasswordHasher<User>();
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(Guid id)
        {
            // user variable is used to store the value of a particuler user from the database
            // This finds a user by id from the db set user property from the context class
            // var user = userManager.GetUserId(id)
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
        [AllowAnonymous]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserCreateDTO userDto)
        {

            try
            {
                // check if the userDto is empty
                if (userDto == null)
                    //if its empty return a bad request error 400
                    return BadRequest();

                //created an object from User and called it userToInsert then passed properties from the user class to the new property using dtos
                User userToInsert = new User()
                {
                    Id = userDto.Id,
                    Email = userDto.Email,
                    // used the password hasher to hash the plain password 
                    PasswordHash = hasher.HashPassword(null, userDto.Password),
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Avatar = userDto.Avatar,
                    UserName = userDto.Email,
                    CreatedDate = DateTime.Now

                };

                var result = await this.userManager.CreateAsync(userToInsert);


                var rolesResult = await this.userManager.AddToRolesAsync(userToInsert, userDto.Roles);

                // returns a url of the user that was created 
                // https://www.code4it.dev/blog/createdAtRoute-createdAtAction
                // https://stackoverflow.com/questions/47939945/how-to-use-created-or-createdataction-createdatroute-in-an-asp-net-core-api#64315534
                return CreatedAtAction(nameof(GetUser), new { id = userDto.Id }, userDto);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpPost("follow")]
        public IActionResult Follow([FromBody] FollowersDto followersDto)
        {
            // "helped me alot" https://www.youtube.com/watch?v=j1e6Z-7QNpk

            var followed = followersDto.FollowedUserId; // 
            var following = followersDto.FollowerId;
            // check to avoid a user to follower themselves 
            if (followed == following)
            {
                return BadRequest();
            }

            // Ensured the user represented by followerId exists in the db
            var followerUser = _context.Users.Find(followersDto.FollowerId);
            if (followerUser == null)
            {
                return BadRequest();
            }
            // Ensured the user represented by userIdToFollow exists on the db
            var followedUser = _context.Users.Find(followersDto.FollowedUserId);
            if (followedUser == null)
            {
                return BadRequest();
            }
            // check if the user userIdToFollow is already followed by the user followerId then return conflict
            var isAlreadyFollowed = _context.UserFollowers.Any(uf => uf.FollowedUserId == followersDto.FollowedUserId
             && uf.FollowerId == followersDto.FollowerId);

            if (isAlreadyFollowed)
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
        [HttpGet]
        [Route("followers/{id}")]
        public IActionResult GetUserFollowerById(Guid id)
        {
            // check db if user exist
            var userFollowed = _context.Users.Find(id);
            if (userFollowed == null)
            {
                return NotFound();
            }

            // https://stackoverflow.com/questions/7582316/linq-query-where-condition
            // https://www.geeksforgeeks.org/linq-filtering-operator-where/
            // Where operator filters the value according to the predicate function
            // search the db where userfollowerid is equal to the follower 
            var listOfFollowedUsers = _context.UserFollowers.Where(uf => uf.FollowedUserId == id).Select(d => d.Follower).ToList();

            // return the list of followers
            return Ok(listOfFollowedUsers);
        }



    }
}