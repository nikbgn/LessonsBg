using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class UserLocationExtend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "962756f6-54e6-4d92-ae5e-bb0d66a12796");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("26414e41-21e5-42c3-8ca7-497876bc418a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6048d43a-122f-49e4-a527-61ea69c97bb1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ceaa97b2-d026-4ed0-84b5-631b29b169cf"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d44d0d1c-03fd-4868-afde-6089fd6e89e5"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("1fa112fe-a08c-4175-aa1a-ac1259d8b52c"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("23cc3aca-0e4d-4b7e-8539-e62b7dc00c9b"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("24151007-b2b7-4e34-b73b-f4ff8cd7f805"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("7a05b7af-aed5-427d-8e59-8fc352da6ca5"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("d9e6abc1-00aa-4dcd-9420-06c66294fee7"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("f09140af-85b8-492b-b5c6-1565899b2479"));

            migrationBuilder.AddColumn<string>(
                name: "TeachingLocation",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TeachingLocation", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a7dd4bf4-813f-48f4-ba1e-dccffb6d4e27", 0, "9e0ed8b4-c2bd-46a4-aceb-173a45d3bbe8", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEDEcJohIxdaH51S9l8brwZGfh6mM4Boq2G+Qs3Hu44b/vRGGC4NPOJ5OKI9fKxhmhA==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "d23f8645-0bcc-4561-8bda-1eaa8fc9efc7", "Онлайн", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("2b2d26ac-0b47-41d9-b70f-d1d6a59eb010"), "Информационни технологии", 3 },
                    { new Guid("43ab2b43-76c5-4e66-ab0c-5c340e4c6fc4"), "Английски език", 2 },
                    { new Guid("db67d17e-f125-4cb1-8f96-f73c216f23cc"), "Математика", 1 },
                    { new Guid("f3c074a3-2e39-40fc-b49b-02ca3954ed08"), "Български език", 2 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("1872554f-3a5f-4507-b1c0-e33a7752a5e1"), "Волейбол", 2 },
                    { new Guid("3bb389cd-3576-477c-8135-ccf8f234bc05"), "Карате", 1 },
                    { new Guid("3c36ceba-7516-4376-80c0-95758438cb01"), "Баскетбол", 2 },
                    { new Guid("7677e8d9-c9b3-4ca3-94a0-aea85c6a006a"), "Футбол", 2 },
                    { new Guid("afe7edfa-6465-4191-b28a-466824e4f087"), "Таекуондо", 1 },
                    { new Guid("ee4454fe-75a1-440c-981e-80033f379570"), "Кикбокс", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7dd4bf4-813f-48f4-ba1e-dccffb6d4e27");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2b2d26ac-0b47-41d9-b70f-d1d6a59eb010"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("43ab2b43-76c5-4e66-ab0c-5c340e4c6fc4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("db67d17e-f125-4cb1-8f96-f73c216f23cc"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f3c074a3-2e39-40fc-b49b-02ca3954ed08"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("1872554f-3a5f-4507-b1c0-e33a7752a5e1"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("3bb389cd-3576-477c-8135-ccf8f234bc05"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("3c36ceba-7516-4376-80c0-95758438cb01"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("7677e8d9-c9b3-4ca3-94a0-aea85c6a006a"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("afe7edfa-6465-4191-b28a-466824e4f087"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("ee4454fe-75a1-440c-981e-80033f379570"));

            migrationBuilder.DropColumn(
                name: "TeachingLocation",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "962756f6-54e6-4d92-ae5e-bb0d66a12796", 0, "cb1a1132-90cc-411c-bd65-69cc88fa9754", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEEt0UpcbkEBfFz1joPzzsRxvI0CvcuouOctduBlslldGRy+OEUFNp38RzreQiaTPEA==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "93eebc0f-0950-4895-96d1-d85e7af54017", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("26414e41-21e5-42c3-8ca7-497876bc418a"), "Математика", 1 },
                    { new Guid("6048d43a-122f-49e4-a527-61ea69c97bb1"), "Английски език", 2 },
                    { new Guid("ceaa97b2-d026-4ed0-84b5-631b29b169cf"), "Български език", 2 },
                    { new Guid("d44d0d1c-03fd-4868-afde-6089fd6e89e5"), "Информационни технологии", 3 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("1fa112fe-a08c-4175-aa1a-ac1259d8b52c"), "Футбол", 2 },
                    { new Guid("23cc3aca-0e4d-4b7e-8539-e62b7dc00c9b"), "Баскетбол", 2 },
                    { new Guid("24151007-b2b7-4e34-b73b-f4ff8cd7f805"), "Кикбокс", 1 },
                    { new Guid("7a05b7af-aed5-427d-8e59-8fc352da6ca5"), "Волейбол", 2 },
                    { new Guid("d9e6abc1-00aa-4dcd-9420-06c66294fee7"), "Таекуондо", 1 },
                    { new Guid("f09140af-85b8-492b-b5c6-1565899b2479"), "Карате", 1 }
                });
        }
    }
}
