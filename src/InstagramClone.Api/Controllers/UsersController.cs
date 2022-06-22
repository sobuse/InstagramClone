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
    [Route("api/[controller]")] // /users/:id
    public class UsersController : ControllerBase
    {
        private readonly InstagramCloneDbContext _context;
        public UsersController(InstagramCloneDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }


        //  api/users/:id
        [HttpGet("{Id}")]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            return await _context.Users.FindAsync(id);

        }

    }
}