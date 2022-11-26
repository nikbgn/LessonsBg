using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class testwoah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3783edf6-3cc3-4ee1-a320-05851c2ac35d");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1b1c58e1-af1c-456a-afe1-d9e642f3a520"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("23a16ed4-2cb0-4341-a2ef-6327c86533f4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("af22a7b4-3912-4f66-bfd3-675bbb054943"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("fca19d12-1567-4e61-9c39-a58c4ae68b66"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("032b879b-0822-450b-80a5-7b0055d7f095"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("038f39fb-1be3-4c1f-a8a8-47b52bc8b3b7"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("1261b6e9-2a1d-43a4-9265-bcb2df1cb874"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("9ce32a5c-6f78-4cd1-abf1-b9172b5dd62c"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("c2108c1a-4230-49a3-a7f9-6dcb5dc7907e"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("cf1dd7b3-3156-4606-8030-fbb4702e6887"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "34825817-a942-4df0-89de-8cac85eec704", 0, "a9c8495d-8cfe-48d7-9196-25fd3f1efbbe", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEBGhLtoYWxjMhJi7UoNIXhP75rWQKa7VZYEpo9+k8en9dttY3LslnXgtWbT9Sw4uZQ==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "def990fb-f8fd-4834-af08-e72745bd4f84", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("044b480e-64a3-41d0-8f01-dd7822b57c4e"), "Български език", 2 },
                    { new Guid("63cdcafb-a535-4481-9df2-1409b824b5d2"), "Английски език", 2 },
                    { new Guid("a4f0d0c3-1904-46e1-b4ca-3fe372854094"), "Информационни технологии", 3 },
                    { new Guid("f0007e1d-7a23-4b2f-98a1-d1374323b2f8"), "Математика", 1 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("486d0aa9-db2e-4bd1-a920-a0f5bebe2b46"), "Кикбокс", 1 },
                    { new Guid("4aadab05-193c-4fb8-a5be-15840da3f4b5"), "Баскетбол", 2 },
                    { new Guid("53be7d57-8523-4175-a481-275352978ca9"), "Волейбол", 2 },
                    { new Guid("a6133e3a-6733-4ea9-ad95-4c0ea98d9d80"), "Карате", 1 },
                    { new Guid("ceb2dc00-70fc-4500-a97d-a5f2c9c6a121"), "Футбол", 2 },
                    { new Guid("db007776-3019-48b4-84e8-a3ef7ae11d5d"), "Таекуондо", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34825817-a942-4df0-89de-8cac85eec704");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("044b480e-64a3-41d0-8f01-dd7822b57c4e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("63cdcafb-a535-4481-9df2-1409b824b5d2"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a4f0d0c3-1904-46e1-b4ca-3fe372854094"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f0007e1d-7a23-4b2f-98a1-d1374323b2f8"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("486d0aa9-db2e-4bd1-a920-a0f5bebe2b46"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("4aadab05-193c-4fb8-a5be-15840da3f4b5"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("53be7d57-8523-4175-a481-275352978ca9"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("a6133e3a-6733-4ea9-ad95-4c0ea98d9d80"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("ceb2dc00-70fc-4500-a97d-a5f2c9c6a121"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("db007776-3019-48b4-84e8-a3ef7ae11d5d"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3783edf6-3cc3-4ee1-a320-05851c2ac35d", 0, "b9ed91aa-e770-42b2-8c97-e8990618192a", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAELBvUkT3sze5+XvCBOLy6xeqgREruI9iElxjp4wwP+rdsgafRL0nog7yCUghEd/D1A==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "8cad12c3-c190-4dd6-a3e3-b7531ba5c165", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("1b1c58e1-af1c-456a-afe1-d9e642f3a520"), "Информационни технологии", 3 },
                    { new Guid("23a16ed4-2cb0-4341-a2ef-6327c86533f4"), "Английски език", 2 },
                    { new Guid("af22a7b4-3912-4f66-bfd3-675bbb054943"), "Математика", 1 },
                    { new Guid("fca19d12-1567-4e61-9c39-a58c4ae68b66"), "Български език", 2 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("032b879b-0822-450b-80a5-7b0055d7f095"), "Баскетбол", 2 },
                    { new Guid("038f39fb-1be3-4c1f-a8a8-47b52bc8b3b7"), "Волейбол", 2 },
                    { new Guid("1261b6e9-2a1d-43a4-9265-bcb2df1cb874"), "Карате", 1 },
                    { new Guid("9ce32a5c-6f78-4cd1-abf1-b9172b5dd62c"), "Таекуондо", 1 },
                    { new Guid("c2108c1a-4230-49a3-a7f9-6dcb5dc7907e"), "Футбол", 2 },
                    { new Guid("cf1dd7b3-3156-4606-8030-fbb4702e6887"), "Кикбокс", 1 }
                });
        }
    }
}
