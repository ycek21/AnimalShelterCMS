using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApi.Migrations
{
    public partial class TranslateConfigConfigurationToEnglish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("d051cc3b-c129-422f-820a-08d594e7d9ab"), "Pies" },
                    { new Guid("250564a1-c268-4717-a178-40aaa7071ba7"), "Kot" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a747698-be88-4c59-93d4-3bbccdf43dfc",
                column: "ConcurrencyStamp",
                value: "cddb98f3-1a57-44cf-a8c7-84ff8b76080b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e643aedc-b67e-4ad2-9d84-7019ee5f4f21",
                column: "ConcurrencyStamp",
                value: "6ad95935-35d7-4b54-9b20-4c141028e743");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc215c94-4c6b-420f-94e5-104c497b4be2", "AQAAAAEAACcQAAAAEARRPd2p8kQ1f8E2/U+Qc/62pkmbpfSwsLzRew0zhpiyBT9OQzwgovuNow8YZpHzww==", "bcac9e0a-f3b0-4894-92c1-380222a5e4aa" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("a5ae7733-ae46-49bc-b595-4ce33637a1fa"), "Mieszany" },
                    { new Guid("4b97f80b-0cdb-4521-9d89-913e2da9cc63"), "Rudy" },
                    { new Guid("dd8e7b66-0e6d-4570-a427-1b243946cd67"), "Tricolor" },
                    { new Guid("2d57323b-ee49-4758-b494-3b5fb3fc76ec"), "Niebieski" },
                    { new Guid("d0ee021a-e64e-4000-939e-1d95f9531cab"), "Pstrokaty" },
                    { new Guid("2fdaffcc-72a9-4ffd-aeca-b8ffd56f66a7"), "Podpalane" },
                    { new Guid("787b61f0-8faf-4a3a-ab00-ecc43b02f601"), "Marengo" },
                    { new Guid("12811e64-1ff3-4533-afa5-318e32e0d5e8"), "Śniady" },
                    { new Guid("11fb068f-29b4-4e4c-bb77-18e8d50fb73b"), "Wilczy" },
                    { new Guid("2468cdbc-a649-454a-af61-2a08485f4d65"), "Dzicze" },
                    { new Guid("fff05b95-7191-42a6-affa-a01f0d09f317"), "Czarny" },
                    { new Guid("74be0d4f-d95d-4202-9a32-c61837804717"), "Biały" }
                });

            migrationBuilder.InsertData(
                table: "Configs",
                columns: new[] { "Key", "ModifiedAt", "ModifiedBy", "Value" },
                values: new object[,]
                {
                    { "Country", new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "Name", new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "HouseNumber", new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "AccountNumber", new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "Postcode", new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "Street", new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1850), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "Description", new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" },
                    { "City", new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(230), "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("31c5bad0-9f25-4031-98df-ecb1c480958b"), "Bardzo mały" },
                    { new Guid("f3b6d72d-3dbf-4f0a-b84b-2543ae98ebc7"), "Mały" },
                    { new Guid("841cd5c1-6b10-4240-8e60-d30d4690930c"), "Duży" },
                    { new Guid("e138b5cc-4b91-4d6f-9300-085989ebf5a8"), "Średni" },
                    { new Guid("05ca3496-78eb-4d88-ac2b-d03f148ed486"), "Bardzo duży" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("250564a1-c268-4717-a178-40aaa7071ba7"));

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("d051cc3b-c129-422f-820a-08d594e7d9ab"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("11fb068f-29b4-4e4c-bb77-18e8d50fb73b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("12811e64-1ff3-4533-afa5-318e32e0d5e8"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2468cdbc-a649-454a-af61-2a08485f4d65"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2d57323b-ee49-4758-b494-3b5fb3fc76ec"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2fdaffcc-72a9-4ffd-aeca-b8ffd56f66a7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4b97f80b-0cdb-4521-9d89-913e2da9cc63"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("74be0d4f-d95d-4202-9a32-c61837804717"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("787b61f0-8faf-4a3a-ab00-ecc43b02f601"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a5ae7733-ae46-49bc-b595-4ce33637a1fa"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d0ee021a-e64e-4000-939e-1d95f9531cab"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("dd8e7b66-0e6d-4570-a427-1b243946cd67"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("fff05b95-7191-42a6-affa-a01f0d09f317"));

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "AccountNumber");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "City");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Country");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Description");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "HouseNumber");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Name");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Postcode");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Street");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("05ca3496-78eb-4d88-ac2b-d03f148ed486"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("31c5bad0-9f25-4031-98df-ecb1c480958b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("841cd5c1-6b10-4240-8e60-d30d4690930c"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("e138b5cc-4b91-4d6f-9300-085989ebf5a8"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("f3b6d72d-3dbf-4f0a-b84b-2543ae98ebc7"));

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "220302f4-4c79-414e-bb88-6e694007be06", "AQAAAAEAACcQAAAAEA9OcDh2To8ueTjp/s7BtBn6y1aZ+fISwmM1J7kGQi65rfzJ/t+szovGJrrUcDfc5w==", "c7ed3f79-d101-47c7-90b0-3292dd6fbc1c" });

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
    }
}
