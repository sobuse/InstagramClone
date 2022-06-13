using InstagramClone.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Database
{
    public class InstagramCloneDbContext : DbContext
    {
        public InstagramCloneDbContext(): base()
        {

        }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Post>().HasKey(p => p.Id);
            modelBuilder.Entity<PostReaction>().HasKey(pr => pr.Id);
            modelBuilder.Entity<UserFollower>().HasKey(userFollower => userFollower.FollowedUserId);



            modelBuilder.Entity<Post>().HasOne<User>(post => post.Author).WithMany( user => user.Posts);
           

           
        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }
        public DbSet<UserFollower> UserFollowers { get; set; }


    }
}
