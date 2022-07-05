using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using InstagramClone.Api.Database;
using InstagramClone.Api.Entities;

using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Controllers
{

    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private readonly InstagramCloneDbContext _context;
        public UsersController(InstagramCloneDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("{id:Guid}")]
        public IHttpActionResult GetUser(Guid id)
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

    }
}