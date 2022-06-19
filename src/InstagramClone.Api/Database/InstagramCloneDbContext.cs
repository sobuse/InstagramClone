using InstagramClone.Api.Configuration;
using InstagramClone.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Database
{
    public class InstagramCloneDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DefaultConnectionString");
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Post>().HasKey(p => p.Id);
            modelBuilder.Entity<PostReaction>().HasKey(pr => pr.Id);

            // composite Key
            modelBuilder.Entity<UserFollower>().HasKey(userfollower => new {userfollower.FollowedUserId, userfollower.FollowerId});
           

            // one to many relationship
            modelBuilder.Entity<Post>().HasOne<User>(post => post.Author)
                .WithMany( user => user.Posts)
                .HasForeignKey(fk => fk.AuthorId);

            modelBuilder.Entity<PostReaction>().HasOne<Post>(reaction => reaction.Post)
                .WithMany(posts => posts.PostReactions)
                .HasForeignKey(fk => fk.PostId);


            modelBuilder.Entity<UserFollower>()
                .HasOne<User>(us => us.FollowedUser)
                .WithMany(u => u.Followed)
                .HasForeignKey(fk => fk.FollowedUserId);

            modelBuilder.Entity<UserFollower>()
                .HasOne(d => d.Follower)
                .WithMany(m => m.Followers)
                .HasForeignKey(fk => fk.FollowerId);

            modelBuilder.SeedUser();
            modelBuilder.SeedPost();
            modelBuilder.UserFollowerSeed();
        
            modelBuilder.SeedPostReaction();

        }

        
       
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }
        public DbSet<UserFollower> UserFollowers { get; set; }
      
    }
}
