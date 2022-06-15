using InstagramClone.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Api.Database
{
    public class InstagramCloneDbContext : DbContext
    {
        public InstagramCloneDbContext(DbContextOptions options) : base(options)
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
            modelBuilder.Entity<Post>().HasOne<User>(post => post.Author)
                .WithMany( user => user.Posts)
                .HasForeignKey(fk => fk.AuthorId);
            modelBuilder.Entity<PostReaction>().HasOne<Post>(reaction => reaction.Post)
                .WithMany(posts => posts.PostReactions)
                .HasForeignKey(fk => fk.PostId);
            //modelBuilder.Entity<UserFollower>()
            //    .HasOne<User>(follower => follower.FollowedUser)
            //    .WithMany(u => u.Users)
            //    .HasForeignKey();

            // many to many relationship

            modelBuilder.Entity<User_UserFollower>()
                .HasOne(user => user.User)
                .WithMany(Uf => Uf.User_UserFollower)
                .HasForeignKey(u => u.Id);

            modelBuilder.Entity<User_UserFollower>()
                .HasOne(user => user.UserFollower)
                .WithMany(Uf => Uf.User_UserFollower)
                .HasForeignKey(u => u.FollowerId);

        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }
        public DbSet<UserFollower> UserFollowers { get; set; }
        public DbSet<User_UserFollower> user_UserFollowers { get; set; }


    }
}
