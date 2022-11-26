using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class isVisualStudiobugged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "40c82e1c-6c90-4999-9620-a0072faa0023", 0, "eee1553c-bd0e-40d6-9711-4ba67c512436", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEFqeEb9Ug+WvKRgQ5vi/iaHZU2tIeYsruvKgjkTaQTuf+UTlVVKvn2RmSYF1yEPyag==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "2b771460-628b-4627-a32f-04d78c36aaf1", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("501e42c2-e4fa-4adf-8615-6609a49dbcf4"), "Английски език", 2 },
                    { new Guid("746fae56-273c-4322-97e5-32b661bd2cd0"), "Математика", 1 },
                    { new Guid("b752df56-d10b-4ffc-8ed8-23763936d180"), "Информационни технологии", 3 },
                    { new Guid("c382379f-b4f4-46fc-8825-49a74e43fa48"), "Български език", 2 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("0972e96b-b7a8-4d11-a134-b8ddbb510763"), "Волейбол", 2 },
                    { new Guid("7ae1e609-aa07-4498-88db-c385a55b98f6"), "Футбол", 2 },
                    { new Guid("98e46797-f84c-4510-bce7-3864118ed2bc"), "Баскетбол", 2 },
                    { new Guid("ad44e377-558e-46a0-8555-d58ce120f45e"), "Таекуондо", 1 },
                    { new Guid("df5bc930-1a98-419a-9774-8adbb80de30b"), "Кикбокс", 1 },
                    { new Guid("e23f07b6-9704-4ec1-8eaa-cc135d2b327e"), "Карате", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40c82e1c-6c90-4999-9620-a0072faa0023");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("501e42c2-e4fa-4adf-8615-6609a49dbcf4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("746fae56-273c-4322-97e5-32b661bd2cd0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b752df56-d10b-4ffc-8ed8-23763936d180"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c382379f-b4f4-46fc-8825-49a74e43fa48"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("0972e96b-b7a8-4d11-a134-b8ddbb510763"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("7ae1e609-aa07-4498-88db-c385a55b98f6"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("98e46797-f84c-4510-bce7-3864118ed2bc"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("ad44e377-558e-46a0-8555-d58ce120f45e"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("df5bc930-1a98-419a-9774-8adbb80de30b"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("e23f07b6-9704-4ec1-8eaa-cc135d2b327e"));

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
    }
}
