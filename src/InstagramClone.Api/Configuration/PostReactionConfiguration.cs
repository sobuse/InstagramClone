using InstagramClone.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Configuration
{
    public static  class PostReactionConfiguration
    {
        public static void SeedPostReaction(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostReaction>().HasData(
                new PostReaction
                {
                    Id = new Guid("3EAEFC7B-AEB4-422B-B517-95B1DACC4CE6"),
                    PostId = new Guid("9E09FC2D-3A7D-4AC0-B58B-83D256A3FA95"), //2 from post
                    AuthorId = new Guid("9E09FC2D-3A7D-4AC0-B58B-83D256A3FA95"),
                    Type = 2,
                    CreatedDate = DateTime.Now
                }
                );
        }
    }
}
