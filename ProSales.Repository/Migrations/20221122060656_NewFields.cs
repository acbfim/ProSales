using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSales.Repository.Migrations
{
    /// <inheritdoc />
    public partial class NewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Brand",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId", "IsActive" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(730), new Guid("73deb6ca-664a-4efc-8dd3-338059df8ba7"), true });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(300), new Guid("20dba4ac-ff83-46a0-9462-e4ef14ea9047") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(370), new Guid("87872a2a-12c4-4e85-83bb-6fb15ab3970f") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(380), new Guid("2306d6cc-7772-4b64-bbca-75d1d332b828") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(390), new Guid("2970154d-61d4-419b-80fe-1a825042bba1") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(400), new Guid("c82ad557-2e42-4e03-81e3-7f95e5146fec") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(420), new Guid("dc736d73-5e48-4350-a245-1aeb2b8123ed") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(430), new Guid("f59715df-830c-4f97-ba9d-dc3cf8a7081c") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(490), new Guid("56b88e83-290a-4c84-8116-17736760b5e9") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(760), new Guid("6825c7b4-7417-4aab-adb4-c23fc005f3ed") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(770), new Guid("460276af-07b1-4d15-a272-b067adac9de1") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(790), new Guid("f7af3e87-c725-40b6-9944-cebdb3381795") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(580), new Guid("dc17c33c-7648-4f9f-9f9a-6cb7c0a8690f") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(590), new Guid("57c73fe2-91aa-4d11-91b7-d745f29fda84") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(610), new Guid("2db8e3e3-4bb2-490c-a826-e43b47ee6298") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(620), new Guid("3fd965e1-34e3-481b-a47c-44eea63f64d0") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(630), new Guid("ca95f230-25b2-457b-95df-0e21151d861f") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(640), new Guid("b844d756-6bae-477b-8fd3-bc7969c929b6") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(650), new Guid("027fe812-a905-49a6-b7c2-5ec9ee71e6ed") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(810), new Guid("8ee9ee18-a7e6-4783-a20a-b0ad74d84a1e") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(820), new Guid("d65f5d05-ae76-45ff-a091-9fdfff278e58") });

            migrationBuilder.UpdateData(
                table: "TypeCalculation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExternalId",
                value: new Guid("9e52dc95-627b-4519-8e36-eeddb0858c02"));

            migrationBuilder.UpdateData(
                table: "TypeCalculation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExternalId",
                value: new Guid("07550aca-0ab2-4507-a8b1-d803a3bd8a6c"));

            migrationBuilder.UpdateData(
                table: "TypeCalculation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExternalId",
                value: new Guid("03dda645-1a46-4c2f-92ad-988296fadc88"));

            migrationBuilder.UpdateData(
                table: "TypeCoin",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(680), new Guid("f41e6129-dfaa-42a9-bae6-3f4b6af87526") });

            migrationBuilder.UpdateData(
                table: "TypeCoin",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(700), new Guid("12d29c85-d00d-4388-ba52-f12147003875") });

            migrationBuilder.UpdateData(
                table: "TypeCoin",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 22, 3, 6, 56, 63, DateTimeKind.Local).AddTicks(710), new Guid("bb1aa87a-37ca-4fe1-b84d-7cf22a0494cb") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Brand");

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4510), new Guid("3a6b47ad-b2df-40bb-8005-12d4d8a798fd") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4160), new Guid("b29a45a8-ca7f-479c-96bf-5cb76385f92e") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4220), new Guid("34ab7c4b-cbb0-4fc5-b718-e874bf7afbd8") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4230), new Guid("0bd20c7d-d7dd-4be1-a92a-f089b213b95d") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4240), new Guid("09fdc9eb-c7c7-41d7-9a8d-b50fb9647523") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4250), new Guid("0163663b-e25e-470f-a6f1-046071e0ffdc") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4260), new Guid("9a41e77d-1165-4daa-b14b-082c4e076882") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4280), new Guid("e3f56a3a-40e1-48af-b68c-487c1d5c759b") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4290), new Guid("3f238a52-03a9-4f4e-8f8e-e145a1969664") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4540), new Guid("aabdf7ca-2555-4fc7-87a3-ab57e3f4b4fe") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4550), new Guid("a39422df-07db-4cf8-834f-648a96681a97") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4570), new Guid("37c4468c-c8ac-4b84-bb78-76cb69bd82a9") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4370), new Guid("3d4ef3ef-7ca8-401b-8c69-1446628f94aa") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4390), new Guid("d09671be-95d7-4bca-a19f-53a5a9faf161") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4400), new Guid("34280936-1d86-4c47-a09f-186933987545") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4410), new Guid("a5abdb9a-a210-4073-a7b3-965793f7c233") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4420), new Guid("e85feeaa-c8c8-4b71-b24e-374e89a8edb1") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4430), new Guid("6d97fbaf-1386-482a-b820-5c2c8b242df3") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4450), new Guid("8e2cac3d-a9c1-4da3-8b4f-4b7b0ec2e55d") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4590), new Guid("d9fb9dcc-7407-407a-97e3-5f5d7de0a1cd") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4600), new Guid("370f1fa6-90d1-44cb-aefb-6f005934e8bb") });

            migrationBuilder.UpdateData(
                table: "TypeCalculation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExternalId",
                value: new Guid("0d540f8b-6c20-4d1b-a208-07b4db5b9112"));

            migrationBuilder.UpdateData(
                table: "TypeCalculation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExternalId",
                value: new Guid("7cba4bdb-7d32-4033-9aff-5a878ae77bca"));

            migrationBuilder.UpdateData(
                table: "TypeCalculation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExternalId",
                value: new Guid("2028c4ab-6a88-4f18-a0de-3469531c3fe1"));

            migrationBuilder.UpdateData(
                table: "TypeCoin",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4470), new Guid("77b8ad33-6f63-4c3c-8623-e99f60c8b43f") });

            migrationBuilder.UpdateData(
                table: "TypeCoin",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4480), new Guid("c33ec2af-cd36-489a-98f6-31351220658e") });

            migrationBuilder.UpdateData(
                table: "TypeCoin",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 48, 55, 458, DateTimeKind.Local).AddTicks(4490), new Guid("971df226-e904-4d9f-9375-c2c2ce747f60") });
        }
    }
}
