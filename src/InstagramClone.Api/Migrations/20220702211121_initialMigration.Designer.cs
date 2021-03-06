// <auto-generated />
using System;
using InstagramClone.Api.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InstagramClone.Api.Migrations
{
    [DbContext(typeof(InstagramCloneDbContext))]
    [Migration("20220702211121_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InstagramClone.Api.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b09f27ac-8cae-4c87-9e7f-4a1cbb7925f2"),
                            AuthorId = new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                            Content = "My instagram clone",
                            CreatedDate = new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(9079)
                        },
                        new
                        {
                            Id = new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"),
                            AuthorId = new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"),
                            Content = "My second post",
                            CreatedDate = new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(9083)
                        });
                });

            modelBuilder.Entity("InstagramClone.Api.Entities.PostReaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("PostReactions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3eaefc7b-aeb4-422b-b517-95b1dacc4ce6"),
                            AuthorId = new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                            CreatedDate = new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(9120),
                            PostId = new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"),
                            Type = 2
                        });
                });

            modelBuilder.Entity("InstagramClone.Api.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                            Avatar = "Sammy.jpeg",
                            CreatedDate = new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(8894),
                            Email = "ehuerikenbaba@gmail.com",
                            FirstName = "Ehueriken",
                            LastName = "Obuse",
                            Password = "12345"
                        },
                        new
                        {
                            Id = new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"),
                            Avatar = "Sammy.jpeg",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ehueriken@gmail.com",
                            FirstName = "Samuel",
                            LastName = "Ehueriken",
                            Password = "123456"
                        },
                        new
                        {
                            Id = new Guid("4ff2cd54-d7ac-4066-91d4-f646b0c5a6ea"),
                            Avatar = "Sammy.jpeg",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "baba@gmail.com",
                            FirstName = "Ehimah",
                            LastName = "Obuse",
                            Password = "1234567"
                        });
                });

            modelBuilder.Entity("InstagramClone.Api.Entities.UserFollower", b =>
                {
                    b.Property<Guid>("FollowedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FollowerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FollowedUserId", "FollowerId");

                    b.HasIndex("FollowerId");

                    b.ToTable("UserFollowers");

                    b.HasData(
                        new
                        {
                            FollowedUserId = new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"),
                            FollowerId = new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                            CreatedDate = new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(9101)
                        });
                });

            modelBuilder.Entity("InstagramClone.Api.Entities.Post", b =>
                {
                    b.HasOne("InstagramClone.Api.Entities.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("InstagramClone.Api.Entities.PostReaction", b =>
                {
                    b.HasOne("InstagramClone.Api.Entities.User", "Author")
                        .WithMany("Reactions")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InstagramClone.Api.Entities.Post", "Post")
                        .WithMany("PostReactions")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("InstagramClone.Api.Entities.UserFollower", b =>
                {
                    b.HasOne("InstagramClone.Api.Entities.User", "FollowedUser")
                        .WithMany("Followed")
                        .HasForeignKey("FollowedUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InstagramClone.Api.Entities.User", "Follower")
                        .WithMany("Followers")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FollowedUser");

                    b.Navigation("Follower");
                });

            modelBuilder.Entity("InstagramClone.Api.Entities.Post", b =>
                {
                    b.Navigation("PostReactions");
                });

            modelBuilder.Entity("InstagramClone.Api.Entities.User", b =>
                {
                    b.Navigation("Followed");

                    b.Navigation("Followers");

                    b.Navigation("Posts");

                    b.Navigation("Reactions");
                });
#pragma warning restore 612, 618
        }
    }
}
