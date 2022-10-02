using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstagramClone.Api.Migrations
{
    public partial class changedDbName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ab2c24a-e944-4112-9642-6e46f6bada96"),
                column: "ConcurrencyStamp",
                value: "55d7396d-ff96-4063-8195-62b8cc8c2f5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a26dfa63-7b56-49ab-9452-9efc992132f0"),
                column: "ConcurrencyStamp",
                value: "d55b2111-e996-47c5-b789-7b3b4d245392");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4ff2cd54-d7ac-4066-91d4-f646b0c5a6ea"),
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "https://api.lorem.space/image/face?w=150&h=150", "aed89fa2-2e0a-4367-be54-9894a1b61dbd", "AQAAAAEAACcQAAAAEB0Bdl707NQ3ChKotlflBvElOxUtkq3/sqP8HWmvc3iyN3XhXtNYoHniP8HZhxnoJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                columns: new[] { "Avatar", "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "https://api.lorem.space/image/face?w=150&h=150", "6d6c5419-dadb-4cae-913b-3aa42d57a98a", new DateTime(2022, 10, 2, 10, 2, 43, 592, DateTimeKind.Local).AddTicks(5742), "AQAAAAEAACcQAAAAEA4Hg35gcc6aFtprlVIOEgDROYGfGjqPE2v4WsE/LaT5RabrqTgxVwzPR9gzIC4PRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"),
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "https://api.lorem.space/image/face?w=150&h=150", "f081cfdc-cf5d-4239-9517-ae5d7c7c50c3", "AQAAAAEAACcQAAAAEMo53thWSUZDvOYo8dkyqTFq3vbP45tjLXvmUXfB+nJmm4O62vWWdNxUEV39D/CIKg==" });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: new Guid("3eaefc7b-aeb4-422b-b517-95b1dacc4ce6"),
                column: "CreatedDate",
                value: new DateTime(2022, 10, 2, 10, 2, 43, 616, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"),
                column: "CreatedDate",
                value: new DateTime(2022, 10, 2, 10, 2, 43, 616, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b09f27ac-8cae-4c87-9e7f-4a1cbb7925f2"),
                column: "CreatedDate",
                value: new DateTime(2022, 10, 2, 10, 2, 43, 616, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "UserFollowers",
                keyColumns: new[] { "FollowedUserId", "FollowerId" },
                keyValues: new object[] { new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21") },
                column: "CreatedDate",
                value: new DateTime(2022, 10, 2, 10, 2, 43, 616, DateTimeKind.Local).AddTicks(9087));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "Sammy.jpeg", "2a85db29-3d65-47d0-9d1e-afaf21b59cb6", "AQAAAAEAACcQAAAAEL+O8TfkOyq33Krpn3zvH76KkFxbVDOSA7U8gYS1d1SAEmJq+0BDTXqErbImhieu+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                columns: new[] { "Avatar", "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "Sammy.jpeg", "6a857c6c-27b8-464d-aaaf-da6896c5bc46", new DateTime(2022, 9, 2, 22, 44, 34, 189, DateTimeKind.Local).AddTicks(2398), "AQAAAAEAACcQAAAAEOHvoGekGkL4k4Qef8/+BZRv9q1c0cOmxvSVmaFOiJscqUqjBqvYK7QeAXwWexRU2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"),
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "Sammy.jpeg", "f7e04e34-4323-4f3f-bf90-1de950773e24", "AQAAAAEAACcQAAAAEOmrBVym7asy8Ct6YIvXgfml8USTBbqIb8SFaTFKX7wxFUlg34eNm4McvB15kIteeQ==" });

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
    }
}
