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
                        Id = Guid.NewGuid(),
                        Email = "ehuerikenbaba@gmail.com",
                        Password = "12345",
                        FirstName = "Ehueriken",
                        LastName = "Obuse",
                        Avatar = "Sammy.jpeg",
                        Posts = new List<Post> { new Post
                        {
                            new Post(){Id = Guid.NewGuid(), Content = "Hello world" ,a }
                        } }


                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Email = "ehueriken@gmail.com",
                        Password = "123456",
                        FirstName = "Samuel",
                        LastName = "Ehueriken",
                        Avatar = "Sammy.jpeg"

                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
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
