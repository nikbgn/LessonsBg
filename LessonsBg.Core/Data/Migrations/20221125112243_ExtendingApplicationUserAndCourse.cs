using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class ExtendingApplicationUserAndCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_AspNetUsers_AuthorId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_AuthorId",
                table: "Courses");

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

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "ApplicationUserCourse",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserCourse", x => new { x.ApplicationUserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserCourse_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "05d1c478-9ba2-42db-a320-dfc3e2e9b305", 0, "92d4a079-8775-4fac-9340-414034d93af3", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEEKnYlfN0JAjO9dk2P7vsg0uKeawL4lbGNSJKhBdvk/mDKaY8xvpe/k9qJ6Wk4Pp2g==", "0891111111", true, "https://i.imgur.com/zqWjZFV.png", "0200e11c-43a6-43fa-9a48-0b65a4dfc3b4", false, "niki_admin@niki.bg" });

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
                name: "IX_ApplicationUserCourse_CourseId",
                table: "ApplicationUserCourse",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserCourse");

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

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Author ID.");

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

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AuthorId",
                table: "Courses",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_AspNetUsers_AuthorId",
                table: "Courses",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
