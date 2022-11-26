using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class DatabaseChangesAndLocationsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseFilterBadge");

            migrationBuilder.DropTable(
                name: "FilterBadges");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05d1c478-9ba2-42db-a320-dfc3e2e9b305");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("032a6096-68a9-4ff8-9799-a52b02204541"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5aa70a84-b7a5-4318-a67f-61470d5b97a7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("88eebfc1-abcf-442b-8786-85e6a9caf14d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f39841b1-ecbb-4af4-80da-f34bdca81324"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("461bbd67-9718-4d69-a261-435fdb5f3b0d"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("57c8e529-03fd-44e5-8d0a-7a49ad910cb5"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("8fa288e2-3254-4aeb-8d01-7cf5adaadede"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("95792df9-85ff-44e1-8f10-69ef684fb7ae"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("c7bd6821-a680-4b9a-813d-eaca5d691b2c"));

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: new Guid("e07ccfba-38fb-4d6f-84ce-413dbfba1ccd"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f5789311-d414-4588-9265-f971161fe791", 0, "ad306fe4-3f3d-4b36-8636-9bf37cffa7e0", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEBg9oWa3eHU+QB0qpzq1+6c87kcOwt7mb8v4esUkfok461B9cUtsp5KE7drl3qnuJQ==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "2c674d0d-fd41-4154-a5d2-9994df6c69c8", false, "niki_admin@niki.bg" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Онлайн", "Онлайн" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Айтос", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Аксаково", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Алфатар", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Антоново", "Търговище" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Априлци", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ардино", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Асеновград", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Ахелой");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ахтопол", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Балчик", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Банкя", "София град" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Банско", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Баня", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Батак", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Батановци", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белене", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белица", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белово", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белоградчик", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белослав", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Берковица", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Благоевград", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Бобов дол");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бобошево", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Божурище", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бойчиновци", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Болярово", "Ямбол" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Борово", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ботевград", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брацигово", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брегово", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брезник", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брезово", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брусарци", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бургас", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бухово", "София град" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Българово", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 39,
                column: "Region",
                value: "Варна");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бяла", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бяла Слатина", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бяла Черква", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Варна", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Велики Преслав", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Велико Търново", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Велинград", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ветово", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ветрен", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Видин", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Враца", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Вълчедръм", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Вълчи дол", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Върбица", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Вършец", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Габрово", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Генерал Тошево", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Главиница", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Глоджево", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Годеч", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Горна Оряховица", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Гоце Делчев", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Грамада", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Гулянци", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Гурково");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Гълъбово", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Две могили", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дебелец", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Девин", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Девня", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Джебел", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Димитровград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Димово", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Добринище", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Добрич", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долна баня", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долна Митрополия", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долна Оряховица", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долни Дъбник", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долни чифлик", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Доспат", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Драгоман", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дряново", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дулово", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дунавци", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дупница", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дългопол", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Елена", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Елин Пелин", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Елхово", "Ямбол" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Етрополе", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Завет", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Земен", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Златарица", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Златица", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Златоград", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ивайловград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Игнатиево", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Искър", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Исперих", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ихтиман", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Каблешково", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Каварна", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Казанлък", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Калофер", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Камено", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Каолиново", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Карлово", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Карнобат", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Каспичан", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кермен", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Килифарево", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Китен", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Клисура", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кнежа", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Козлодуй", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Койнаре", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Копривщица", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Костандово", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "Костенец");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Костинброд", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Котел", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кочериново", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кресна", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Криводол", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кричим", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Крумовград", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Крън", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кубрат", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Куклен", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кула", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кърджали", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кюстендил", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Левски", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 134,
                column: "Name",
                value: "Летница");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ловеч", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Лозница", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Лом", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Луковит", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Лъки", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Любимец", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Лясковец", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мадан", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Маджарово", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Малко Търново", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мартен", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мездра", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мелник", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Меричлери", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мизия", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Момин проход", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Момчилград", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Монтана", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мъглиж", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Неделино", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Несебър", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Николаево", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Никопол", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Нова Загора", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Нови Искър", "София град" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Нови пазар", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Обзор", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 162,
                column: "Name",
                value: "Омуртаг");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Опака", "Търговище" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Оряхово", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Павел баня", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Павликени", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 167,
                column: "Name",
                value: "Пазарджик");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Панагюрище", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Перник", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Перущица", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Петрич", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Пещера", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Пирдоп", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Плачковци", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Плевен", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Плиска", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Пловдив", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Полски Тръмбеш", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Поморие", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Попово", "Търговище" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Пордим", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Правец", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Приморско", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Провадия", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Първомай", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Раднево", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Радомир", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Разград", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Разлог", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ракитово", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Раковски", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Рила", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Роман", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Рудозем", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Русе", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Садово", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Самоков", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сандански", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сапарева баня", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Свети Влас", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Свиленград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Свищов", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Своге", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Севлиево", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сеново", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Септември", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Силистра", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Симеоновград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Симитли", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Славяново", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сливен", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сливница", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сливо поле", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Смолян", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Смядово", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Созопол", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сопот", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Name", "Region" },
                values: new object[] { "София", "София град" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Средец", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стамболийски", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стара Загора", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стражица", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стралджа", "Ямбол" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стрелча", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Суворово", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сунгурларе", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сухиндол", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Съединение", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сърница", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Твърдица", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тервел", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тетевен", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тополовград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Троян", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Трън", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тръстеник", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Трявна", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тутракан", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Търговище", "Търговище" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Угърчин", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Хаджидимово", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 242,
                column: "Name",
                value: "Харманли");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Хасково", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Хисаря", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Цар Калоян", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Царево", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Чепеларе", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Червен бряг", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Черноморец", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Чипровци", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Чирпан", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Шабла", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Шивачево", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Шипка", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Шумен", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ябланица", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Якоруда", "Благоевград" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[] { 258, "Ямбол", "Ямбол" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5789311-d414-4588-9265-f971161fe791");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 258);

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

            migrationBuilder.CreateTable(
                name: "FilterBadges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilterBadgeType = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "FilterBadge type.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterBadges", x => x.Id);
                },
                comment: "Filter badge that helps show, who is a course appropriate for.");

            migrationBuilder.CreateTable(
                name: "CourseFilterBadge",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilterBadgesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFilterBadge", x => new { x.CoursesId, x.FilterBadgesId });
                    table.ForeignKey(
                        name: "FK_CourseFilterBadge_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseFilterBadge_FilterBadges_FilterBadgesId",
                        column: x => x.FilterBadgesId,
                        principalTable: "FilterBadges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "05d1c478-9ba2-42db-a320-dfc3e2e9b305", 0, "92d4a079-8775-4fac-9340-414034d93af3", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEEKnYlfN0JAjO9dk2P7vsg0uKeawL4lbGNSJKhBdvk/mDKaY8xvpe/k9qJ6Wk4Pp2g==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "0200e11c-43a6-43fa-9a48-0b65a4dfc3b4", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "FilterBadges",
                columns: new[] { "Id", "FilterBadgeType" },
                values: new object[,]
                {
                    { 1, "1-4 Grade" },
                    { 2, "5-8 Grade" },
                    { 3, "9-12 Grade" },
                    { 4, "University Students" },
                    { 5, "Elderly" },
                    { 6, "Online" },
                    { 7, "Onsite" }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Айтос", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Аксаково", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Алфатар", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Антоново", "Търговище" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Априлци", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ардино", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Асеновград", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ахелой", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Ахтопол");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Балчик", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Банкя", "София град" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Банско", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Баня", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Батак", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Батановци", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белене", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белица", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белово", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белоградчик", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Белослав", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Берковица", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Благоевград", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бобов дол", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Бобошево");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Божурище", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бойчиновци", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Болярово", "Ямбол" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Борово", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ботевград", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брацигово", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брегово", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брезник", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брезово", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Брусарци", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бургас", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бухово", "София град" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Българово", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бяла", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 39,
                column: "Region",
                value: "Русе");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бяла Слатина", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Бяла Черква", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Варна", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Велики Преслав", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Велико Търново", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Велинград", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ветово", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ветрен", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Видин", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Враца", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Вълчедръм", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Вълчи дол", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Върбица", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Вършец", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Габрово", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Генерал Тошево", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Главиница", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Глоджево", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Годеч", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Горна Оряховица", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Гоце Делчев", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Грамада", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Гулянци", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Гурково", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Гълъбово");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Две могили", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дебелец", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Девин", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Девня", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Джебел", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Димитровград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Димово", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Добринище", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Добрич", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долна баня", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долна Митрополия", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долна Оряховица", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долни Дъбник", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Долни чифлик", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Доспат", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Драгоман", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дряново", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дулово", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дунавци", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дупница", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Дългопол", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Елена", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Елин Пелин", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Елхово", "Ямбол" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Етрополе", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Завет", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Земен", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Златарица", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Златица", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Златоград", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ивайловград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Игнатиево", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Искър", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Исперих", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ихтиман", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Каблешково", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Каварна", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Казанлък", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Калофер", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Камено", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Каолиново", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Карлово", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Карнобат", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Каспичан", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кермен", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Килифарево", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Китен", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Клисура", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кнежа", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Козлодуй", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Койнаре", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Копривщица", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Костандово", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Костенец", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "Костинброд");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Котел", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кочериново", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кресна", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Криводол", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кричим", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Крумовград", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Крън", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кубрат", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Куклен", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кула", "Видин" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кърджали", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Кюстендил", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Левски", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Летница", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 134,
                column: "Name",
                value: "Ловеч");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Лозница", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Лом", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Луковит", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Лъки", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Любимец", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Лясковец", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мадан", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Маджарово", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Малко Търново", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мартен", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мездра", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мелник", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Меричлери", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мизия", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Момин проход", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Момчилград", "Кърджали" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Монтана", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Мъглиж", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Неделино", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Несебър", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Николаево", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Никопол", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Нова Загора", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Нови Искър", "София град" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Нови пазар", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Обзор", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Омуртаг", "Търговище" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 162,
                column: "Name",
                value: "Опака");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Оряхово", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Павел баня", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Павликени", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Пазарджик", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 167,
                column: "Name",
                value: "Панагюрище");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Перник", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Перущица", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Петрич", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Пещера", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Пирдоп", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Плачковци", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Плевен", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Плиска", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Пловдив", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Полски Тръмбеш", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Поморие", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Попово", "Търговище" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Пордим", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Правец", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Приморско", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Провадия", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Първомай", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Раднево", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Радомир", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Разград", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Разлог", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ракитово", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Раковски", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Рила", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Роман", "Враца" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Рудозем", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Русе", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Садово", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Самоков", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сандански", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сапарева баня", "Кюстендил" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Свети Влас", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Свиленград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Свищов", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Своге", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Севлиево", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сеново", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Септември", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Силистра", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Симеоновград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Симитли", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Славяново", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сливен", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сливница", "Софийска" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сливо поле", "Русе" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Смолян", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Смядово", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Созопол", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сопот", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Name", "Region" },
                values: new object[] { "София", "София град" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Средец", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стамболийски", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стара Загора", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стражица", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стралджа", "Ямбол" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Стрелча", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Суворово", "Варна" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сунгурларе", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сухиндол", "Велико Търново" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Съединение", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Сърница", "Пазарджик" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Твърдица", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тервел", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тетевен", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тополовград", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Троян", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Трън", "Перник" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тръстеник", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Трявна", "Габрово" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Тутракан", "Силистра" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Търговище", "Търговище" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Угърчин", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Хаджидимово", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Харманли", "Хасково" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 242,
                column: "Name",
                value: "Хасково");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Хисаря", "Пловдив" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Цар Калоян", "Разград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Царево", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Чепеларе", "Смолян" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Червен бряг", "Плевен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Черноморец", "Бургас" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Чипровци", "Монтана" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Чирпан", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Шабла", "Добрич" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Шивачево", "Сливен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Шипка", "Стара Загора" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Шумен", "Шумен" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ябланица", "Ловеч" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Якоруда", "Благоевград" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Name", "Region" },
                values: new object[] { "Ямбол", "Ямбол" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("032a6096-68a9-4ff8-9799-a52b02204541"), "Български език", 2 },
                    { new Guid("5aa70a84-b7a5-4318-a67f-61470d5b97a7"), "Математика", 1 },
                    { new Guid("88eebfc1-abcf-442b-8786-85e6a9caf14d"), "Информационни технологии", 3 },
                    { new Guid("f39841b1-ecbb-4af4-80da-f34bdca81324"), "Английски език", 2 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Name", "TrainingTypeId" },
                values: new object[,]
                {
                    { new Guid("461bbd67-9718-4d69-a261-435fdb5f3b0d"), "Таекуондо", 1 },
                    { new Guid("57c8e529-03fd-44e5-8d0a-7a49ad910cb5"), "Кикбокс", 1 },
                    { new Guid("8fa288e2-3254-4aeb-8d01-7cf5adaadede"), "Баскетбол", 2 },
                    { new Guid("95792df9-85ff-44e1-8f10-69ef684fb7ae"), "Футбол", 2 },
                    { new Guid("c7bd6821-a680-4b9a-813d-eaca5d691b2c"), "Волейбол", 2 },
                    { new Guid("e07ccfba-38fb-4d6f-84ce-413dbfba1ccd"), "Карате", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseFilterBadge_FilterBadgesId",
                table: "CourseFilterBadge",
                column: "FilterBadgesId");
        }
    }
}
