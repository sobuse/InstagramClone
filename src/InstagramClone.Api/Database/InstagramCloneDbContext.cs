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

            // composite Key
            modelBuilder.Entity<UserFollower>().HasKey(userfollower => new {userfollower.FollowedUserId, userfollower.FollowerId});
           

            // one to many relationship
            modelBuilder.Entity<Post>().HasOne<User>(post => post.Author).WithMany( user => user.Posts);
            modelBuilder.Entity<PostReaction>().HasOne<Post>(reaction => reaction.Post).WithMany(posts => posts.PostReactions);
            modelBuilder.Entity<UserFollower>().HasOne<User>(follower => follower.FollowedUser).WithMany(u => u.Users);



        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }
        public DbSet<UserFollower> UserFollowers { get; set; }


    }
}
