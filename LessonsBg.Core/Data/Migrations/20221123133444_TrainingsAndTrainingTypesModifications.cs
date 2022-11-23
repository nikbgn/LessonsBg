using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class TrainingsAndTrainingTypesModifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2117ce8d-f1ba-4fce-bbd6-0847a0af3238", 0, "3aab70fb-4f85-4df5-b2bc-613a419fdf2d", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEBxcAsg8GYXke3eiIYZJrGp1sA+p9+onZIZ6Y1+pd4eMtLBjC0+0iJAcNSR2hFqBUA==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "d49da9aa-8001-40ce-8416-32c6b8612506", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("8091984d-1801-49fe-9d3f-d4c1fc4efdd0"), "Информационни технологии", 3 },
                    { new Guid("8e7ef62e-3fdf-4fb9-9596-c687bf9b6a41"), "Английски език", 2 },
                    { new Guid("9f1462fb-c31c-495a-94a1-0b556d6b0d57"), "Математика", 1 },
                    { new Guid("ffffb480-a18a-4f8c-8336-34463667f284"), "Български език", 2 }
                });

            migrationBuilder.UpdateData(
                table: "TrainingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Combat sport");

            migrationBuilder.UpdateData(
                table: "TrainingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Ball sport");

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("041294d0-fa69-45bc-ad57-759733ccce45"), "Футбол", 2 },
                    { new Guid("196ff6c4-98ae-4c63-9dc6-9b495a722828"), "Баскетбол", 2 },
                    { new Guid("1f07d801-f7a9-462a-806d-825efb2047b5"), "Карате", 1 },
                    { new Guid("84c899ae-e5b0-47e1-bb53-002deee05baf"), "Волейбол", 2 },
                    { new Guid("8737a875-7f87-470a-8b87-f235c1aed97b"), "Кикбокс", 1 },
                    { new Guid("f9ebf29c-75a9-4701-a571-7abc3bf6eabc"), "Таекуондо", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2117ce8d-f1ba-4fce-bbd6-0847a0af3238");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8091984d-1801-49fe-9d3f-d4c1fc4efdd0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8e7ef62e-3fdf-4fb9-9596-c687bf9b6a41"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9f1462fb-c31c-495a-94a1-0b556d6b0d57"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ffffb480-a18a-4f8c-8336-34463667f284"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("041294d0-fa69-45bc-ad57-759733ccce45"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("196ff6c4-98ae-4c63-9dc6-9b495a722828"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("1f07d801-f7a9-462a-806d-825efb2047b5"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("84c899ae-e5b0-47e1-bb53-002deee05baf"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("8737a875-7f87-470a-8b87-f235c1aed97b"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("f9ebf29c-75a9-4701-a571-7abc3bf6eabc"));

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

            migrationBuilder.UpdateData(
                table: "TrainingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Air sport");

            migrationBuilder.UpdateData(
                table: "TrainingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Combat sport");
        }
    }
}
