using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RYTUserManagementService.Domain.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "7c1e2be3-53a4-4dec-948d-d4e2e2face50",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "fa17534a-718d -40d5-97cd-7902c790c95a",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26ed916a-f1ea-4ccb-929b-49d1c2ba6f8c", "bb021d2c-2499-4c4e-a126-64fb37cf6902", "Administrator", "ADMINISTRATOR" },
                    { "2deeae0a-a0a5-4066-bfd4-b249074f511b", "3de8ceae-853d-4248-92ac-ed310ce8c09b", "Teacher", "TEACHER" },
                    { "44b5f15f-100b-4a64-937b-d6c1e130c379", "0c72cd9a-c055-41e7-8c5d-bafee45f7def", "Student", "STUDENT" }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "680b8ddb-6842-46fc-ae90-89e334157731",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileUrl", "SchoolId", "SecurityStamp", "Title", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "36e00b0a-4823-4e45-b867-18302291ab79", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "dd758745-c422-4420-8805-6436cdea83dc", new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3529), "Dami", null, false, "Jegede Esther", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "8691ffe5-4273-42d0-9a59-bed24eb5af6e", "2c2ae121-9292-49e5-9d80-9f4aadaec6cb", 1, false, "Dami", null },
                    { "ecf29d49-8d8d-4411-9859-61fd62ef2b70", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "6d5ad5cc-c4d9-4b1a-ae35-01e339c1c0e3", new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3518), "Dami", null, false, "Jegede Moses", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "8691ffe5-4273-42d0-9a59-bed24eb5af6e", "7b84d5e1-8161-490c-885a-5b9bcf9ff267", 0, false, "Dami", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "EndYear", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "ProfileUrl", "SecurityStamp", "StartYear", "Title", "TwoFactorEnabled", "UpdateAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "6ff2a432-e3f7-4408-bdb5-c8afb6f8eaeb", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "66fce208-41c9-44dc-9cf5-f96677e31455", new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3298), "Dami", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tijani Moses", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "77aad4e7-9a25-4447-85aa-cb3ed37839e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null },
                    { "85a7ce54-d917-4fc4-9ef5-5682e8c985ca", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "34807301-551a-4fca-823b-56f79e64b49d", new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3280), "Dami", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayooluwa Moses", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "20d370f8-eb39-48f5-8631-f1ea37b3977a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26ed916a-f1ea-4ccb-929b-49d1c2ba6f8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2deeae0a-a0a5-4066-bfd4-b249074f511b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44b5f15f-100b-4a64-937b-d6c1e130c379");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "36e00b0a-4823-4e45-b867-18302291ab79");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ecf29d49-8d8d-4411-9859-61fd62ef2b70");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "6ff2a432-e3f7-4408-bdb5-c8afb6f8eaeb");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "85a7ce54-d917-4fc4-9ef5-5682e8c985ca");

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
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9193));

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
        }
    }
}
