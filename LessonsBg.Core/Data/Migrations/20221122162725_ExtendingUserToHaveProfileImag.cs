using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class ExtendingUserToHaveProfileImag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "845d0b5e-2c47-41a9-989d-95afcdb7edac");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("29c95f37-0968-4859-b363-ebba8627cf79"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("796e81b0-19bb-49eb-b3d3-fa28611953c5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d911612e-e4ff-49a7-b84a-be8bf7ef2657"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f9caa58d-cc09-493f-a63a-8e9026f001b7"));

            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "34731f1c-a3c0-485b-a0da-abc5cb2f90d9", 0, "1b0d2206-77ef-4f57-a6d7-70488e3593ba", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAECsXFKOs4DYZB9VyXqhqHGG8rjVkepwMQz+SZ2tLH+9++BUm/EGh7yVlRjFSDWKM/Q==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "8a243895-c32d-4092-bfe1-65f9c94c6011", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("160a6416-3a61-415f-82e1-e55c03fb8006"), "Български език", 2 },
                    { new Guid("8a5ec07d-fb4c-429f-869b-46daeee25cb6"), "Математика", 1 },
                    { new Guid("b53606df-3802-4d1f-8073-cdc72ccc9f5e"), "Английски език", 2 },
                    { new Guid("c958e0a6-2423-40e0-a071-5d499d299e82"), "Информационни технологии", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34731f1c-a3c0-485b-a0da-abc5cb2f90d9");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("160a6416-3a61-415f-82e1-e55c03fb8006"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8a5ec07d-fb4c-429f-869b-46daeee25cb6"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b53606df-3802-4d1f-8073-cdc72ccc9f5e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c958e0a6-2423-40e0-a071-5d499d299e82"));

            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "845d0b5e-2c47-41a9-989d-95afcdb7edac", 0, "5476ce8c-99be-4d94-9e9c-a88f379e0706", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEOIcrA37iKHgcv0JX1JW6cZiqgFMFEAB8/p047bL3uws/Z1UE6SCVxldQedr2v6aUQ==", "0896782014", true, "bf5c124d-72eb-4c3b-af06-3c82ff7036e8", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("29c95f37-0968-4859-b363-ebba8627cf79"), "Информационни технологии", 3 },
                    { new Guid("796e81b0-19bb-49eb-b3d3-fa28611953c5"), "Математика", 1 },
                    { new Guid("d911612e-e4ff-49a7-b84a-be8bf7ef2657"), "Английски език", 2 },
                    { new Guid("f9caa58d-cc09-493f-a63a-8e9026f001b7"), "Български език", 2 }
                });
        }
    }
}
