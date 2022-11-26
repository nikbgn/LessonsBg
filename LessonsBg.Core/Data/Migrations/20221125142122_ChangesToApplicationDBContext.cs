using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class ChangesToApplicationDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5789311-d414-4588-9265-f971161fe791");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("02c08965-cb75-48ba-a638-0d82c06f999e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6aefc508-fdf4-4590-b875-9ef6d9a90b9f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6c9c97e4-b787-481b-bff7-12474a80a0fe"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f1b5c833-6933-4781-ade7-0432644d5b0e"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("0dae0b34-fbf3-4c3d-b34e-c551cccb323f"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("4a8f135d-6868-4575-934e-949fb6f69b94"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("6c4d3d38-fee9-47fd-b7de-fa84ded67476"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("70a41ffe-d7e6-40b5-b3a3-9b480af0ac01"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("9e04e4ba-ae76-4583-a727-3c0696659428"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("e58fa951-0e24-48b4-85ed-89c1cacd78b5"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "f5789311-d414-4588-9265-f971161fe791", 0, "ad306fe4-3f3d-4b36-8636-9bf37cffa7e0", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEBg9oWa3eHU+QB0qpzq1+6c87kcOwt7mb8v4esUkfok461B9cUtsp5KE7drl3qnuJQ==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "2c674d0d-fd41-4154-a5d2-9994df6c69c8", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("02c08965-cb75-48ba-a638-0d82c06f999e"), "Математика", 1 },
                    { new Guid("6aefc508-fdf4-4590-b875-9ef6d9a90b9f"), "Български език", 2 },
                    { new Guid("6c9c97e4-b787-481b-bff7-12474a80a0fe"), "Информационни технологии", 3 },
                    { new Guid("f1b5c833-6933-4781-ade7-0432644d5b0e"), "Английски език", 2 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("0dae0b34-fbf3-4c3d-b34e-c551cccb323f"), "Футбол", 2 },
                    { new Guid("4a8f135d-6868-4575-934e-949fb6f69b94"), "Баскетбол", 2 },
                    { new Guid("6c4d3d38-fee9-47fd-b7de-fa84ded67476"), "Карате", 1 },
                    { new Guid("70a41ffe-d7e6-40b5-b3a3-9b480af0ac01"), "Волейбол", 2 },
                    { new Guid("9e04e4ba-ae76-4583-a727-3c0696659428"), "Кикбокс", 1 },
                    { new Guid("e58fa951-0e24-48b4-85ed-89c1cacd78b5"), "Таекуондо", 1 }
                });
        }
    }
}
