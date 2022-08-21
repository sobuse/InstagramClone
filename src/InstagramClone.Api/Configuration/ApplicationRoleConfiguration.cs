using InstagramClone.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Configuration
{
    public static class ApplicationRoleConfiguration
    {
        public static void SeedRole(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(new List< ApplicationRole>
            {
                new ApplicationRole
                {
                    Id = new Guid("A26DFA63-7B56-49AB-9452-9EFC992132F0"),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                              
                }
                
            }); 
        }
    }
}
