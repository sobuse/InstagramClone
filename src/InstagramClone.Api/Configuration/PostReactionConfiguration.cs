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
                    Id = new Guid("3EAEFC7B-AEB4-422B-B517-95B1DACC4CE6"), // postreaction type 2
                    PostId = new Guid("9E09FC2D-3A7D-4AC0-B58B-83D256A3FA95"), // post 2
                    AuthorId = new Guid("50ED31B9-30AE-4E7A-BEEF-5997EABA8A21"), // User 1 reacted to the post
                    Type = 2,
                    CreatedDate = DateTime.Now
                }
                );
        }
    }
}
