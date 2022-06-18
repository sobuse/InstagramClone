using InstagramClone.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Configuration
{
    public  static class UserFollowerConfiguration
    {
        public static void UserFollowerSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFollower>().HasData(new UserFollower
            {
                FollowedUserId =   new Guid("88E18C3A-8EC4-4008-B36E-F1925525472E"),
                FollowerId = new Guid("50ED31B9-30AE-4E7A-BEEF-5997EABA8A21")
            }, 
            
            new UserFollower
            {
                FollowerId = new Guid("50ED31B9-30AE-4E7A-BEEF-5997EABA8A21"),
                FollowedUserId = new Guid("88E18C3A-8EC4-4008-B36E-F1925525472E")
            }

                );

            
        }
    }
}
