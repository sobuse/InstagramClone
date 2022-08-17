using InstagramClone.Api.Configuration;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Database
{
    public class InstagramCloneDbContext : IdentityDbContext<User, ApplicationRole, Guid>//IdentityDbContext<User> // IdentityDbContext<ApplicationUser> //DbContext
    {
        public InstagramCloneDbContext(DbContextOptions<InstagramCloneDbContext> options) : base(options)
        {

        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Post>().HasKey(p => p.Id);
            modelBuilder.Entity<PostReaction>().HasKey(pr => pr.Id);

            // composite Key
            modelBuilder.Entity<UserFollower>()
                .HasKey(userfollower => 
                new {userfollower.FollowedUserId, userfollower.FollowerId});
           

            // one to many relationship
            modelBuilder.Entity<Post>().HasOne<User>(post => post.Author)
                .WithMany( user => user.Posts)
                .HasForeignKey(fk => fk.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostReaction>()
                .HasOne(p => p.Author).
                WithMany(u => u.Reactions)
                .HasForeignKey(fk => fk.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
                

            modelBuilder.Entity<PostReaction>().HasOne<Post>(reaction => reaction.Post)
                .WithMany(posts => posts.PostReactions)
                .HasForeignKey(fk => fk.PostId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<UserFollower>()
                .HasOne<User>(us => us.FollowedUser)
                .WithMany(u => u.Followed)
                .HasForeignKey(fk => fk.FollowedUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserFollower>()
                .HasOne(d => d.Follower)
                .WithMany(m => m.Followers)
                .HasForeignKey(fk => fk.FollowerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.SeedUser();
            modelBuilder.SeedPost();
            modelBuilder.SeedUserFollower();
        
            modelBuilder.SeedPostReaction();

        }

        
       
       public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }
        public DbSet<UserFollower> UserFollowers { get; set; }
      
    }
}
