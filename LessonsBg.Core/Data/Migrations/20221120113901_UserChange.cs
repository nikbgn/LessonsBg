using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class UserChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbc5295a-e900-4e4a-a96b-2d47368f6e36");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("430dc2fa-440c-461d-b147-69ec260077ea"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c64745eb-e0e0-47ff-a70d-709d8dc10515"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c8c9632d-2966-452c-afb4-a2315f99e120"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e39ed3a9-8938-412b-8026-ec0dc1d8b261"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "73a8535a-fb83-4ff4-ad4f-b90a6aa59c1b", 0, "60486b65-28e3-46eb-ad18-407bd8a152b7", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAED9mKNargMVezm3j1SFsxc4rTt04UQdQEQmdxg/Zgl5nzwtlZtyqWcOJ/RheRdo6TQ==", "0896782014", true, "06dd30b6-3c0f-44ea-9891-06d208e4aa3d", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("0716ddc0-3ffe-462f-a10a-a99bf3560b91"), "Math", 1 },
                    { new Guid("24e6559d-9f5e-447f-88fe-b9f865e412dd"), "Informational Technologies", 3 },
                    { new Guid("39fee1bf-9acb-4ff2-89c8-d3f07f195995"), "Bulgarian Language", 2 },
                    { new Guid("7ce4ad31-09e2-4676-ac01-ace5ebd9e2be"), "English Language", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a8535a-fb83-4ff4-ad4f-b90a6aa59c1b");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0716ddc0-3ffe-462f-a10a-a99bf3560b91"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("24e6559d-9f5e-447f-88fe-b9f865e412dd"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("39fee1bf-9acb-4ff2-89c8-d3f07f195995"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7ce4ad31-09e2-4676-ac01-ace5ebd9e2be"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cbc5295a-e900-4e4a-a96b-2d47368f6e36", 0, "8fc728f4-f843-4592-a423-762f022ae857", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEHrd9hR0RQ4kU3TN4X+TPStdsv4QM2C7eCv0CR+QPVd+iP3435ow6tiWMmzsFteiAw==", "0896782014", true, "9089744d-b423-43b1-9cfc-8f06d988bf63", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("430dc2fa-440c-461d-b147-69ec260077ea"), "English Language", 2 },
                    { new Guid("c64745eb-e0e0-47ff-a70d-709d8dc10515"), "Math", 1 },
                    { new Guid("c8c9632d-2966-452c-afb4-a2315f99e120"), "Informational Technologies", 3 },
                    { new Guid("e39ed3a9-8938-412b-8026-ec0dc1d8b261"), "Bulgarian Language", 2 }
                });
        }
    }
}
