using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class ExtendConfigurationSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TeachingLocation", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0272e1f5-ab34-49e4-8274-d471f34c0d74", 0, "a5bf24f2-1369-47ab-a125-b9b51b625d56", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEMQeGku9/GM6SDVVrgEshdGVldpYcfv3YQ3EUHfnurZD+kMooZTxKrgrrXwcb2A/SQ==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "907a2469-aba3-4b2c-b1b1-7d1e54c9da02", "Онлайн", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("029ee38b-c917-4677-8ba7-401282071cec"), "География и икономика", 1 },
                    { new Guid("06b19021-cedb-4a7c-bd1c-ca1dae0dfde5"), "Физика и астрономия", 1 },
                    { new Guid("47a0960a-3099-4935-9cb8-6d7e940e724a"), "Философия", 1 },
                    { new Guid("4fd6caf6-83ce-476d-8643-e45ab4449ae3"), "Английски език", 2 },
                    { new Guid("5bb5362b-8608-4ab9-bcf0-2307de196f8c"), "Немски език", 2 },
                    { new Guid("5d5329c1-c7af-47df-bb32-e9e968cb8b53"), "Руски език", 2 },
                    { new Guid("63414597-cd97-427d-86e4-b059aac9579e"), "Математика", 1 },
                    { new Guid("71bca929-df28-49b6-89d1-4c120e6a73e1"), "История и цивилизация", 1 },
                    { new Guid("7a95e79e-5ade-44f6-af66-2ace7ce796cd"), "Информационни технологии", 3 },
                    { new Guid("91dec909-fd88-4a91-bb75-104ca54c1df8"), "Български език", 2 },
                    { new Guid("a8a0aecf-cdcb-42fd-9f40-a6b0545f7f89"), "Френски език", 2 },
                    { new Guid("c2a8d62e-a669-49e1-b27c-e07c31383c13"), "Химия и опазване на околната среда", 1 },
                    { new Guid("ff00ea91-ab12-421a-b021-ea658de34441"), "Испански език", 2 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("17ef0e5d-7f90-468c-bbe0-1a0e467ff145"), "Футбол", 2 },
                    { new Guid("27716f2e-cc20-422d-b19c-46b50cd1002a"), "Кикбокс", 1 },
                    { new Guid("67c72190-f058-4155-93cf-0fbc1f99688a"), "Баскетбол", 2 },
                    { new Guid("d07d0cb2-6326-4c9e-a091-6a1e91050c54"), "Волейбол", 2 },
                    { new Guid("e60a0005-e615-4587-b110-0aa2b8a209c6"), "Таекуондо", 1 },
                    { new Guid("f1681893-c07d-4b0f-a368-783c4c8b5146"), "Карате", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0272e1f5-ab34-49e4-8274-d471f34c0d74");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("029ee38b-c917-4677-8ba7-401282071cec"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("06b19021-cedb-4a7c-bd1c-ca1dae0dfde5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("47a0960a-3099-4935-9cb8-6d7e940e724a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4fd6caf6-83ce-476d-8643-e45ab4449ae3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5bb5362b-8608-4ab9-bcf0-2307de196f8c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5d5329c1-c7af-47df-bb32-e9e968cb8b53"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("63414597-cd97-427d-86e4-b059aac9579e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("71bca929-df28-49b6-89d1-4c120e6a73e1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7a95e79e-5ade-44f6-af66-2ace7ce796cd"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("91dec909-fd88-4a91-bb75-104ca54c1df8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a8a0aecf-cdcb-42fd-9f40-a6b0545f7f89"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c2a8d62e-a669-49e1-b27c-e07c31383c13"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ff00ea91-ab12-421a-b021-ea658de34441"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("17ef0e5d-7f90-468c-bbe0-1a0e467ff145"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("27716f2e-cc20-422d-b19c-46b50cd1002a"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("67c72190-f058-4155-93cf-0fbc1f99688a"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("d07d0cb2-6326-4c9e-a091-6a1e91050c54"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("e60a0005-e615-4587-b110-0aa2b8a209c6"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("f1681893-c07d-4b0f-a368-783c4c8b5146"));

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
    }
}
