using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstagramClone.Api.Migrations
{
    public partial class removedRolesFromUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_UserManagerId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_UserManagerId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "UserManagerId",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ab2c24a-e944-4112-9642-6e46f6bada96"),
                column: "ConcurrencyStamp",
                value: "45493ad3-86a6-4561-9fc8-c9c06d24e841");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a26dfa63-7b56-49ab-9452-9efc992132f0"),
                column: "ConcurrencyStamp",
                value: "c73a4b83-8464-4c4e-9d72-098631a18506");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4ff2cd54-d7ac-4066-91d4-f646b0c5a6ea"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a85db29-3d65-47d0-9d1e-afaf21b59cb6", "AQAAAAEAACcQAAAAEL+O8TfkOyq33Krpn3zvH76KkFxbVDOSA7U8gYS1d1SAEmJq+0BDTXqErbImhieu+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "6a857c6c-27b8-464d-aaaf-da6896c5bc46", new DateTime(2022, 9, 2, 22, 44, 34, 189, DateTimeKind.Local).AddTicks(2398), "AQAAAAEAACcQAAAAEOHvoGekGkL4k4Qef8/+BZRv9q1c0cOmxvSVmaFOiJscqUqjBqvYK7QeAXwWexRU2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7e04e34-4323-4f3f-bf90-1de950773e24", "AQAAAAEAACcQAAAAEOmrBVym7asy8Ct6YIvXgfml8USTBbqIb8SFaTFKX7wxFUlg34eNm4McvB15kIteeQ==" });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: new Guid("3eaefc7b-aeb4-422b-b517-95b1dacc4ce6"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 2, 22, 44, 34, 212, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 2, 22, 44, 34, 212, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b09f27ac-8cae-4c87-9e7f-4a1cbb7925f2"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 2, 22, 44, 34, 212, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "UserFollowers",
                keyColumns: new[] { "FollowedUserId", "FollowerId" },
                keyValues: new object[] { new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21") },
                column: "CreatedDate",
                value: new DateTime(2022, 9, 2, 22, 44, 34, 212, DateTimeKind.Local).AddTicks(977));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserManagerId",
                table: "AspNetRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ab2c24a-e944-4112-9642-6e46f6bada96"),
                column: "ConcurrencyStamp",
                value: "222f4184-d544-4707-84f8-69f65e2da8a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a26dfa63-7b56-49ab-9452-9efc992132f0"),
                column: "ConcurrencyStamp",
                value: "65509b95-9673-438d-8396-0c8a89d44e31");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4ff2cd54-d7ac-4066-91d4-f646b0c5a6ea"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ad01377-ba27-412e-81d4-ee7d3ac0d37e", "AQAAAAEAACcQAAAAEM9/3+D48LZ3nN1tvU15Hvj+rtUZO38Wtq3Hm32kOYJ6ruv5xC1vc6GMNVVPvRpAGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "f5bea1bb-0fbf-4153-836a-453d258a7b3f", new DateTime(2022, 9, 1, 9, 52, 32, 945, DateTimeKind.Local).AddTicks(9086), "AQAAAAEAACcQAAAAEExiUIlMs7R0AQaYlcc2Vp7uKjoE1Qb3dJDuvOdIIKuvEu7kHVp6U8Ru+WVM2d/Ywg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba0a2dd2-ae9f-43c8-a02c-ed3f7d9cccda", "AQAAAAEAACcQAAAAEFfQPGMTD9SplA7MW5dnIDPPkaTNG56xQp7nFWnCkyw7LJDeLkgCyDoOkNuX/VmCPA==" });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: new Guid("3eaefc7b-aeb4-422b-b517-95b1dacc4ce6"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 1, 9, 52, 32, 965, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 1, 9, 52, 32, 965, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b09f27ac-8cae-4c87-9e7f-4a1cbb7925f2"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 1, 9, 52, 32, 965, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "UserFollowers",
                keyColumns: new[] { "FollowedUserId", "FollowerId" },
                keyValues: new object[] { new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21") },
                column: "CreatedDate",
                value: new DateTime(2022, 9, 1, 9, 52, 32, 965, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_UserManagerId",
                table: "AspNetRoles",
                column: "UserManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_UserManagerId",
                table: "AspNetRoles",
                column: "UserManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
