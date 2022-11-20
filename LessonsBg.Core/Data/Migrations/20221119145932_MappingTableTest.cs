using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBg.Core.Data.Migrations
{
    public partial class MappingTableTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_AspNetUsers_ApplicationUserId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ApplicationUserId",
                table: "Subjects");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fb45ac3-ff78-46b9-9682-f06bd1b2e69b");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("614f6927-7bc5-4f4e-83d9-e28949f2f4b8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("80cf63a8-18f0-4fb9-a99b-75fd5d5541d7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("81df911b-3df5-4295-8deb-7ad44e2dbac3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e87ab44c-0c99-491c-b07b-222958db4aec"));

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Subjects");

            migrationBuilder.CreateTable(
                name: "ApplicationUserSubject",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserSubject", x => new { x.ApplicationUserId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserSubject_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserSubject_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cbc5295a-e900-4e4a-a96b-2d47368f6e36", 0, "8fc728f4-f843-4592-a423-762f022ae857", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEHrd9hR0RQ4kU3TN4X+TPStdsv4QM2C7eCv0CR+QPVd+iP3435ow6tiWMmzsFteiAw==", "0896782014", true, "9089744d-b423-43b1-9cfc-8f06d988bf63", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("430dc2fa-440c-461d-b147-69ec260077ea"), "English Language", 2 },
                    { new Guid("c64745eb-e0e0-47ff-a70d-709d8dc10515"), "Math", 1 },
                    { new Guid("c8c9632d-2966-452c-afb4-a2315f99e120"), "Informational Technologies", 3 },
                    { new Guid("e39ed3a9-8938-412b-8026-ec0dc1d8b261"), "Bulgarian Language", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserSubject_SubjectId",
                table: "ApplicationUserSubject",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserSubject");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbc5295a-e900-4e4a-a96b-2d47368f6e36");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("430dc2fa-440c-461d-b147-69ec260077ea"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c64745eb-e0e0-47ff-a70d-709d8dc10515"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c8c9632d-2966-452c-afb4-a2315f99e120"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e39ed3a9-8938-412b-8026-ec0dc1d8b261"));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1fb45ac3-ff78-46b9-9682-f06bd1b2e69b", 0, "78eccb2f-2f97-4ba6-8a4f-f55b0a366a59", "niki_admin@niki.bg", true, "Николай", "Иванов", false, null, "NIKI_ADMIN@NIKI.BG", "NIKI_ADMIN@NIKI.BG", "AQAAAAEAACcQAAAAEOWL9aEYv2WJrPEhPhmLI4mYH40dZh6ONwRgvxlEABhwLJArkkQUAUWJ0UiaPSwBaA==", "0896782014", true, "7b52b990-b605-452c-bfc1-88fbbbe4fba7", false, "niki_admin@niki.bg" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "ApplicationUserId", "Name", "SubjectTypeId" },
                values: new object[,]
                {
                    { new Guid("614f6927-7bc5-4f4e-83d9-e28949f2f4b8"), null, "Math", 1 },
                    { new Guid("80cf63a8-18f0-4fb9-a99b-75fd5d5541d7"), null, "English Language", 2 },
                    { new Guid("81df911b-3df5-4295-8deb-7ad44e2dbac3"), null, "Informational Technologies", 3 },
                    { new Guid("e87ab44c-0c99-491c-b07b-222958db4aec"), null, "Bulgarian Language", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ApplicationUserId",
                table: "Subjects",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_AspNetUsers_ApplicationUserId",
                table: "Subjects",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
