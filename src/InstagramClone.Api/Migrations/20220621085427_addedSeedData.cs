using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstagramClone.Api.Migrations
{
    public partial class addedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: new Guid("3eaefc7b-aeb4-422b-b517-95b1dacc4ce6"),
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 54, 26, 483, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"),
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 54, 26, 483, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b09f27ac-8cae-4c87-9e7f-4a1cbb7925f2"),
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 54, 26, 483, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "UserFollowers",
                keyColumns: new[] { "FollowedUserId", "FollowerId" },
                keyValues: new object[] { new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21") },
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 54, 26, 483, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 54, 26, 483, DateTimeKind.Local).AddTicks(1522));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: new Guid("3eaefc7b-aeb4-422b-b517-95b1dacc4ce6"),
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 48, 11, 938, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"),
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 48, 11, 938, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b09f27ac-8cae-4c87-9e7f-4a1cbb7925f2"),
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 48, 11, 938, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "UserFollowers",
                keyColumns: new[] { "FollowedUserId", "FollowerId" },
                keyValues: new object[] { new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21") },
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 48, 11, 938, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                column: "CreatedDate",
                value: new DateTime(2022, 6, 21, 9, 48, 11, 938, DateTimeKind.Local).AddTicks(1518));
        }
    }
}
