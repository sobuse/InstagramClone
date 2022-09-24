using InstagramClone.Api.DTOs;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InstagramClone.Api.Authentication
{
    public class AuthenticationManager
    {
        private readonly UserManager<User> userManager;
        private readonly IConfiguration configuration;


        private  User user;

        public AuthenticationManager(UserManager<User> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth)
        {

            this.user  = await userManager.FindByEmailAsync(userForAuth.Email);

            return (user != null && await userManager.CheckPasswordAsync(user, userForAuth.Password));

        }

        public async Task<string> CreateToken()
        {
            var signingCreadentails = GetSigningCreadentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCreadentails, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

       

        private SigningCredentials GetSigningCreadentials()
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email)
            };

            var roles = await userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCreadentails, List<Claim> claims)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken
                (
                    issuer: jwtSettings.GetSection("validIssuer").Value,
                    audience: jwtSettings.GetSection("validAudience").Value,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("expires").Value)),
                    signingCredentials: signingCreadentails
                );

            return tokenOptions;
        }
    }
}
