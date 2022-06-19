using InstagramClone.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Configuration
{
    public static class UserConfiguration
    {

        public static void SeedUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = new  Guid("50ED31B9-30AE-4E7A-BEEF-5997EABA8A21"),// 1
                        Email = "ehuerikenbaba@gmail.com",
                        Password = "12345",
                        FirstName = "Ehueriken",
                        LastName = "Obuse",
                        Avatar = "Sammy.jpeg",
                        CreatedDate = DateTime.Now
                       

                    },
                    new User
                    {
                        Id = new Guid("88E18C3A-8EC4-4008-B36E-F1925525472E"), //2
                        Email = "ehueriken@gmail.com",
                        Password = "123456",
                        FirstName = "Samuel",
                        LastName = "Ehueriken",
                        Avatar = "Sammy.jpeg"

                    },
                    new User
                    {
                        Id = new Guid("4FF2CD54-D7AC-4066-91D4-F646B0C5A6EA"),
                        Email = "baba@gmail.com",
                        Password = "1234567",
                        FirstName = "Ehimah",
                        LastName = "Obuse",
                        Avatar = "Sammy.jpeg"

                    }
                ) ;
        }
    }
}
