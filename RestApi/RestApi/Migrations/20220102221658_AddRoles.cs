using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApi.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("2d9a7b28-f271-4412-86d0-04c4a2048bd9"));

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("82421a1c-97ad-4bca-940a-8815c94aa98c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("0193ad29-7fec-4a8c-bacb-3cc8e1288072"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("05b83639-3b1d-4c7e-807a-fb8ad063a46c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2f2a1368-c933-475c-8fc4-58ffe99bb558"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("3021fb17-8710-4a21-a2d8-08580e3e8d3a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("320a83e6-8586-4a58-9781-728d0b234199"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("37b9e3b4-fcbb-46a0-a9f9-86370b528979"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("52166574-1c89-4151-9e4a-9dd6394cf07d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("7eaeef05-87f7-429e-9195-aa0a6e416a97"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("9554ff54-fc06-4db6-a4a6-e238a51c20ba"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("bb9cc7f2-87d3-49b1-98df-3b33b85bc3e3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d4e83d31-6eac-47f2-ad7f-a625994d3f68"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("e27e0bd7-c43b-47f9-bef2-5bd5ac532520"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("2e1a4907-6422-4b00-921a-3e529f8dfff5"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4af9c1cb-d6a8-4efc-ac81-5891398168bd"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("5778047a-5be7-4280-b1a5-1dd69ff679ba"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("71502039-f3ec-4545-b7b0-7e6ad0365701"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("d331a302-391d-4589-98b5-a9878df8c685"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("82421a1c-97ad-4bca-940a-8815c94aa98c"), "Pies" },
                    { new Guid("2d9a7b28-f271-4412-86d0-04c4a2048bd9"), "Kot" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("e27e0bd7-c43b-47f9-bef2-5bd5ac532520"), "Dzicze" },
                    { new Guid("320a83e6-8586-4a58-9781-728d0b234199"), "Wilczy" },
                    { new Guid("05b83639-3b1d-4c7e-807a-fb8ad063a46c"), "Śniady" },
                    { new Guid("d4e83d31-6eac-47f2-ad7f-a625994d3f68"), "Marengo" },
                    { new Guid("37b9e3b4-fcbb-46a0-a9f9-86370b528979"), "Pstrokaty" },
                    { new Guid("52166574-1c89-4151-9e4a-9dd6394cf07d"), "Podpalane" },
                    { new Guid("7eaeef05-87f7-429e-9195-aa0a6e416a97"), "Tricolor" },
                    { new Guid("2f2a1368-c933-475c-8fc4-58ffe99bb558"), "Rudy" },
                    { new Guid("0193ad29-7fec-4a8c-bacb-3cc8e1288072"), "Mieszany" },
                    { new Guid("3021fb17-8710-4a21-a2d8-08580e3e8d3a"), "Biały" },
                    { new Guid("9554ff54-fc06-4db6-a4a6-e238a51c20ba"), "Czarny" },
                    { new Guid("bb9cc7f2-87d3-49b1-98df-3b33b85bc3e3"), "Niebieski" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("4af9c1cb-d6a8-4efc-ac81-5891398168bd"), "Średni" },
                    { new Guid("5778047a-5be7-4280-b1a5-1dd69ff679ba"), "Bardzo mały" },
                    { new Guid("71502039-f3ec-4545-b7b0-7e6ad0365701"), "Mały" },
                    { new Guid("2e1a4907-6422-4b00-921a-3e529f8dfff5"), "Duży" },
                    { new Guid("d331a302-391d-4589-98b5-a9878df8c685"), "Bardzo duży" }
                });
        }
    }
}
