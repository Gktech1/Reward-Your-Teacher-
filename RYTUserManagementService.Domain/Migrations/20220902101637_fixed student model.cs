using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RYTUserManagementService.Domain.Migrations
{
    public partial class fixedstudentmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Schools_Teacher_SchoolId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Teacher_SchoolId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3afef8f5-5f56-4498-8039-9cd766437a49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6044a881-c77d-4caf-a8d7-8339f4e75feb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3506fb1-0c7a-4961-90ab-fe7b5fdf0556");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109f26dc-85d1-49a9-b02b-fb46f5b05f6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfd51f44-1028-4521-9436-f9036302d15c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75b04886-f726-4d9f-83f7-cc31d138d5bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "827e6621-f9d6-42e4-9791-82d1d7e19733");

            migrationBuilder.RenameColumn(
                name: "Teacher_SchoolId",
                table: "AspNetUsers",
                newName: "SchoolName");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "a7dd2ab0-289c-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 11, 16, 37, 107, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "b01430ca-289c-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 11, 16, 37, 107, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87d64490-d937-4840-ab88-668cf1ba92be", "e1009246-d8e8-47de-ba09-ec76c9cedceb", "Student", "STUDENT" },
                    { "a2cdc86a-5eb0-440b-89f9-3cc7ec5fe7a1", "0203affa-3883-4897-bd9c-195640edc634", "Administrator", "ADMINISTRATOR" },
                    { "ddd7aa73-ea64-4f5a-b59a-398868ddbf04", "bdd65c4b-d0f3-4211-b6e5-5d9f08552b2a", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Discriminator", "Email", "EmailConfirmed", "FirstName", "FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileUrl", "SchoolName", "SecurityStamp", "Title", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "0abacee8-698a-4d9b-941a-f76fdaa0a543", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "5708ac70-f183-44ef-8741-354acac1df49", new DateTime(2022, 9, 2, 11, 16, 37, 107, DateTimeKind.Local).AddTicks(5036), "Dami", "Student", null, false, "bayo", "Jegede Esther", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "Lara&Manny Int'l sec school", "f92207cf-bb8e-4a53-ac9f-a11b3cc1bb56", 1, false, "Dami", null },
                    { "cffb1175-afa1-48e4-9813-2cf9e2772f77", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "599a873d-56a1-456a-837c-724c306c8ccc", new DateTime(2022, 9, 2, 11, 16, 37, 107, DateTimeKind.Local).AddTicks(4975), "Dami", "Student", null, false, "bayo", "Jegede Moses", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "Lara&Manny Int'l sec school", "bc758277-572c-4c20-88bc-91b8a7367087", 0, false, "Dami", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "Teacher_About", "AccessFailedCount", "Teacher_Address", "ConcurrencyStamp", "Teacher_CreatedAt", "Teacher_CreatedBy", "Discriminator", "Email", "EmailConfirmed", "EndYear", "FirstName", "Teacher_FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Teacher_ProfileUrl", "SchoolId", "SecurityStamp", "StartYear", "Teacher_Title", "TwoFactorEnabled", "UpdateAt", "Teacher_UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "bdd899a4-2233-4b0c-9c43-33e23f91cfc6", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "4995fb32-0f69-40e1-bff2-f4a3bed6c475", new DateTime(2022, 9, 2, 11, 16, 37, 107, DateTimeKind.Local).AddTicks(4770), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Ayooluwa Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "e4f5782f-a528-4d89-851f-fcce56abeebf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null },
                    { "ffbdc8db-2380-4af9-ae25-eefe42a9d4f9", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "7d5acfba-03a6-4772-9487-3b41c5a82847", new DateTime(2022, 9, 2, 11, 16, 37, 107, DateTimeKind.Local).AddTicks(4786), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Tijani Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "e396d1dd-38bf-44e7-a68b-cb5f3518c64d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "11f09734-289d-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 11, 16, 37, 107, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "21addd9e-289d-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 11, 16, 37, 107, DateTimeKind.Local).AddTicks(5108));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87d64490-d937-4840-ab88-668cf1ba92be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2cdc86a-5eb0-440b-89f9-3cc7ec5fe7a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddd7aa73-ea64-4f5a-b59a-398868ddbf04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0abacee8-698a-4d9b-941a-f76fdaa0a543");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cffb1175-afa1-48e4-9813-2cf9e2772f77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdd899a4-2233-4b0c-9c43-33e23f91cfc6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffbdc8db-2380-4af9-ae25-eefe42a9d4f9");

            migrationBuilder.RenameColumn(
                name: "SchoolName",
                table: "AspNetUsers",
                newName: "Teacher_SchoolId");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "a7dd2ab0-289c-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "b01430ca-289c-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3afef8f5-5f56-4498-8039-9cd766437a49", "a8f02da8-b6c3-485c-82c8-35881890744d", "Student", "STUDENT" },
                    { "6044a881-c77d-4caf-a8d7-8339f4e75feb", "b096193d-6890-46d3-89fd-628dae7a12d1", "Teacher", "TEACHER" },
                    { "a3506fb1-0c7a-4961-90ab-fe7b5fdf0556", "a9d31d98-e6c7-4c86-8bb5-bf1f5fac673b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Discriminator", "Email", "EmailConfirmed", "FirstName", "FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileUrl", "SchoolId", "SecurityStamp", "Title", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "109f26dc-85d1-49a9-b02b-fb46f5b05f6c", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "d8d6e271-737c-4ca7-84c3-cf55bfc25e78", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4307), "Dami", "Student", null, false, "bayo", "Jegede Esther", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "778df6a3-712f-489f-85d7-b80275d0428e", 1, false, "Dami", null },
                    { "bfd51f44-1028-4521-9436-f9036302d15c", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "f2e8562f-d717-4189-a4a0-26eb3d5e8e82", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4292), "Dami", "Student", null, false, "bayo", "Jegede Moses", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "4afc8adb-98e0-40ef-92b9-9530764160af", 0, false, "Dami", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "Teacher_About", "AccessFailedCount", "Teacher_Address", "ConcurrencyStamp", "Teacher_CreatedAt", "Teacher_CreatedBy", "Discriminator", "Email", "EmailConfirmed", "EndYear", "FirstName", "Teacher_FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Teacher_ProfileUrl", "Teacher_SchoolId", "SecurityStamp", "StartYear", "Teacher_Title", "TwoFactorEnabled", "UpdateAt", "Teacher_UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "75b04886-f726-4d9f-83f7-cc31d138d5bd", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "7780d4ac-795b-4336-9758-e754c68ce239", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(3762), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Ayooluwa Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "21d460f2-bf21-4975-a398-005b543d17e1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null },
                    { "827e6621-f9d6-42e4-9791-82d1d7e19733", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "8caa8a7b-263e-4d46-9203-0ba428e1d552", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(3786), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Tijani Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "e8a9a6a0-c411-466d-9a9f-3dc47d5d4dbe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "11f09734-289d-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "21addd9e-289d-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Teacher_SchoolId",
                table: "AspNetUsers",
                column: "Teacher_SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Schools_Teacher_SchoolId",
                table: "AspNetUsers",
                column: "Teacher_SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
