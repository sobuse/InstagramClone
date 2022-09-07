using InstagramClone.Api.Authentication;
using InstagramClone.Api.DTOs;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace InstagramClone.Api.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly UserManager<User> userManager;
        private readonly AuthenticationManager authenticationManager;

        public AuthenticationController(UserManager<User> userManager, AuthenticationManager authenticationManager)
        {
            this.userManager = userManager;
            this.authenticationManager = authenticationManager;
        }

       // [HttpPost("login")]
        [Authorize]
        public async Task<IActionResult> Authenticate([System.Web.Http.FromBody] UserForAuthenticationDto user)
        {
            if (!await authenticationManager.ValidateUser(user))
            {
                return Unauthorized();
            }
            return Ok(new { Token = await authenticationManager.CreateToken() });
        }
    }
}
