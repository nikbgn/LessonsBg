using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class SubjectsConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e74bace2-2544-4bf4-b250-ce73f91d991f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1fb45ac3-ff78-46b9-9682-f06bd1b2e69b", 0, "78eccb2f-2f97-4ba6-8a4f-f55b0a366a59", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEOWL9aEYv2WJrPEhPhmLI4mYH40dZh6ONwRgvxlEABhwLJArkkQUAUWJ0UiaPSwBaA==", "0896782014", true, "7b52b990-b605-452c-bfc1-88fbbbe4fba7", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "ApplicationUserId", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("614f6927-7bc5-4f4e-83d9-e28949f2f4b8"), null, "Math", 1 },
                    { new Guid("80cf63a8-18f0-4fb9-a99b-75fd5d5541d7"), null, "English Language", 2 },
                    { new Guid("81df911b-3df5-4295-8deb-7ad44e2dbac3"), null, "Informational Technologies", 3 },
                    { new Guid("e87ab44c-0c99-491c-b07b-222958db4aec"), null, "Bulgarian Language", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fb45ac3-ff78-46b9-9682-f06bd1b2e69b");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("614f6927-7bc5-4f4e-83d9-e28949f2f4b8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("80cf63a8-18f0-4fb9-a99b-75fd5d5541d7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("81df911b-3df5-4295-8deb-7ad44e2dbac3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e87ab44c-0c99-491c-b07b-222958db4aec"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e74bace2-2544-4bf4-b250-ce73f91d991f", 0, "ae102d2b-784a-4edd-8909-397430460436", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEGCeWar3aFucH3EyQO4BCXYriZ9hdh7PTGKh8phSzW1d5P3rUQ1eHMjFaIFigSi59g==", "0896782014", true, "79886fe2-0882-4abe-b31a-c637c0ddc232", false, "niki_admin@niki.bg" });
        }
    }
}
