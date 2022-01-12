using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApi.Migrations
{
    public partial class SeedDatabaseWithAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("f3881d2a-9260-41ef-97d3-db1db4192728"));

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("ff6aa101-cccc-4e0f-9024-f330c4c9f526"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c418813-1ce5-4ade-ad4c-d2b91357bd08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a4461c-0a87-4a56-bfa7-431d5df7e778");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("0366c800-7f11-40c9-8165-45432bbe922d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("0cc3cedf-7157-4b7f-9922-09f5b623f8eb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("128bbd32-0d9d-47de-937c-704466e9a4da"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("20ba9c93-8378-4bfd-bae3-baa2b7f9c3a3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2cb8c27e-2a3f-4e25-abb8-5c4a7d7367cb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4fe0c397-c07a-4c21-943a-5669c475ed5b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c53d2623-44ca-4b34-9240-6222a72d6400"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c6440bc9-5331-40b4-ae02-3d845bf795ae"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d2d2eafa-0937-4eb3-a205-e5b2e6b218dd"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("dc89c7fd-4f7a-4ce5-ba5c-8a193ddeccbc"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("e0d71fc3-2e4e-44bb-9035-1cd1a8a459c4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f9274529-6349-4b8c-b2a6-c5c6eaf2480a"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("0b32ad7f-628e-461c-b8a8-92ea4f97d844"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("519bf762-1860-40fe-bb19-4d28106d0c03"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("b3dab2de-b8b7-47dc-a627-f928877a53de"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("cc5a76e4-352f-42f5-8e43-2a202b867eef"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("ebc073c2-e5e0-4897-8638-4e88b4ffb16c"));

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("5c423d74-c6e0-4ad2-914a-4a368bb82439"), "Pies" },
                    { new Guid("fd4c03ae-1127-4575-a9e6-392867e17651"), "Kot" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a747698-be88-4c59-93d4-3bbccdf43dfc", "89bc3813-98e5-45e7-a291-b07746ab8d67", "CommonUser", "COMMON" },
                    { "e643aedc-b67e-4ad2-9d84-7019ee5f4f21", "47aa02c6-c3ef-419c-a9ea-b53ee5060ddb", "Administrator", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", 0, "44a04810-87c6-490c-90ec-770139dae46a", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.animalshelter@gmail.com", false, false, null, "Admin", "ADMIN.ANIMALSHELTER@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKl+aeMWVgqBVWMf1OWm3rXvOrh7I9Sh2UyaCo34rb5SoD2w+/UXJSQDOJoGcLi2KA==", null, false, "c4a24e90-07d9-42fe-b015-fdbe6317247f", "Admin", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("1cf89ef6-2113-4eb3-9b6d-9dc5336d6bb2"), "Mieszany" },
                    { new Guid("18aa8e55-24c6-4df7-b9e6-a239b14244fd"), "Dzicze" },
                    { new Guid("6002645c-af53-46e0-aab0-35e31c98bc94"), "Biały" },
                    { new Guid("14a8c425-a385-4c70-b720-9f13b83c0f91"), "Śniady" },
                    { new Guid("6323691a-a06c-45c4-9a04-faf4e0c27a2c"), "Czarny" },
                    { new Guid("89bbf56f-45ce-4e5f-9d6b-c10dc2765ac3"), "Wilczy" },
                    { new Guid("b373a6f8-2da4-4591-b409-94623c8ce3df"), "Pstrokaty" },
                    { new Guid("b6a3eab5-1138-4ea3-82eb-53d053f90284"), "Niebieski" },
                    { new Guid("94a6397a-d86c-4bba-839d-6cfffbf384d7"), "Tricolor" },
                    { new Guid("839a2701-827e-45f0-b79a-14f929b18d05"), "Rudy" },
                    { new Guid("f07d20da-16a6-4a3b-b6f6-82a77eb50bf4"), "Podpalane" },
                    { new Guid("1922d82a-251a-4d77-b6ef-71b2baef261d"), "Marengo" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("58d0ef32-dc58-4d28-9c63-98529ad64629"), "Bardzo mały" },
                    { new Guid("60543661-6608-4f47-8183-204c0576e4a7"), "Mały" },
                    { new Guid("2765008c-121e-410b-a855-8f2e484cfd34"), "Duży" },
                    { new Guid("7be284a7-3bcf-4d9e-8b74-3727da58e468"), "Średni" },
                    { new Guid("b1c86f5b-1c27-48e2-bb1d-2147e187d6c5"), "Bardzo duży" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e643aedc-b67e-4ad2-9d84-7019ee5f4f21", "B22698B8-42A2-4115-9631-1C2D1E2AC5F7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("5c423d74-c6e0-4ad2-914a-4a368bb82439"));

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("fd4c03ae-1127-4575-a9e6-392867e17651"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a747698-be88-4c59-93d4-3bbccdf43dfc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e643aedc-b67e-4ad2-9d84-7019ee5f4f21", "B22698B8-42A2-4115-9631-1C2D1E2AC5F7" });

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("14a8c425-a385-4c70-b720-9f13b83c0f91"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("18aa8e55-24c6-4df7-b9e6-a239b14244fd"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1922d82a-251a-4d77-b6ef-71b2baef261d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1cf89ef6-2113-4eb3-9b6d-9dc5336d6bb2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6002645c-af53-46e0-aab0-35e31c98bc94"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6323691a-a06c-45c4-9a04-faf4e0c27a2c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("839a2701-827e-45f0-b79a-14f929b18d05"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("89bbf56f-45ce-4e5f-9d6b-c10dc2765ac3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("94a6397a-d86c-4bba-839d-6cfffbf384d7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b373a6f8-2da4-4591-b409-94623c8ce3df"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b6a3eab5-1138-4ea3-82eb-53d053f90284"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f07d20da-16a6-4a3b-b6f6-82a77eb50bf4"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("2765008c-121e-410b-a855-8f2e484cfd34"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("58d0ef32-dc58-4d28-9c63-98529ad64629"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("60543661-6608-4f47-8183-204c0576e4a7"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("7be284a7-3bcf-4d9e-8b74-3727da58e468"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("b1c86f5b-1c27-48e2-bb1d-2147e187d6c5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e643aedc-b67e-4ad2-9d84-7019ee5f4f21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7");

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("f3881d2a-9260-41ef-97d3-db1db4192728"), "Pies" },
                    { new Guid("ff6aa101-cccc-4e0f-9024-f330c4c9f526"), "Kot" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c418813-1ce5-4ade-ad4c-d2b91357bd08", "dcb82592-6ec9-4d72-b87c-f6378110919a", "CommonUser", "COMMON" },
                    { "b6a4461c-0a87-4a56-bfa7-431d5df7e778", "c23336eb-56ce-4aed-b28b-a153bec47f79", "Administrator", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "59319ef6-b427-4fd3-834f-4417ec0e8b28", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "animal.shelter@gmail.com", false, false, null, "Admin", null, null, "xd", null, false, "4b2bb99b-0470-4dff-b2f9-2b332975e06f", "Super", false, null });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("f9274529-6349-4b8c-b2a6-c5c6eaf2480a"), "Mieszany" },
                    { new Guid("0366c800-7f11-40c9-8165-45432bbe922d"), "Dzicze" },
                    { new Guid("c53d2623-44ca-4b34-9240-6222a72d6400"), "Biały" },
                    { new Guid("0cc3cedf-7157-4b7f-9922-09f5b623f8eb"), "Śniady" },
                    { new Guid("2cb8c27e-2a3f-4e25-abb8-5c4a7d7367cb"), "Czarny" },
                    { new Guid("d2d2eafa-0937-4eb3-a205-e5b2e6b218dd"), "Wilczy" },
                    { new Guid("4fe0c397-c07a-4c21-943a-5669c475ed5b"), "Pstrokaty" },
                    { new Guid("c6440bc9-5331-40b4-ae02-3d845bf795ae"), "Niebieski" },
                    { new Guid("128bbd32-0d9d-47de-937c-704466e9a4da"), "Tricolor" },
                    { new Guid("20ba9c93-8378-4bfd-bae3-baa2b7f9c3a3"), "Rudy" },
                    { new Guid("e0d71fc3-2e4e-44bb-9035-1cd1a8a459c4"), "Podpalane" },
                    { new Guid("dc89c7fd-4f7a-4ce5-ba5c-8a193ddeccbc"), "Marengo" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("ebc073c2-e5e0-4897-8638-4e88b4ffb16c"), "Bardzo mały" },
                    { new Guid("cc5a76e4-352f-42f5-8e43-2a202b867eef"), "Mały" },
                    { new Guid("519bf762-1860-40fe-bb19-4d28106d0c03"), "Duży" },
                    { new Guid("0b32ad7f-628e-461c-b8a8-92ea4f97d844"), "Średni" },
                    { new Guid("b3dab2de-b8b7-47dc-a627-f928877a53de"), "Bardzo duży" }
                });
        }
    }
}
