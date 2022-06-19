using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApi.Migrations
{
    public partial class AdminHasEmailConfirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("22af1e2e-c705-45b0-b803-48ed6dbd7e49"), "Dog" },
                    { new Guid("ddc1e11f-986c-4b64-b140-8901591960f2"), "Cat" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a747698-be88-4c59-93d4-3bbccdf43dfc",
                column: "ConcurrencyStamp",
                value: "036d52de-032b-41c2-a622-4ffc892e2e94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e643aedc-b67e-4ad2-9d84-7019ee5f4f21",
                column: "ConcurrencyStamp",
                value: "b8302a42-3031-4842-90ba-8899e17dc152");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "620d8eb1-452a-426c-a11c-d3325d886e8a", true, "AQAAAAEAACcQAAAAEHOGAJJwsSbS6xVqNCQfkg7gGwmS2gF4CTyro+OJDjwCsdqwv72pYP3O2X3R4hTeNg==", "90d4bbff-5573-490b-a342-d00beab8e1f6" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("a770746e-6252-4e8b-942f-8f680f5c96f1"), "Mixed" },
                    { new Guid("5e11bd2a-99f4-471a-9be8-439fcb461f78"), "White" },
                    { new Guid("41db418c-9fa4-428f-bb24-322c7f499c0a"), "Brown" },
                    { new Guid("82c34944-08ab-4ea0-8577-16a15d3cc948"), "Yellow" },
                    { new Guid("51d49c85-6fa6-4757-8619-8aa2d7b6570d"), "Gold" },
                    { new Guid("31ff5a4b-f9d7-4a88-89e8-7c31ea9b143d"), "Black" },
                    { new Guid("60e9c031-96ed-401f-820d-27dfb3c55b54"), "Fawn" },
                    { new Guid("e5023ca0-5df8-446c-bef3-a16f6d534f15"), "Grey" },
                    { new Guid("070bf5e4-eb07-4fb1-a67f-2cc1df747d4f"), "Blue" },
                    { new Guid("a064e38b-3944-4cf6-a51c-5476d1fc449c"), "Tricolor" },
                    { new Guid("c57ba40a-49d4-4500-a3d9-5c4bb6b58c94"), "Red" },
                    { new Guid("a6d23da2-70b5-4645-825c-ecae432776e1"), "Cream" }
                });

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "AccountNumber",
                column: "ModifiedAt",
                value: new DateTime(2022, 6, 19, 16, 22, 25, 615, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "City",
                column: "ModifiedAt",
                value: new DateTime(2022, 6, 19, 16, 22, 25, 615, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Country",
                column: "ModifiedAt",
                value: new DateTime(2022, 6, 19, 16, 22, 25, 615, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Description",
                column: "ModifiedAt",
                value: new DateTime(2022, 6, 19, 16, 22, 25, 615, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "HouseNumber",
                column: "ModifiedAt",
                value: new DateTime(2022, 6, 19, 16, 22, 25, 615, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Name",
                column: "ModifiedAt",
                value: new DateTime(2022, 6, 19, 16, 22, 25, 615, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Postcode",
                column: "ModifiedAt",
                value: new DateTime(2022, 6, 19, 16, 22, 25, 615, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Key",
                keyValue: "Street",
                column: "ModifiedAt",
                value: new DateTime(2022, 6, 19, 16, 22, 25, 615, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("ca9b7b43-b191-42b1-b842-858a1ef6953c"), "Big" },
                    { new Guid("69c080f9-3f05-4bb8-b710-83de405ef82b"), "Medium" },
                    { new Guid("e8f5f6f8-2594-4b3d-b652-327cc8c6fe31"), "Small" },
                    { new Guid("6966acf5-3e2a-4a80-9d47-20b8c60160a1"), "Very big" },
                    { new Guid("406bb3a9-5c38-41c4-85ff-3667245eab32"), "Very small" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("22af1e2e-c705-45b0-b803-48ed6dbd7e49"));

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: new Guid("ddc1e11f-986c-4b64-b140-8901591960f2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("070bf5e4-eb07-4fb1-a67f-2cc1df747d4f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("31ff5a4b-f9d7-4a88-89e8-7c31ea9b143d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("41db418c-9fa4-428f-bb24-322c7f499c0a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("51d49c85-6fa6-4757-8619-8aa2d7b6570d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5e11bd2a-99f4-471a-9be8-439fcb461f78"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("60e9c031-96ed-401f-820d-27dfb3c55b54"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("82c34944-08ab-4ea0-8577-16a15d3cc948"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a064e38b-3944-4cf6-a51c-5476d1fc449c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a6d23da2-70b5-4645-825c-ecae432776e1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a770746e-6252-4e8b-942f-8f680f5c96f1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c57ba40a-49d4-4500-a3d9-5c4bb6b58c94"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("e5023ca0-5df8-446c-bef3-a16f6d534f15"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("406bb3a9-5c38-41c4-85ff-3667245eab32"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("6966acf5-3e2a-4a80-9d47-20b8c60160a1"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("69c080f9-3f05-4bb8-b710-83de405ef82b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("ca9b7b43-b191-42b1-b842-858a1ef6953c"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("e8f5f6f8-2594-4b3d-b652-327cc8c6fe31"));

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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400af917-5dc8-45ba-aab6-afa4d423e726", false, "AQAAAAEAACcQAAAAEBFfLYgvQmrkIpQgTBiETwIeMTRtIJlTSAneo/qEZnAmyGDE4hvuRJTJWaN0Bteszg==", "2f85c26e-5d59-453e-ac68-7078b8b2cdfd" });

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
    }
}
