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
    //[ApiController]
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private readonly InstagramCloneDbContext _context;
        public UsersController(InstagramCloneDbContext context)
        {
            _context = context;
        }

        [Route("{id:Guid}")]
        public IHttpActionResult GetUser(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

    }
}