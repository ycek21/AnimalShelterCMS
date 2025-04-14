using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApi.Migrations
{
    public partial class TranslateSizeColorAnimalType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("63229941-ad9f-4be5-b7d0-7388a4851791"), "Dog" },
                    { new Guid("53bb8991-f7dd-4409-8286-ec2236c6398b"), "Cat" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a747698-be88-4c59-93d4-3bbccdf43dfc",
                column: "ConcurrencyStamp",
                value: "f9b273fc-2b99-40e3-88b7-9c1213c18e70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e643aedc-b67e-4ad2-9d84-7019ee5f4f21",
                column: "ConcurrencyStamp",
                value: "fc03ce40-874d-41c6-9e0b-7810b21c9b38");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400af917-5dc8-45ba-aab6-afa4d423e726", "AQAAAAEAACcQAAAAEBFfLYgvQmrkIpQgTBiETwIeMTRtIJlTSAneo/qEZnAmyGDE4hvuRJTJWaN0Bteszg==", "2f85c26e-5d59-453e-ac68-7078b8b2cdfd" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("8e1267a3-e2f2-4396-b556-663227e29976"), "Mixed" },
                    { new Guid("451b4421-50aa-4915-9b5b-69ce6b241ae6"), "White" },
                    { new Guid("ef84d4c5-fbc6-484f-9417-896d7e564035"), "Brown" },
                    { new Guid("417c61f4-1375-4958-93f3-c80dee573ef1"), "Yellow" },
                    { new Guid("ed8f7ddd-8eca-4bc7-9a88-7ebec592dea7"), "Gold" },
                    { new Guid("e55c7c3a-2398-485d-b673-103c17b6c991"), "Black" },
                    { new Guid("2fc290a4-2d36-45b9-aa1e-1f1d8dd6e593"), "Fawn" },
                    { new Guid("00eba627-b485-4266-9635-7a3e3a172865"), "Grey" },
                    { new Guid("04de7cb5-1f56-4269-8b7e-453baa927c9f"), "Blue" },
                    { new Guid("67d14cc9-e4b0-499f-b632-4d5e0c6a2704"), "Tricolor" },
                    { new Guid("a3bf36c7-b6b2-44e0-8c8c-58de79228206"), "Red" },
                    { new Guid("05cd10a2-55f4-420b-aa1c-f9fbcba9d1f8"), "Cream" }
                });

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "AccountNumber",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 16, 0, 37, 4, 552, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "City",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 16, 0, 37, 4, 551, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Country",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 16, 0, 37, 4, 552, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Description",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 16, 0, 37, 4, 552, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "HouseNumber",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 16, 0, 37, 4, 552, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Name",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 16, 0, 37, 4, 552, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Postcode",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 16, 0, 37, 4, 552, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Street",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 16, 0, 37, 4, 552, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("6ec77095-31f5-4c2f-8582-b61b671bbfc0"), "Big" },
                    { new Guid("7f55d83b-b703-4d4d-97be-121f2b099f06"), "Medium" },
                    { new Guid("750cc209-6102-4d17-9ec5-b6d9d4788525"), "Small" },
                    { new Guid("fe5851b0-6ef8-4c91-9fb6-6bf92d72effb"), "Very big" },
                    { new Guid("c170ac5b-4e31-487b-ba06-5c9e985c307f"), "Very small" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("53bb8991-f7dd-4409-8286-ec2236c6398b"));

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("63229941-ad9f-4be5-b7d0-7388a4851791"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("00eba627-b485-4266-9635-7a3e3a172865"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("04de7cb5-1f56-4269-8b7e-453baa927c9f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("05cd10a2-55f4-420b-aa1c-f9fbcba9d1f8"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2fc290a4-2d36-45b9-aa1e-1f1d8dd6e593"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("417c61f4-1375-4958-93f3-c80dee573ef1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("451b4421-50aa-4915-9b5b-69ce6b241ae6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("67d14cc9-e4b0-499f-b632-4d5e0c6a2704"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("8e1267a3-e2f2-4396-b556-663227e29976"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a3bf36c7-b6b2-44e0-8c8c-58de79228206"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("e55c7c3a-2398-485d-b673-103c17b6c991"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("ed8f7ddd-8eca-4bc7-9a88-7ebec592dea7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("ef84d4c5-fbc6-484f-9417-896d7e564035"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("6ec77095-31f5-4c2f-8582-b61b671bbfc0"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("750cc209-6102-4d17-9ec5-b6d9d4788525"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("7f55d83b-b703-4d4d-97be-121f2b099f06"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("c170ac5b-4e31-487b-ba06-5c9e985c307f"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("fe5851b0-6ef8-4c91-9fb6-6bf92d72effb"));

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
                    { new Guid("74be0d4f-d95d-4202-9a32-c61837804717"), "Biały" },
                    { new Guid("2468cdbc-a649-454a-af61-2a08485f4d65"), "Dzicze" },
                    { new Guid("11fb068f-29b4-4e4c-bb77-18e8d50fb73b"), "Wilczy" },
                    { new Guid("12811e64-1ff3-4533-afa5-318e32e0d5e8"), "Śniady" },
                    { new Guid("fff05b95-7191-42a6-affa-a01f0d09f317"), "Czarny" },
                    { new Guid("2fdaffcc-72a9-4ffd-aeca-b8ffd56f66a7"), "Podpalane" },
                    { new Guid("d0ee021a-e64e-4000-939e-1d95f9531cab"), "Pstrokaty" },
                    { new Guid("2d57323b-ee49-4758-b494-3b5fb3fc76ec"), "Niebieski" },
                    { new Guid("dd8e7b66-0e6d-4570-a427-1b243946cd67"), "Tricolor" },
                    { new Guid("4b97f80b-0cdb-4521-9d89-913e2da9cc63"), "Rudy" },
                    { new Guid("787b61f0-8faf-4a3a-ab00-ecc43b02f601"), "Marengo" }
                });

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "AccountNumber",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "City",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Country",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Description",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "HouseNumber",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Name",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Postcode",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Street",
                column: "ModifiedAt",
                value: new DateTime(2022, 1, 14, 13, 13, 1, 280, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("841cd5c1-6b10-4240-8e60-d30d4690930c"), "Duży" },
                    { new Guid("e138b5cc-4b91-4d6f-9300-085989ebf5a8"), "Średni" },
                    { new Guid("f3b6d72d-3dbf-4f0a-b84b-2543ae98ebc7"), "Mały" },
                    { new Guid("05ca3496-78eb-4d88-ac2b-d03f148ed486"), "Bardzo duży" },
                    { new Guid("31c5bad0-9f25-4031-98df-ecb1c480958b"), "Bardzo mały" }
                });
        }
    }
}
