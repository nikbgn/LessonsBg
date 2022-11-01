using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class InitialDatabaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key."),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "The title of the post."),
                    PostThumbnailURL = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The thumbnail image of the post."),
                    PostTextHeadingImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The leading image of the post."),
                    PostText = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The post text."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of creation of the post.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                },
                comment: "Blog posts.");

            migrationBuilder.CreateTable(
                name: "CourseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Course type.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTypes", x => x.Id);
                },
                comment: "Course type");

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
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "City name."),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "City region.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                },
                comment: "Locations (cities in Bulgaria and their regions).");

            migrationBuilder.CreateTable(
                name: "SubjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Subject type.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTypes", x => x.Id);
                },
                comment: "Subject type");

            migrationBuilder.CreateTable(
                name: "TrainingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Training type.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingTypes", x => x.Id);
                },
                comment: "Training type");

            migrationBuilder.CreateTable(
                name: "BlogComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Blog comment text."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of creation of the blog commment."),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Author ID"),
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "BlogPost ID")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogComments_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Comments under a blog post.");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key"),
                    CourseName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Name of the course."),
                    CourseImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Course image."),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Author ID."),
                    CourseTypeId = table.Column<int>(type: "int", nullable: false, comment: "Type of the course."),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Phone number to call if you are interested in the course."),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Website link with additional information about the course."),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Description of the course.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_CourseTypes_CourseTypeId",
                        column: x => x.CourseTypeId,
                        principalTable: "CourseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Courses");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key."),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Name of the subject."),
                    SubjectTypeId = table.Column<int>(type: "int", nullable: false, comment: "Type of the subject."),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subjects_SubjectTypes_SubjectTypeId",
                        column: x => x.SubjectTypeId,
                        principalTable: "SubjectTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Subjects");

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key."),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Name of the training."),
                    TrainingTypeId = table.Column<int>(type: "int", nullable: false, comment: "Type of the training."),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trainings_TrainingTypes_TrainingTypeId",
                        column: x => x.TrainingTypeId,
                        principalTable: "TrainingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Trainings");

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
                table: "CourseTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Piano" },
                    { 2, "Singing" },
                    { 3, "Dancing" },
                    { 4, "Microsoft Excel" }
                });

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

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { 1, "Айтос", "Бургас" },
                    { 2, "Аксаково", "Варна" },
                    { 3, "Алфатар", "Силистра" },
                    { 4, "Антоново", "Търговище" },
                    { 5, "Априлци", "Ловеч" },
                    { 6, "Ардино", "Кърджали" },
                    { 7, "Асеновград", "Пловдив" },
                    { 8, "Ахелой", "Бургас" },
                    { 9, "Ахтопол", "Бургас" },
                    { 10, "Балчик", "Добрич" },
                    { 11, "Банкя", "София град" },
                    { 12, "Банско", "Благоевград" },
                    { 13, "Баня", "Пловдив" },
                    { 14, "Батак", "Пазарджик" },
                    { 15, "Батановци", "Перник" },
                    { 16, "Белене", "Плевен" },
                    { 17, "Белица", "Благоевград" },
                    { 18, "Белово", "Пазарджик" },
                    { 19, "Белоградчик", "Видин" },
                    { 20, "Белослав", "Варна" },
                    { 21, "Берковица", "Монтана" },
                    { 22, "Благоевград", "Благоевград" },
                    { 23, "Бобов дол", "Кюстендил" },
                    { 24, "Бобошево", "Кюстендил" },
                    { 25, "Божурище", "Софийска" },
                    { 26, "Бойчиновци", "Монтана" },
                    { 27, "Болярово", "Ямбол" },
                    { 28, "Борово", "Русе" },
                    { 29, "Ботевград", "Софийска" },
                    { 30, "Брацигово", "Пазарджик" },
                    { 31, "Брегово", "Видин" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { 32, "Брезник", "Перник" },
                    { 33, "Брезово", "Пловдив" },
                    { 34, "Брусарци", "Монтана" },
                    { 35, "Бургас", "Бургас" },
                    { 36, "Бухово", "София град" },
                    { 37, "Българово", "Бургас" },
                    { 38, "Бяла", "Варна" },
                    { 39, "Бяла", "Русе" },
                    { 40, "Бяла Слатина", "Враца" },
                    { 41, "Бяла Черква", "Велико Търново" },
                    { 42, "Варна", "Варна" },
                    { 43, "Велики Преслав", "Шумен" },
                    { 44, "Велико Търново", "Велико Търново" },
                    { 45, "Велинград", "Пазарджик" },
                    { 46, "Ветово", "Русе" },
                    { 47, "Ветрен", "Пазарджик" },
                    { 48, "Видин", "Видин" },
                    { 49, "Враца", "Враца" },
                    { 50, "Вълчедръм", "Монтана" },
                    { 51, "Вълчи дол", "Варна" },
                    { 52, "Върбица", "Шумен" },
                    { 53, "Вършец", "Монтана" },
                    { 54, "Габрово", "Габрово" },
                    { 55, "Генерал Тошево", "Добрич" },
                    { 56, "Главиница", "Силистра" },
                    { 57, "Глоджево", "Русе" },
                    { 58, "Годеч", "Софийска" },
                    { 59, "Горна Оряховица", "Велико Търново" },
                    { 60, "Гоце Делчев", "Благоевград" },
                    { 61, "Грамада", "Видин" },
                    { 62, "Гулянци", "Плевен" },
                    { 63, "Гурково", "Стара Загора" },
                    { 64, "Гълъбово", "Стара Загора" },
                    { 65, "Две могили", "Русе" },
                    { 66, "Дебелец", "Велико Търново" },
                    { 67, "Девин", "Смолян" },
                    { 68, "Девня", "Варна" },
                    { 69, "Джебел", "Кърджали" },
                    { 70, "Димитровград", "Хасково" },
                    { 71, "Димово", "Видин" },
                    { 72, "Добринище", "Благоевград" },
                    { 73, "Добрич", "Добрич" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { 74, "Долна баня", "Софийска" },
                    { 75, "Долна Митрополия", "Плевен" },
                    { 76, "Долна Оряховица", "Велико Търново" },
                    { 77, "Долни Дъбник", "Плевен" },
                    { 78, "Долни чифлик", "Варна" },
                    { 79, "Доспат", "Смолян" },
                    { 80, "Драгоман", "Софийска" },
                    { 81, "Дряново", "Габрово" },
                    { 82, "Дулово", "Силистра" },
                    { 83, "Дунавци", "Видин" },
                    { 84, "Дупница", "Кюстендил" },
                    { 85, "Дългопол", "Варна" },
                    { 86, "Елена", "Велико Търново" },
                    { 87, "Елин Пелин", "Софийска" },
                    { 88, "Елхово", "Ямбол" },
                    { 89, "Етрополе", "Софийска" },
                    { 90, "Завет", "Разград" },
                    { 91, "Земен", "Перник" },
                    { 92, "Златарица", "Велико Търново" },
                    { 93, "Златица", "Софийска" },
                    { 94, "Златоград", "Смолян" },
                    { 95, "Ивайловград", "Хасково" },
                    { 96, "Игнатиево", "Варна" },
                    { 97, "Искър", "Плевен" },
                    { 98, "Исперих", "Разград" },
                    { 99, "Ихтиман", "Софийска" },
                    { 100, "Каблешково", "Бургас" },
                    { 101, "Каварна", "Добрич" },
                    { 102, "Казанлък", "Стара Загора" },
                    { 103, "Калофер", "Пловдив" },
                    { 104, "Камено", "Бургас" },
                    { 105, "Каолиново", "Шумен" },
                    { 106, "Карлово", "Пловдив" },
                    { 107, "Карнобат", "Бургас" },
                    { 108, "Каспичан", "Шумен" },
                    { 109, "Кермен", "Сливен" },
                    { 110, "Килифарево", "Велико Търново" },
                    { 111, "Китен", "Бургас" },
                    { 112, "Клисура", "Пловдив" },
                    { 113, "Кнежа", "Плевен" },
                    { 114, "Козлодуй", "Враца" },
                    { 115, "Койнаре", "Плевен" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { 116, "Копривщица", "Софийска" },
                    { 117, "Костандово", "Пазарджик" },
                    { 118, "Костенец", "Софийска" },
                    { 119, "Костинброд", "Софийска" },
                    { 120, "Котел", "Сливен" },
                    { 121, "Кочериново", "Кюстендил" },
                    { 122, "Кресна", "Благоевград" },
                    { 123, "Криводол", "Враца" },
                    { 124, "Кричим", "Пловдив" },
                    { 125, "Крумовград", "Кърджали" },
                    { 126, "Крън", "Стара Загора" },
                    { 127, "Кубрат", "Разград" },
                    { 128, "Куклен", "Пловдив" },
                    { 129, "Кула", "Видин" },
                    { 130, "Кърджали", "Кърджали" },
                    { 131, "Кюстендил", "Кюстендил" },
                    { 132, "Левски", "Плевен" },
                    { 133, "Летница", "Ловеч" },
                    { 134, "Ловеч", "Ловеч" },
                    { 135, "Лозница", "Разград" },
                    { 136, "Лом", "Монтана" },
                    { 137, "Луковит", "Ловеч" },
                    { 138, "Лъки", "Пловдив" },
                    { 139, "Любимец", "Хасково" },
                    { 140, "Лясковец", "Велико Търново" },
                    { 141, "Мадан", "Смолян" },
                    { 142, "Маджарово", "Хасково" },
                    { 143, "Малко Търново", "Бургас" },
                    { 144, "Мартен", "Русе" },
                    { 145, "Мездра", "Враца" },
                    { 146, "Мелник", "Благоевград" },
                    { 147, "Меричлери", "Хасково" },
                    { 148, "Мизия", "Враца" },
                    { 149, "Момин проход", "Софийска" },
                    { 150, "Момчилград", "Кърджали" },
                    { 151, "Монтана", "Монтана" },
                    { 152, "Мъглиж", "Стара Загора" },
                    { 153, "Неделино", "Смолян" },
                    { 154, "Несебър", "Бургас" },
                    { 155, "Николаево", "Стара Загора" },
                    { 156, "Никопол", "Плевен" },
                    { 157, "Нова Загора", "Сливен" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { 158, "Нови Искър", "София град" },
                    { 159, "Нови пазар", "Шумен" },
                    { 160, "Обзор", "Бургас" },
                    { 161, "Омуртаг", "Търговище" },
                    { 162, "Опака", "Търговище" },
                    { 163, "Оряхово", "Враца" },
                    { 164, "Павел баня", "Стара Загора" },
                    { 165, "Павликени", "Велико Търново" },
                    { 166, "Пазарджик", "Пазарджик" },
                    { 167, "Панагюрище", "Пазарджик" },
                    { 168, "Перник", "Перник" },
                    { 169, "Перущица", "Пловдив" },
                    { 170, "Петрич", "Благоевград" },
                    { 171, "Пещера", "Пазарджик" },
                    { 172, "Пирдоп", "Софийска" },
                    { 173, "Плачковци", "Габрово" },
                    { 174, "Плевен", "Плевен" },
                    { 175, "Плиска", "Шумен" },
                    { 176, "Пловдив", "Пловдив" },
                    { 177, "Полски Тръмбеш", "Велико Търново" },
                    { 178, "Поморие", "Бургас" },
                    { 179, "Попово", "Търговище" },
                    { 180, "Пордим", "Плевен" },
                    { 181, "Правец", "Софийска" },
                    { 182, "Приморско", "Бургас" },
                    { 183, "Провадия", "Варна" },
                    { 184, "Първомай", "Пловдив" },
                    { 185, "Раднево", "Стара Загора" },
                    { 186, "Радомир", "Перник" },
                    { 187, "Разград", "Разград" },
                    { 188, "Разлог", "Благоевград" },
                    { 189, "Ракитово", "Пазарджик" },
                    { 190, "Раковски", "Пловдив" },
                    { 191, "Рила", "Кюстендил" },
                    { 192, "Роман", "Враца" },
                    { 193, "Рудозем", "Смолян" },
                    { 194, "Русе", "Русе" },
                    { 195, "Садово", "Пловдив" },
                    { 196, "Самоков", "Софийска" },
                    { 197, "Сандански", "Благоевград" },
                    { 198, "Сапарева баня", "Кюстендил" },
                    { 199, "Свети Влас", "Бургас" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { 200, "Свиленград", "Хасково" },
                    { 201, "Свищов", "Велико Търново" },
                    { 202, "Своге", "Софийска" },
                    { 203, "Севлиево", "Габрово" },
                    { 204, "Сеново", "Русе" },
                    { 205, "Септември", "Пазарджик" },
                    { 206, "Силистра", "Силистра" },
                    { 207, "Симеоновград", "Хасково" },
                    { 208, "Симитли", "Благоевград" },
                    { 209, "Славяново", "Плевен" },
                    { 210, "Сливен", "Сливен" },
                    { 211, "Сливница", "Софийска" },
                    { 212, "Сливо поле", "Русе" },
                    { 213, "Смолян", "Смолян" },
                    { 214, "Смядово", "Шумен" },
                    { 215, "Созопол", "Бургас" },
                    { 216, "Сопот", "Пловдив" },
                    { 217, "София", "София град" },
                    { 218, "Средец", "Бургас" },
                    { 219, "Стамболийски", "Пловдив" },
                    { 220, "Стара Загора", "Стара Загора" },
                    { 221, "Стражица", "Велико Търново" },
                    { 222, "Стралджа", "Ямбол" },
                    { 223, "Стрелча", "Пазарджик" },
                    { 224, "Суворово", "Варна" },
                    { 225, "Сунгурларе", "Бургас" },
                    { 226, "Сухиндол", "Велико Търново" },
                    { 227, "Съединение", "Пловдив" },
                    { 228, "Сърница", "Пазарджик" },
                    { 229, "Твърдица", "Сливен" },
                    { 230, "Тервел", "Добрич" },
                    { 231, "Тетевен", "Ловеч" },
                    { 232, "Тополовград", "Хасково" },
                    { 233, "Троян", "Ловеч" },
                    { 234, "Трън", "Перник" },
                    { 235, "Тръстеник", "Плевен" },
                    { 236, "Трявна", "Габрово" },
                    { 237, "Тутракан", "Силистра" },
                    { 238, "Търговище", "Търговище" },
                    { 239, "Угърчин", "Ловеч" },
                    { 240, "Хаджидимово", "Благоевград" },
                    { 241, "Харманли", "Хасково" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { 242, "Хасково", "Хасково" },
                    { 243, "Хисаря", "Пловдив" },
                    { 244, "Цар Калоян", "Разград" },
                    { 245, "Царево", "Бургас" },
                    { 246, "Чепеларе", "Смолян" },
                    { 247, "Червен бряг", "Плевен" },
                    { 248, "Черноморец", "Бургас" },
                    { 249, "Чипровци", "Монтана" },
                    { 250, "Чирпан", "Стара Загора" },
                    { 251, "Шабла", "Добрич" },
                    { 252, "Шивачево", "Сливен" },
                    { 253, "Шипка", "Стара Загора" },
                    { 254, "Шумен", "Шумен" },
                    { 255, "Ябланица", "Ловеч" },
                    { 256, "Якоруда", "Благоевград" },
                    { 257, "Ямбол", "Ямбол" }
                });

            migrationBuilder.InsertData(
                table: "SubjectTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Academic" },
                    { 2, "Language" },
                    { 3, "IT" }
                });

            migrationBuilder.InsertData(
                table: "TrainingTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Air sport" },
                    { 2, "Combat sport" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_AuthorId",
                table: "BlogComments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogPostId",
                table: "BlogComments",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFilterBadge_FilterBadgesId",
                table: "CourseFilterBadge",
                column: "FilterBadgesId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AuthorId",
                table: "Courses",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseTypeId",
                table: "Courses",
                column: "CourseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LocationId",
                table: "Courses",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ApplicationUserId",
                table: "Subjects",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SubjectTypeId",
                table: "Subjects",
                column: "SubjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_ApplicationUserId",
                table: "Trainings",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_TrainingTypeId",
                table: "Trainings",
                column: "TrainingTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComments");

            migrationBuilder.DropTable(
                name: "CourseFilterBadge");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "FilterBadges");

            migrationBuilder.DropTable(
                name: "SubjectTypes");

            migrationBuilder.DropTable(
                name: "TrainingTypes");

            migrationBuilder.DropTable(
                name: "CourseTypes");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
