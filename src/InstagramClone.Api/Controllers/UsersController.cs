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
            // https://stackoverflow.com/questions/47939945/how-to-use-created-or-createdataction-createdatroute-in-an-asp-net-core-api#64315534
            return CreatedAtAction(nameof(GetUser),new {id = userDto.Id },  userDto);
        } 

    }
}