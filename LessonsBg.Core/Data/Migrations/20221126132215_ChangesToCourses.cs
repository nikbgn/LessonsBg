using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class ChangesToCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Courses",
                type: "int",
                nullable: false,
                comment: "Location of the course.",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2d984ec9-da7a-46cf-9f9f-8fd2eb617520", 0, "f17841d7-c679-4006-aecc-8ee4f040f0c6", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEI+RWUrwsvwlLBwuknfyGIdq2FLaWIy/dZ7ZhHp8oOMfA3ANYnVES1Z4Ro1LFc34WQ==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "bb6f6f1b-2ff1-47a0-9d0c-55308b9ce64f", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("78d6acf2-6620-4a97-8df7-7bd42badcb00"), "Информационни технологии", 3 },
                    { new Guid("af058689-555f-4a84-8f97-b65502872936"), "Български език", 2 },
                    { new Guid("b4724278-9583-4a00-a6d4-4ec6c10f33a9"), "Английски език", 2 },
                    { new Guid("b64e00e8-2e9e-49b0-9a2d-3dcb70ab1792"), "Математика", 1 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("3842a18b-e8dd-4144-b499-fc6d74797f4a"), "Футбол", 2 },
                    { new Guid("527c995a-59ee-4457-8d75-865b223e1040"), "Кикбокс", 1 },
                    { new Guid("9e566812-55a2-4169-8385-b1cc4ec215e7"), "Баскетбол", 2 },
                    { new Guid("d64af173-07e1-45d2-b7b3-f35cddd6bf66"), "Волейбол", 2 },
                    { new Guid("ec5f561b-4543-44b0-8e85-174eed7b7de6"), "Таекуондо", 1 },
                    { new Guid("f7a2aec3-a0e5-4b23-aeea-433873599ae8"), "Карате", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d984ec9-da7a-46cf-9f9f-8fd2eb617520");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("78d6acf2-6620-4a97-8df7-7bd42badcb00"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("af058689-555f-4a84-8f97-b65502872936"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b4724278-9583-4a00-a6d4-4ec6c10f33a9"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b64e00e8-2e9e-49b0-9a2d-3dcb70ab1792"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("3842a18b-e8dd-4144-b499-fc6d74797f4a"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("527c995a-59ee-4457-8d75-865b223e1040"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("9e566812-55a2-4169-8385-b1cc4ec215e7"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("d64af173-07e1-45d2-b7b3-f35cddd6bf66"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("ec5f561b-4543-44b0-8e85-174eed7b7de6"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("f7a2aec3-a0e5-4b23-aeea-433873599ae8"));

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Location of the course.");

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
    }
}
