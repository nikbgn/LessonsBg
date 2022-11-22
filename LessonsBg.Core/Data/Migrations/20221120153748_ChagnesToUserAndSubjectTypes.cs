using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class ChagnesToUserAndSubjectTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_AspNetUsers_ApplicationUserId",
                table: "Trainings");

            migrationBuilder.DropIndex(
                name: "IX_Trainings_ApplicationUserId",
                table: "Trainings");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a8535a-fb83-4ff4-ad4f-b90a6aa59c1b");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0716ddc0-3ffe-462f-a10a-a99bf3560b91"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("24e6559d-9f5e-447f-88fe-b9f865e412dd"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("39fee1bf-9acb-4ff2-89c8-d3f07f195995"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7ce4ad31-09e2-4676-ac01-ace5ebd9e2be"));

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Trainings");

            migrationBuilder.CreateTable(
                name: "ApplicationUserTraining",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserTraining", x => new { x.ApplicationUserId, x.TrainingId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserTraining_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserTraining_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "845d0b5e-2c47-41a9-989d-95afcdb7edac", 0, "5476ce8c-99be-4d94-9e9c-a88f379e0706", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEOIcrA37iKHgcv0JX1JW6cZiqgFMFEAB8/p047bL3uws/Z1UE6SCVxldQedr2v6aUQ==", "0896782014", true, "bf5c124d-72eb-4c3b-af06-3c82ff7036e8", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("29c95f37-0968-4859-b363-ebba8627cf79"), "Информационни технологии", 3 },
                    { new Guid("796e81b0-19bb-49eb-b3d3-fa28611953c5"), "Математика", 1 },
                    { new Guid("d911612e-e4ff-49a7-b84a-be8bf7ef2657"), "Английски език", 2 },
                    { new Guid("f9caa58d-cc09-493f-a63a-8e9026f001b7"), "Български език", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserTraining_TrainingId",
                table: "ApplicationUserTraining",
                column: "TrainingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserTraining");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "845d0b5e-2c47-41a9-989d-95afcdb7edac");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("29c95f37-0968-4859-b363-ebba8627cf79"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("796e81b0-19bb-49eb-b3d3-fa28611953c5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d911612e-e4ff-49a7-b84a-be8bf7ef2657"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f9caa58d-cc09-493f-a63a-8e9026f001b7"));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Trainings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "73a8535a-fb83-4ff4-ad4f-b90a6aa59c1b", 0, "60486b65-28e3-46eb-ad18-407bd8a152b7", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAED9mKNargMVezm3j1SFsxc4rTt04UQdQEQmdxg/Zgl5nzwtlZtyqWcOJ/RheRdo6TQ==", "0896782014", true, "06dd30b6-3c0f-44ea-9891-06d208e4aa3d", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("0716ddc0-3ffe-462f-a10a-a99bf3560b91"), "Math", 1 },
                    { new Guid("24e6559d-9f5e-447f-88fe-b9f865e412dd"), "Informational Technologies", 3 },
                    { new Guid("39fee1bf-9acb-4ff2-89c8-d3f07f195995"), "Bulgarian Language", 2 },
                    { new Guid("7ce4ad31-09e2-4676-ac01-ace5ebd9e2be"), "English Language", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_ApplicationUserId",
                table: "Trainings",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_AspNetUsers_ApplicationUserId",
                table: "Trainings",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
