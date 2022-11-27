using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class ChangesInDatabaseToBulgarian : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e949ba76-646b-4266-9d89-165166579bd2", 0, "e3c4b3ee-c165-46c5-9a99-637ba75eb5c3", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAENMzwBlQjv1AX5qXbj/DP/xc6zPd25HsNXDIBtAt2x+Dg9PisOJsFHYsNss9yRpoGQ==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "a9521cbf-0809-45fe-808e-b58f63ffd288", false, "niki_admin@niki.bg" });

            migrationBuilder.UpdateData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Пиано");

            migrationBuilder.UpdateData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Пеене");

            migrationBuilder.UpdateData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "Танци");

            migrationBuilder.InsertData(
                table: "CourseTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 5, "Компютърна грамотност" },
                    { 6, "Microsoft Word" },
                    { 7, "Microsoft Powerpoint" },
                    { 8, "Adobe Photoshop" },
                    { 9, "Adobe Illustrator" }
                });

            migrationBuilder.UpdateData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Академични");

            migrationBuilder.UpdateData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Езици");

            migrationBuilder.UpdateData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "ИТ");

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

            migrationBuilder.UpdateData(
                table: "TrainingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Бойни спортове");

            migrationBuilder.UpdateData(
                table: "TrainingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Спортове с топка");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e949ba76-646b-4266-9d89-165166579bd2");

            migrationBuilder.DeleteData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 9);

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2d984ec9-da7a-46cf-9f9f-8fd2eb617520", 0, "f17841d7-c679-4006-aecc-8ee4f040f0c6", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEI+RWUrwsvwlLBwuknfyGIdq2FLaWIy/dZ7ZhHp8oOMfA3ANYnVES1Z4Ro1LFc34WQ==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "bb6f6f1b-2ff1-47a0-9d0c-55308b9ce64f", false, "niki_admin@niki.bg" });

            migrationBuilder.UpdateData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Piano");

            migrationBuilder.UpdateData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Singing");

            migrationBuilder.UpdateData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "Dancing");

            migrationBuilder.UpdateData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Academic");

            migrationBuilder.UpdateData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Language");

            migrationBuilder.UpdateData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "IT");

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
                    { new Guid("3842a18b-e8dd-4144-b499-fc6d74797f4a"), "Футбол", 2 },
                    { new Guid("527c995a-59ee-4457-8d75-865b223e1040"), "Кикбокс", 1 },
                    { new Guid("9e566812-55a2-4169-8385-b1cc4ec215e7"), "Баскетбол", 2 },
                    { new Guid("d64af173-07e1-45d2-b7b3-f35cddd6bf66"), "Волейбол", 2 },
                    { new Guid("ec5f561b-4543-44b0-8e85-174eed7b7de6"), "Таекуондо", 1 },
                    { new Guid("f7a2aec3-a0e5-4b23-aeea-433873599ae8"), "Карате", 1 }
                });
        }
    }
}
