using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class testtest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "10ab2d58-7453-431f-8d72-9a82d2ccf00d", 0, "abb33afc-f0db-4626-9329-204f9ab90fcd", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEJHeIO4hyDrcKKIvZ9ilBB0TPwggfDfvVlbfEwSY+dWiLWz0B7hAbdK7mQkdEWhraA==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "ddddda1c-6530-4ca0-9d27-aab6c3a3c5a3", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("1031ea94-f254-4c48-aef6-272760a036f0"), "Английски език", 2 },
                    { new Guid("1e81f44e-4b48-4461-ba75-34018a8289e9"), "Български език", 2 },
                    { new Guid("9fb4f92e-a8ae-4ee5-bdfe-42bd3fd9172a"), "Информационни технологии", 3 },
                    { new Guid("c3bc7572-3ecb-46a1-89d4-e1e8c529e61e"), "Математика", 1 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("62672b80-6058-49af-b2ce-1a35402cdfa2"), "Карате", 1 },
                    { new Guid("69445fb7-db85-4b72-9f07-fb0369998a6d"), "Волейбол", 2 },
                    { new Guid("6f3bd53b-653e-407d-80f1-8fc37f855ebb"), "Футбол", 2 },
                    { new Guid("73fcd6ea-0b27-40a1-9c85-38386ad1c52a"), "Баскетбол", 2 },
                    { new Guid("9090685e-44cc-4650-b8e1-42733a90341a"), "Таекуондо", 1 },
                    { new Guid("ae1605ce-3860-4845-b368-07c05314b264"), "Кикбокс", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10ab2d58-7453-431f-8d72-9a82d2ccf00d");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1031ea94-f254-4c48-aef6-272760a036f0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1e81f44e-4b48-4461-ba75-34018a8289e9"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9fb4f92e-a8ae-4ee5-bdfe-42bd3fd9172a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c3bc7572-3ecb-46a1-89d4-e1e8c529e61e"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("62672b80-6058-49af-b2ce-1a35402cdfa2"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("69445fb7-db85-4b72-9f07-fb0369998a6d"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("6f3bd53b-653e-407d-80f1-8fc37f855ebb"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("73fcd6ea-0b27-40a1-9c85-38386ad1c52a"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("9090685e-44cc-4650-b8e1-42733a90341a"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("ae1605ce-3860-4845-b368-07c05314b264"));

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
    }
}
