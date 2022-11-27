using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class UpdateToMaxSizeNewsArticleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e949ba76-646b-4266-9d89-165166579bd2");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("14d4a49e-bc6f-4a9b-8df2-10bd8b50b04b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("206263ab-e39d-4de4-89ab-974dc3518f35"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d10af3a2-33f7-42b2-b601-66d5a0cc28c4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d523ab5b-d745-432c-97e5-dec0bcf30972"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("2682e37d-56fe-4313-b692-7c8aa2be40fc"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("630a0ba6-a0ed-4aef-933d-c6c55a76ce35"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("6939ac23-4302-4b6a-a567-fc4345d482b6"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("69f9fd63-842a-4073-8d1c-87e5f9b3591f"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("74c31780-b30f-463e-ad9d-7a13b9155ad2"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("9ca86094-f8a9-43b6-ac86-103a707ffbeb"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NewsArticles",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                comment: "News article name.",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldComment: "News article name.");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NewsArticles",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                comment: "News article name.",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldComment: "News article name.");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e949ba76-646b-4266-9d89-165166579bd2", 0, "e3c4b3ee-c165-46c5-9a99-637ba75eb5c3", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAENMzwBlQjv1AX5qXbj/DP/xc6zPd25HsNXDIBtAt2x+Dg9PisOJsFHYsNss9yRpoGQ==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "a9521cbf-0809-45fe-808e-b58f63ffd288", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("14d4a49e-bc6f-4a9b-8df2-10bd8b50b04b"), "Информационни технологии", 3 },
                    { new Guid("206263ab-e39d-4de4-89ab-974dc3518f35"), "Български език", 2 },
                    { new Guid("d10af3a2-33f7-42b2-b601-66d5a0cc28c4"), "Математика", 1 },
                    { new Guid("d523ab5b-d745-432c-97e5-dec0bcf30972"), "Английски език", 2 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("2682e37d-56fe-4313-b692-7c8aa2be40fc"), "Баскетбол", 2 },
                    { new Guid("630a0ba6-a0ed-4aef-933d-c6c55a76ce35"), "Кикбокс", 1 },
                    { new Guid("6939ac23-4302-4b6a-a567-fc4345d482b6"), "Таекуондо", 1 },
                    { new Guid("69f9fd63-842a-4073-8d1c-87e5f9b3591f"), "Волейбол", 2 },
                    { new Guid("74c31780-b30f-463e-ad9d-7a13b9155ad2"), "Карате", 1 },
                    { new Guid("9ca86094-f8a9-43b6-ac86-103a707ffbeb"), "Футбол", 2 }
                });
        }
    }
}
