using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InstagramClone.Api.Database;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> PostUsers([FromBody] User user)
        {

            if (user == null)
                return BadRequest();
            this._context.Users.Add(user);
            this._context.SaveChanges();

            return CreatedAtRoute("GetUser",
                    new
                    {
                        id = user.Id,
                        Controller = "users"
                    },
                    user
                );

        }

    }
}