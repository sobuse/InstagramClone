using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstagramClone.Api.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserFollowers",
                columns: table => new
                {
                    FollowedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollowers", x => new { x.FollowedUserId, x.FollowerId });
                    table.ForeignKey(
                        name: "FK_UserFollowers_Users_FollowedUserId",
                        column: x => x.FollowedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFollowers_Users_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostReactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostReactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostReactions_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedDate", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new Guid("4ff2cd54-d7ac-4066-91d4-f646b0c5a6ea"), "Sammy.jpeg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "baba@gmail.com", "Ehimah", "Obuse", "1234567" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedDate", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"), "Sammy.jpeg", new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(8894), "ehuerikenbaba@gmail.com", "Ehueriken", "Obuse", "12345" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedDate", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), "Sammy.jpeg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ehueriken@gmail.com", "Samuel", "Ehueriken", "123456" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedDate" },
                values: new object[] { new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"), new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), "My second post", new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedDate" },
                values: new object[] { new Guid("b09f27ac-8cae-4c87-9e7f-4a1cbb7925f2"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"), "My instagram clone", new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.InsertData(
                table: "UserFollowers",
                columns: new[] { "FollowedUserId", "FollowerId", "CreatedDate" },
                values: new object[] { new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"), new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "PostId", "Type" },
                values: new object[] { new Guid("3eaefc7b-aeb4-422b-b517-95b1dacc4ce6"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"), new DateTime(2022, 7, 2, 22, 11, 20, 886, DateTimeKind.Local).AddTicks(9120), new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_AuthorId",
                table: "PostReactions",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_PostId",
                table: "PostReactions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowers_FollowerId",
                table: "UserFollowers",
                column: "FollowerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostReactions");

            migrationBuilder.DropTable(
                name: "UserFollowers");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
