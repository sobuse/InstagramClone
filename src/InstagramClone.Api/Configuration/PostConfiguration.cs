using InstagramClone.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Configuration
{
    public static class PostConfiguration
    {
        public static void SeedPost(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = new Guid("B09F27AC-8CAE-4C87-9E7F-4A1CBB7925F2"),
                Content = "My instagram clone",
                AuthorId = new Guid(),
                CreatedDate = DateTime.Now,
               
            },
            new Post
            {
                Id = new Guid("9E09FC2D-3A7D-4AC0-B58B-83D256A3FA95"),
                Content = "My second post",
                AuthorId = new Guid("88E18C3A-8EC4-4008-B36E-F1925525472E"),   // 2
                CreatedDate = DateTime.Now,
                
            }
            ); ;
        }
    }
}
