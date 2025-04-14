using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApi.Migrations
{
    public partial class SeedConfigTableAndChangeAdminUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("4ee8142a-f6ec-4dbc-afc2-4dcb171501b1"), "Pies" },
                    { new Guid("83a61c03-860b-4eee-92d0-7c1c404ab6f0"), "Kot" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a747698-be88-4c59-93d4-3bbccdf43dfc",
                column: "ConcurrencyStamp",
                value: "e888250e-827a-4574-ac0c-a17eb90eedcd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e643aedc-b67e-4ad2-9d84-7019ee5f4f21",
                column: "ConcurrencyStamp",
                value: "c0a5e059-1279-4ca3-801d-57d372c354f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "220302f4-4c79-414e-bb88-6e694007be06", "ADMIN.ANIMALSHELTER@GMAIL.COM", "AQAAAAEAACcQAAAAEA9OcDh2To8ueTjp/s7BtBn6y1aZ+fISwmM1J7kGQi65rfzJ/t+szovGJrrUcDfc5w==", "c7ed3f79-d101-47c7-90b0-3292dd6fbc1c", "admin.animalshelter@gmail.com" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("710b6b11-8334-40af-a25e-c1bfafafebb4"), "Mieszany" },
                    { new Guid("4d03beaa-9499-4b87-ab40-e87e3c073a14"), "Rudy" },
                    { new Guid("f0b766e8-c016-4cf3-a50f-16ee6ba457f6"), "Tricolor" },
                    { new Guid("eb579ec1-99e4-4846-a1f9-96d78f0b51e0"), "Niebieski" },
                    { new Guid("1e6f20a3-277e-47d7-b126-11d2cd9f4ebd"), "Pstrokaty" },
                    { new Guid("e2956862-d837-4b35-a214-254eb5d99e44"), "Podpalane" },
                    { new Guid("c59b5188-160c-4d26-aabd-999c532d741c"), "Marengo" },
                    { new Guid("62b6d38e-efaa-4a4f-8c30-f13c278ae2c4"), "Śniady" },
                    { new Guid("320dc267-b9de-45eb-8bcb-19d98ff87d3b"), "Wilczy" },
                    { new Guid("cc11052c-668f-4da0-8633-7fea328b7a9c"), "Dzicze" },
                    { new Guid("1a4a6e1e-e808-4cca-8590-decafb8b81c2"), "Czarny" },
                    { new Guid("933cae15-859b-45a5-876c-35236fbaa972"), "Biały" }
                });

            migrationBuilder.InsertData(
                table: "Configs",
                columns: new[] { "Key", "ModifiedAt", "ModifiedBy", "Value" },
                values: new object[,]
                {
                    { "Kraj", new DateTime(2022, 1, 13, 10, 51, 37, 279, DateTimeKind.Local).AddTicks(2522), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "Nazwa", new DateTime(2022, 1, 13, 10, 51, 37, 279, DateTimeKind.Local).AddTicks(2520), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "NumerDomu", new DateTime(2022, 1, 13, 10, 51, 37, 279, DateTimeKind.Local).AddTicks(2510), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "NumerKonta", new DateTime(2022, 1, 13, 10, 51, 37, 279, DateTimeKind.Local).AddTicks(2515), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "KodPocztowy", new DateTime(2022, 1, 13, 10, 51, 37, 279, DateTimeKind.Local).AddTicks(2513), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "Ulica", new DateTime(2022, 1, 13, 10, 51, 37, 279, DateTimeKind.Local).AddTicks(2495), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "Opis", new DateTime(2022, 1, 13, 10, 51, 37, 279, DateTimeKind.Local).AddTicks(2518), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "Miasto", new DateTime(2022, 1, 13, 10, 51, 37, 279, DateTimeKind.Local).AddTicks(1302), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("666d8018-7f0d-449c-bf3e-dd6dc71aaee8"), "Bardzo mały" },
                    { new Guid("2534e8a9-ed02-4c29-abd4-96b0fb56e6f9"), "Mały" },
                    { new Guid("78ecba47-0071-4f90-af15-9ecd3604bbd7"), "Duży" },
                    { new Guid("987f67ed-daa3-434b-87bd-975aae0d7c93"), "Średni" },
                    { new Guid("244843bc-9cbe-440b-a185-565c421b11ee"), "Bardzo duży" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("4ee8142a-f6ec-4dbc-afc2-4dcb171501b1"));

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("83a61c03-860b-4eee-92d0-7c1c404ab6f0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1a4a6e1e-e808-4cca-8590-decafb8b81c2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1e6f20a3-277e-47d7-b126-11d2cd9f4ebd"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("320dc267-b9de-45eb-8bcb-19d98ff87d3b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4d03beaa-9499-4b87-ab40-e87e3c073a14"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("62b6d38e-efaa-4a4f-8c30-f13c278ae2c4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("710b6b11-8334-40af-a25e-c1bfafafebb4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("933cae15-859b-45a5-876c-35236fbaa972"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c59b5188-160c-4d26-aabd-999c532d741c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("cc11052c-668f-4da0-8633-7fea328b7a9c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("e2956862-d837-4b35-a214-254eb5d99e44"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("eb579ec1-99e4-4846-a1f9-96d78f0b51e0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f0b766e8-c016-4cf3-a50f-16ee6ba457f6"));

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "KodPocztowy");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Kraj");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Miasto");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Nazwa");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "NumerDomu");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "NumerKonta");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Opis");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Ulica");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("244843bc-9cbe-440b-a185-565c421b11ee"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("2534e8a9-ed02-4c29-abd4-96b0fb56e6f9"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("666d8018-7f0d-449c-bf3e-dd6dc71aaee8"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("78ecba47-0071-4f90-af15-9ecd3604bbd7"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("987f67ed-daa3-434b-87bd-975aae0d7c93"));

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("5c423d74-c6e0-4ad2-914a-4a368bb82439"), "Pies" },
                    { new Guid("fd4c03ae-1127-4575-a9e6-392867e17651"), "Kot" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a747698-be88-4c59-93d4-3bbccdf43dfc",
                column: "ConcurrencyStamp",
                value: "89bc3813-98e5-45e7-a291-b07746ab8d67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e643aedc-b67e-4ad2-9d84-7019ee5f4f21",
                column: "ConcurrencyStamp",
                value: "47aa02c6-c3ef-419c-a9ea-b53ee5060ddb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "44a04810-87c6-490c-90ec-770139dae46a", "ADMIN", "AQAAAAEAACcQAAAAEKl+aeMWVgqBVWMf1OWm3rXvOrh7I9Sh2UyaCo34rb5SoD2w+/UXJSQDOJoGcLi2KA==", "c4a24e90-07d9-42fe-b015-fdbe6317247f", "admin" });

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
        }
    }
}
