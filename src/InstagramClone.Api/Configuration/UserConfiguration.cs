﻿ using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Configuration
{
    public static class UserConfiguration
    {

        public static void SeedUser(this ModelBuilder modelBuilder)
        {
            // defined an instance of password hasher to be used to hash password
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = new  Guid("50ED31B9-30AE-4E7A-BEEF-5997EABA8A21"),//  user 1
                        Email = "ehuerikenbaba@gmail.com",
                        PasswordHash = hasher.HashPassword(null, "12345"),
                        FirstName = "Ehueriken",
                        LastName = "Obuse",
                        Avatar = "https://api.lorem.space/image/face?w=150&h=150",                    
                        CreatedDate = DateTime.Now
                       

                    },
                    new User
                    {
                        Id = new Guid("88E18C3A-8EC4-4008-B36E-F1925525472E"), // user 2
                        Email = "ehueriken@gmail.com",
                        PasswordHash = hasher.HashPassword(null, "12345"),
                        FirstName = "Samuel",
                        LastName = "Ehueriken",
                        Avatar = "https://api.lorem.space/image/face?w=150&h=150"

                    },
                    new User
                    {
                        Id = new Guid("4FF2CD54-D7AC-4066-91D4-F646B0C5A6EA"),  // user 3
                        Email = "baba@gmail.com",
                        PasswordHash = hasher.HashPassword(null, "12345"),
                        FirstName = "Ehimah",
                        LastName = "Obuse",
                        Avatar = "https://api.lorem.space/image/face?w=150&h=150"

                    }
                ) ;
        }
    }
}
