using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSales.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Teste2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_DiscountType_DiscountTypeId",
                table: "Product");

            migrationBuilder.AlterColumn<long>(
                name: "DiscountTypeId",
                table: "Product",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4420), new Guid("173ad0a0-2686-4ae8-a0fb-5338a2008d4f") });

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExternalId",
                value: new Guid("b6afe063-c5a7-4eac-91f5-7a3048907692"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExternalId",
                value: new Guid("295e1f8c-270f-40b8-b4b8-f19d44913451"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExternalId",
                value: new Guid("5878d0a7-1ad1-4afe-bb4e-e2a7de632f48"));

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4370), new Guid("5ce49940-ccd2-4c13-b21f-ef5823891bcd") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4380), new Guid("ded204d9-5ca1-41e4-acce-d214ef17dbae") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4400), new Guid("73c86e79-e545-4946-b859-44543a8b60ae") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4070), new Guid("5d552566-bb82-465f-a3af-cb2710e52866") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4120), new Guid("fd7c8f04-2bc8-46a8-a8f0-0478a0b633d2") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4130), new Guid("c65c6c52-7243-45cc-8c35-8c1f17611e3b") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4140), new Guid("55bc15df-2e31-4e67-99c6-8b727536fb9d") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4150), new Guid("feafe7ad-650e-491e-b335-28a3d9917236") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4160), new Guid("209bb2b7-718b-4856-a51a-1a296bdc7e30") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4180), new Guid("5622f7c5-f257-4316-9a8c-b353e21aca01") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4190), new Guid("4c38229c-7fcd-4a0d-87b1-ff52504d8c8b") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4440), new Guid("3d64f66b-640e-4304-b4f5-7b8ca4229bc6") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4460), new Guid("91bfcb5a-ab9f-41ef-b1cb-a204583434ca") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4470), new Guid("e18c7ee8-3fcb-495f-8dbe-393f0c3f75c6") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4270), new Guid("7d62651c-ac25-41b9-97e5-5c3b45427e9f") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4290), new Guid("6859a9a9-8218-471c-85cb-92d71753966e") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4300), new Guid("47198dcd-504b-48cf-97ca-01d02940bec3") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4310), new Guid("4665ec53-934b-4ef4-8e4d-b4f5227d0dd0") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4320), new Guid("9609a834-d98d-4c51-9042-bc7f26fd28da") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4330), new Guid("29baf53f-0e32-4602-81a0-11304692443d") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4350), new Guid("9298fda0-599c-4f49-8c18-4be06ba92171") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4490), new Guid("c27dd465-7bc7-4b61-a9fa-90e79632021c") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 10, 43, 522, DateTimeKind.Local).AddTicks(4510), new Guid("045a456c-2eaa-48ec-9e80-72328e0f3aae") });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_DiscountType_DiscountTypeId",
                table: "Product",
                column: "DiscountTypeId",
                principalTable: "DiscountType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_DiscountType_DiscountTypeId",
                table: "Product");

            migrationBuilder.AlterColumn<long>(
                name: "DiscountTypeId",
                table: "Product",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8360), new Guid("7b1a9d26-69a5-4396-bd3e-356720c07f4f") });

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExternalId",
                value: new Guid("a8a832c9-674d-4798-b3bc-0e7c33f3a5b5"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExternalId",
                value: new Guid("62d8c19f-8d48-4faa-a5c9-256da07b3262"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExternalId",
                value: new Guid("8ee0bdba-0fb5-4556-9d36-b9d1100bf07b"));

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8290), new Guid("cb37b9b7-79cb-4bbd-be01-d1ba5e56ef00") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8300), new Guid("37cd3e34-cc3f-4422-9ae7-73e44f9a3274") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8330), new Guid("d2874a8a-45b6-495e-ba6b-69fa97ab3838") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(7910), new Guid("b76bdd31-7599-4fe1-ad51-be48dbee8020") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(7960), new Guid("37cfc72b-b0d7-4daf-a60c-622d1ff6aaf3") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(7980), new Guid("ad6bbbeb-54d8-4a69-a09c-9cf3e86f9a4a") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(7990), new Guid("3309a02a-3012-44cc-a4f1-4092aa35278d") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8000), new Guid("d4239b01-c1de-48c4-ac22-793fe07261e4") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8010), new Guid("e437f965-a36c-4b64-be45-a82308a6a3bf") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8020), new Guid("e8d0cfbe-6d71-4c10-8ab9-03eee8b8f236") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8040), new Guid("208f9fd5-0b45-4941-88cb-a24a76888d8f") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8380), new Guid("31bc2bd5-c36c-4890-ac32-2c9e5e637b02") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8400), new Guid("71d3d212-341b-42c5-b530-37679933e143") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8410), new Guid("c1febbf6-32e2-400b-90ad-8945a88888da") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8190), new Guid("5d6ee551-c6bc-4e4c-b9c8-b8bf1b72f335") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8200), new Guid("d95e7411-868b-47af-8b91-f97515eb8b5d") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8210), new Guid("90e34213-43f9-473d-9902-ee89874d26b2") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8230), new Guid("7a40f8b8-1de3-4683-a6b2-c817846c22a9") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8240), new Guid("f6b5dfa3-2f59-4847-8d76-b889a4e7da44") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8250), new Guid("ef3b0fc7-4f13-4483-bb24-a9e7bdd05823") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8260), new Guid("70cb35e9-7125-498f-92c4-d32c2c5d327f") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8430), new Guid("62adf8d9-1760-4d58-9995-164cfa58c724") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 9, 31, 792, DateTimeKind.Local).AddTicks(8450), new Guid("d92dc291-9fe3-455d-b74a-a8a077fa2609") });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_DiscountType_DiscountTypeId",
                table: "Product",
                column: "DiscountTypeId",
                principalTable: "DiscountType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
