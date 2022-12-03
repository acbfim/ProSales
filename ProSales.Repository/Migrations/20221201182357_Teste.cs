using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSales.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Client_ClientId",
                table: "Document");

            migrationBuilder.AlterColumn<long>(
                name: "ClientId",
                table: "Document",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "FormTeste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FormTesteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTeste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormTeste_FormTeste_FormTesteId",
                        column: x => x.FormTesteId,
                        principalTable: "FormTeste",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8470), new Guid("c2c7694f-090b-481b-8691-ea0db8c82e6e") });

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExternalId",
                value: new Guid("3f3ce9a7-e44b-4a15-8cce-d36e4decb28e"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExternalId",
                value: new Guid("5bc826c6-87ae-470a-a3ce-73b7d85203d0"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExternalId",
                value: new Guid("c6a167ed-1595-42c5-bb31-8aa2b7f4bd15"));

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8410), new Guid("6822baae-4fd2-433f-913b-6871524da88f") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8420), new Guid("5adb4e25-9d1c-47ca-842e-e36f2573b086") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8440), new Guid("8830c4e9-e12b-4007-adba-18f1f14132bf") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8040), new Guid("8396252f-25be-4702-a4ff-4e72aeb8f98c") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8100), new Guid("535bd564-cbf9-4b70-bd8d-b91d9b0e386b") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8130), new Guid("89441dc0-6d48-411f-97e2-e7d571219f6c") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8140), new Guid("ce72e22f-46fb-4864-948f-436af7e932e9") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8150), new Guid("804502ab-e54d-4d61-967c-12b3e55455ea") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8160), new Guid("7e00e85c-1348-464d-b8a3-8c7b5ff06943") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8170), new Guid("83c01d00-f78a-491b-8b4e-bb01960e8c61") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8190), new Guid("03b8d549-eea0-42a7-9d98-941456b6e9b8") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8490), new Guid("e0f07220-1c0a-4ef5-9dfe-90a4e86e235e") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8510), new Guid("2953afe9-448f-4dfa-aa86-b76ad7c5377d") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8520), new Guid("cc64eb3f-f583-465a-ba16-6ad5ac60b3ad") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8300), new Guid("b2076ea7-04f5-44ea-9a72-2627db14c385") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8320), new Guid("1db3c1f3-eae0-4145-b309-0a85700d7ef9") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8330), new Guid("fe850045-64b3-4203-a0d6-ca82944c0a4c") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8340), new Guid("6c85a238-1ac0-4d2d-98ac-96321adf9030") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8350), new Guid("5abefd2b-c8db-4d52-9397-ea58fdf03077") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8360), new Guid("c41e2d40-574b-4622-b675-5a09aeb864b2") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8380), new Guid("d40cfd5d-48ca-4201-8a17-fe81175551a8") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8550), new Guid("28c1385a-ee2d-4be4-a304-a87c6b7b9b2b") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 23, 57, 557, DateTimeKind.Local).AddTicks(8560), new Guid("95de69a8-874b-4912-bad9-d5c024c63d75") });

            migrationBuilder.CreateIndex(
                name: "IX_FormTeste_FormTesteId",
                table: "FormTeste",
                column: "FormTesteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Client_ClientId",
                table: "Document",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Client_ClientId",
                table: "Document");

            migrationBuilder.DropTable(
                name: "FormTeste");

            migrationBuilder.AlterColumn<long>(
                name: "ClientId",
                table: "Document",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2340), new Guid("b40e9059-54c9-4902-b483-ee38c83346d4") });

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExternalId",
                value: new Guid("0c3908e3-3457-4a24-a7d7-7e7ba5e43ccd"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExternalId",
                value: new Guid("10431bb1-5c47-4a69-9797-e3e7f274389c"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExternalId",
                value: new Guid("765b88cc-73fe-4f28-889d-3adf95bcfbcc"));

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2280), new Guid("031f0834-1fd4-439f-868b-df0bbe3173b2") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2300), new Guid("50501be9-21d0-4e34-8b49-a1f1fff34734") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2310), new Guid("2ee13282-3bdf-4b76-b26d-2b8b5dab90ed") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(1930), new Guid("202e9fc3-e051-43e2-a1fd-c31f107356d9") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(1980), new Guid("99f4b886-f0eb-4a99-bba7-891dd7bd9524") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(1990), new Guid("9687d201-20d9-4c81-91b5-7267188d9259") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2000), new Guid("9bda0162-dd12-41f0-bc14-2e59723c653a") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2020), new Guid("8fff77b1-1a9c-4fa7-a663-caaa1c44a03e") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2030), new Guid("615a18d7-fc43-4a0d-9091-9d0000facb7e") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2040), new Guid("d43977bf-082e-4258-ad5c-25da6cf273ab") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2050), new Guid("2830b12a-c885-4267-8008-72a3cc8f376f") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2360), new Guid("db82b592-1e6e-4d36-b12b-e3dd7b0be9d4") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2380), new Guid("2a1cd8aa-69fd-4170-a29d-10d2539ababb") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2390), new Guid("eae5521c-cab9-4a98-b64c-639d08426606") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2180), new Guid("8ad6df2d-a79b-4ad6-aa96-70834d6e6596") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2200), new Guid("ae023b5f-8a07-4454-b829-fe32b1a447c6") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2210), new Guid("376743b3-0609-44ab-b367-c29c08482092") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2220), new Guid("21adfa92-ea46-403f-a8cb-7fb26f65ae03") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2230), new Guid("eca978a2-5304-4d7d-8bea-5813722d108a") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2250), new Guid("bd3846f4-9888-4cef-9db3-b6fbed5593eb") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2260), new Guid("ce1dbadc-dc82-4460-84b2-1a0d5970f0bd") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2410), new Guid("e09209d4-ee99-4f26-9fdb-f2f6cde54780") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 24, 43, 811, DateTimeKind.Local).AddTicks(2430), new Guid("69a00ef6-4ab6-4fdb-9ac7-d94975c8cb23") });

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Client_ClientId",
                table: "Document",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id");
        }
    }
}
