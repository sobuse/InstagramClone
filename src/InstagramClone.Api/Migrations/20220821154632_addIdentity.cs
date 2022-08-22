using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstagramClone.Api.Migrations
{
    public partial class addIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a26dfa63-7b56-49ab-9452-9efc992132f0"),
                column: "ConcurrencyStamp",
                value: "ab739766-9a34-4f0b-8b63-115254b85980");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4ff2cd54-d7ac-4066-91d4-f646b0c5a6ea"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e47d0b26-3ab2-45f8-9555-998b684c3392", "AQAAAAEAACcQAAAAEDwDFbw/xEc5TY5XVESp8A0pywYOLSFahC3WhZtuu+eCe5oYRjfPDH+gm3SRonuoXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "d7ba3324-91b8-49dd-bd38-25b2c5e0571b", new DateTime(2022, 8, 21, 16, 46, 31, 574, DateTimeKind.Local).AddTicks(6513), "AQAAAAEAACcQAAAAEJe2cbgUzMIrrR/+xhk94r4atkZRueueUt4I4jSKLwBINdC2Fizm3Mw3Iq5XvQbD1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4985e09c-f3f3-4a4f-86e9-a64686f5b20f", "AQAAAAEAACcQAAAAELEINfD6uATzrjzeAtcwip3H5w0f8qOxq4Xu1bbZtt70Wwq7UjVNF2k+pbzO/IPpAQ==" });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: new Guid("3eaefc7b-aeb4-422b-b517-95b1dacc4ce6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 21, 16, 46, 31, 601, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 21, 16, 46, 31, 601, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b09f27ac-8cae-4c87-9e7f-4a1cbb7925f2"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 21, 16, 46, 31, 601, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "UserFollowers",
                keyColumns: new[] { "FollowedUserId", "FollowerId" },
                keyValues: new object[] { new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21") },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 21, 16, 46, 31, 601, DateTimeKind.Local).AddTicks(2066));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a26dfa63-7b56-49ab-9452-9efc992132f0"),
                column: "ConcurrencyStamp",
                value: "c6023bd4-c5bf-435f-924b-2b2656968da6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4ff2cd54-d7ac-4066-91d4-f646b0c5a6ea"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a596167c-56a8-4496-a767-59584219c589", "AQAAAAEAACcQAAAAEJy1MJYZpWhQIInH4i/JUIdWRb43nuJXoGLBE6d574H7Xh0tC/NiKjDHmf20kudvUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "a57b5494-945f-4788-a2fd-8aba6495fd6a", new DateTime(2022, 8, 21, 16, 5, 45, 520, DateTimeKind.Local).AddTicks(9139), "AQAAAAEAACcQAAAAECo3zi7xw+YsIjuiCMnHADNC6jL4UjRX3nDkrjv6u99CzdBQW/AlieMKtdUJSQjOuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3dedbddb-b452-4e2b-bb36-9c18de4f0d29", "AQAAAAEAACcQAAAAEFKOSVS6nM07J96u44ARDRBdSS/1rCRqvZW3BLCgNtMmgraxzrNyirZxdHxY4QvLUw==" });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: new Guid("3eaefc7b-aeb4-422b-b517-95b1dacc4ce6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 21, 16, 5, 45, 541, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9e09fc2d-3a7d-4ac0-b58b-83d256a3fa95"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 21, 16, 5, 45, 541, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b09f27ac-8cae-4c87-9e7f-4a1cbb7925f2"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 21, 16, 5, 45, 541, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "UserFollowers",
                keyColumns: new[] { "FollowedUserId", "FollowerId" },
                keyValues: new object[] { new Guid("88e18c3a-8ec4-4008-b36e-f1925525472e"), new Guid("50ed31b9-30ae-4e7a-beef-5997eaba8a21") },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 21, 16, 5, 45, 541, DateTimeKind.Local).AddTicks(7148));
        }
    }
}
