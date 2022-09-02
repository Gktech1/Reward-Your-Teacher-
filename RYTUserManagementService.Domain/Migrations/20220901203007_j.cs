using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RYTUserManagementService.Domain.Migrations
{
    public partial class j : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "SchoolStudent");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f5893c0-fd91-494b-b66b-50546f4259d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0e5ee15-5525-4b30-bdac-9a0c4882955c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb7f38d6-f1de-4845-abc8-0830257c1e83");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "4aaa0f5c-7c31-4dbe-bdff-bf5bc934eaec");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7df5a2cc-92a8-44e2-9767-0d3446b9ab10");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "1a3cbf56-67e6-407f-bdfd-b232ad13471d");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "e6f9c0d8-5bfd-4fae-b015-dde559b03e56");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "SchoolId",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "7c1e2be3-53a4-4dec-948d-d4e2e2face50",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "fa17534a-718d -40d5-97cd-7902c790c95a",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26cc9bb3-8686-4a05-8053-bf9dba358711", "f3eb1bfd-b448-45f5-9bbb-66e60f6ea26b", "Student", "STUDENT" },
                    { "8dce0259-a1fe-4e99-81f6-92820ab590a5", "eacaab60-9dc6-41c9-beb8-de22121db4b1", "Administrator", "ADMINISTRATOR" },
                    { "de0724b1-d8c6-4601-9a07-4b0c7d345b03", "afb064ab-b61f-4fcc-9011-c56b7cd0f8e6", "Teacher", "TEACHER" }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "680b8ddb-6842-46fc-ae90-89e334157731",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9200), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9193), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileUrl", "SchoolId", "SecurityStamp", "Title", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "31a5f145-a30b-4405-973f-95913d939ee7", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "1317d068-b4c8-43b6-807b-df38fdff93d2", new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(8036), "Dami", null, false, "Jegede Moses", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "8691ffe5-4273-42d0-9a59-bed24eb5af6e", "acb5a9f2-8564-443a-ae1d-250e271d20da", 0, false, "Dami", null },
                    { "710a0ae7-857b-49f7-99ab-9314e9c5cae5", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "ca645e91-57ce-4223-b794-2d0d5ff304d7", new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(8057), "Dami", null, false, "Jegede Esther", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "8691ffe5-4273-42d0-9a59-bed24eb5af6e", "13a85ae3-7304-4f44-a6d2-0c6d0b02d8aa", 1, false, "Dami", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "EndYear", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "ProfileUrl", "SecurityStamp", "StartYear", "Title", "TwoFactorEnabled", "UpdateAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "45d860a6-e040-48c8-be57-423f5eb4c93b", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "1f48f236-1014-4514-82af-1fa0a17d51f3", new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(7369), "Dami", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayooluwa Moses", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "a274bc90-8712-4e1d-863a-c2b927394121", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null },
                    { "88fc3462-953c-4de2-a7bd-ad24d8a34dc4", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "1e97b297-281c-48f8-921e-34209ddf7435", new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(7394), "Dami", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tijani Moses", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "955e47fd-cc85-459f-a52b-6cb305c8c357", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SchoolId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26cc9bb3-8686-4a05-8053-bf9dba358711");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dce0259-a1fe-4e99-81f6-92820ab590a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de0724b1-d8c6-4601-9a07-4b0c7d345b03");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "31a5f145-a30b-4405-973f-95913d939ee7");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "710a0ae7-857b-49f7-99ab-9314e9c5cae5");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "45d860a6-e040-48c8-be57-423f5eb4c93b");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "88fc3462-953c-4de2-a7bd-ad24d8a34dc4");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Students",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Students",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "SchoolStudent",
                columns: table => new
                {
                    SchoolId = table.Column<string>(type: "text", nullable: false),
                    StudentsId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolStudent", x => new { x.SchoolId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_SchoolStudent_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "7c1e2be3-53a4-4dec-948d-d4e2e2face50",
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 20, 28, 49, 161, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "fa17534a-718d -40d5-97cd-7902c790c95a",
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 20, 28, 49, 161, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9f5893c0-fd91-494b-b66b-50546f4259d1", "4fc6f912-2e49-4116-895f-3e3737c4a4aa", "Student", "STUDENT" },
                    { "a0e5ee15-5525-4b30-bdac-9a0c4882955c", "f2ae3554-b5c3-41a0-b6a9-be5ead812d09", "Administrator", "ADMINISTRATOR" },
                    { "cb7f38d6-f1de-4845-abc8-0830257c1e83", "4acb3a18-409f-481b-af43-a27efcdd8593", "Teacher", "TEACHER" }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "680b8ddb-6842-46fc-ae90-89e334157731",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 30, 20, 28, 49, 161, DateTimeKind.Local).AddTicks(6475), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 30, 20, 28, 49, 161, DateTimeKind.Local).AddTicks(6467), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileUrl", "SecurityStamp", "StudentId", "Title", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "4aaa0f5c-7c31-4dbe-bdff-bf5bc934eaec", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "acef3147-6e94-4fe2-92ab-b54384d001a1", new DateTime(2022, 8, 30, 20, 28, 49, 161, DateTimeKind.Local).AddTicks(6306), "Dami", null, false, "Jegede Moses", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "d4cfb891-6e64-4012-a367-8d13b303ff49", null, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null },
                    { "7df5a2cc-92a8-44e2-9767-0d3446b9ab10", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "d86e0fc6-e690-43dd-a785-fde7cba790ed", new DateTime(2022, 8, 30, 20, 28, 49, 161, DateTimeKind.Local).AddTicks(6324), "Dami", null, false, "Jegede Esther", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "7eee1fc7-3d38-45e6-884f-c657086c29ac", null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "EndYear", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "ProfileUrl", "SecurityStamp", "StartYear", "Title", "TwoFactorEnabled", "UpdateAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "1a3cbf56-67e6-407f-bdfd-b232ad13471d", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "b3265671-d4ed-41ad-b487-bf8bf5e984a8", new DateTime(2022, 8, 30, 20, 28, 49, 161, DateTimeKind.Local).AddTicks(6033), "Dami", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tijani Moses", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "f6021bc4-69ad-4ce3-9be4-35cc9c089816", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null },
                    { "e6f9c0d8-5bfd-4fae-b015-dde559b03e56", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "ac1fcfcb-b649-487e-9fd1-4cb7c8a7675b", new DateTime(2022, 8, 30, 20, 28, 49, 161, DateTimeKind.Local).AddTicks(6003), "Dami", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayooluwa Moses", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "15a3fe11-5861-4357-8b64-ae56bcb9e454", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentId",
                table: "Students",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolStudent_StudentsId",
                table: "SchoolStudent",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentId",
                table: "Students",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}
