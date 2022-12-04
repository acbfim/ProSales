using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSales.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductSale",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserUpdatedId",
                table: "ProductSale",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3540), new Guid("450331bc-f8b3-46cf-b631-79ad682b4f29") });

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExternalId",
                value: new Guid("698425c8-3be1-4712-ab0a-477f017c7ae0"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExternalId",
                value: new Guid("b32f827a-35b3-4d8b-8491-e0a670211e7a"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExternalId",
                value: new Guid("5268b013-ec8c-4977-8323-0da827350001"));

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3490), new Guid("52540f3a-ef91-4dd6-9824-ccd7d3d5a49c") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3510), new Guid("147eaa04-cd31-4ab0-af6b-39fa2e696c09") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3520), new Guid("9bf98eec-8e82-42d9-b7ee-5d6cbcd8f796") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3180), new Guid("ea946034-fb97-4d27-bc15-15fee6ee6b7c") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3230), new Guid("3fbbe05e-6d52-4f97-9cc7-7f328b222ff5") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3250), new Guid("1b9cffd9-6e5c-49af-98dd-e0a1166547ce") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3260), new Guid("af9a346f-ee70-41f9-bb12-42ff5bea8d42") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3270), new Guid("f9e4daf5-b2eb-49de-a0bb-5c2177341bbf") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3280), new Guid("11363c84-a69a-4dfc-a539-4bdaa2f2d542") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3290), new Guid("88f26f9e-5910-4a7d-b5c9-47b1d52a4f51") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3310), new Guid("32e050a9-0d78-404b-be11-94c3020dceaa") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3560), new Guid("7ecc3ab3-897d-48be-bc28-369d47c26ac7") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3580), new Guid("f0d2cbab-8ff5-4b17-a50b-8ab54d7b356a") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3590), new Guid("0498756b-3792-41d8-9e75-26f97a7f20b5") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3400), new Guid("81621a1d-d8c0-4a9e-ab95-49b2f92c0540") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3410), new Guid("293959c5-18bf-41e9-b8ac-9f12a56a92c2") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3420), new Guid("078651e2-7073-47c1-8f7f-495331f41c46") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3430), new Guid("3067fee4-6a36-4113-bf27-9bd948d52bc0") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3450), new Guid("c3b45e97-9af3-4b07-adc3-8612b1e22880") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3460), new Guid("3973e4a7-e2c4-4c1e-b41c-048ecb3cd10b") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3470), new Guid("911791d9-f224-4bcd-ac14-e4b18744f918") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3610), new Guid("eea385e1-7051-4220-8fc1-2a13f9c96491") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 3, 37, 2, 145, DateTimeKind.Local).AddTicks(3630), new Guid("9ed07ad8-1132-4c33-8e43-aa6721197e22") });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_UserUpdatedId",
                table: "ProductSale",
                column: "UserUpdatedId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSale_AspNetUsers_UserUpdatedId",
                table: "ProductSale",
                column: "UserUpdatedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSale_AspNetUsers_UserUpdatedId",
                table: "ProductSale");

            migrationBuilder.DropIndex(
                name: "IX_ProductSale_UserUpdatedId",
                table: "ProductSale");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductSale");

            migrationBuilder.DropColumn(
                name: "UserUpdatedId",
                table: "ProductSale");

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(870), new Guid("d35f72ff-2cb0-447f-9e71-fca6556561f7") });

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExternalId",
                value: new Guid("5abb49ac-500e-4f40-9951-e8b556c32cd9"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExternalId",
                value: new Guid("52220b8b-99b3-482a-90c9-0667318d8b78"));

            migrationBuilder.UpdateData(
                table: "CalculationType",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExternalId",
                value: new Guid("7044025f-7b49-4e72-b59d-f5bf2a0e0915"));

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(820), new Guid("d56dac24-bac7-442d-9e70-7dd349393e9c") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(840), new Guid("36e121dc-b0b5-42ef-b43e-1df3bfcc3334") });

            migrationBuilder.UpdateData(
                table: "CoinType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(850), new Guid("ff12fded-31a6-4bcf-abec-54dc41211b9a") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(510), new Guid("f13c71d3-d153-4881-8a49-1699387d3ef8") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(570), new Guid("b1e8993d-4447-4e88-993e-ef8331e9e7fb") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(580), new Guid("e15ec82b-307c-4cf5-b0bb-a1987f4b4a07") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(590), new Guid("01bd1779-77d8-419b-919b-5861de7bd9d0") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(600), new Guid("d7d6598d-34d1-4736-b6ac-45b1cd2f47cb") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(610), new Guid("9ddc1d49-a1d9-444d-886c-6d6be1cf2f6b") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(630), new Guid("43a4d1f1-9759-47a8-8aa2-b482114350f4") });

            migrationBuilder.UpdateData(
                table: "ContactType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(640), new Guid("eedd9150-d883-4552-a007-71dc670fa70d") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(910), new Guid("aff22554-1841-413d-b920-28eeeca07c73") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(930), new Guid("393ee895-46d3-4fc1-94f6-4721b5e1e82b") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(940), new Guid("e2328040-1cd2-4559-9ecb-71f5c332c828") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(720), new Guid("0fec0636-0a25-4433-bcdd-de2fddd7485e") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(740), new Guid("3e4247be-f60d-471e-bf5f-d41e2dc63b22") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(750), new Guid("3465a010-8ab3-4df1-a234-ab7c093207d2") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(760), new Guid("f3e11a82-8274-43f9-9c8a-b0d5558cfea1") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(780), new Guid("63f45de2-2569-48da-a1ae-bc3f383c2dba") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(790), new Guid("8b23e4c2-5575-45e7-b2b4-6c520d55e3cc") });

            migrationBuilder.UpdateData(
                table: "DocumentType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(800), new Guid("9c7b40d6-eb85-4b0c-87a6-7c2206fc0eb3") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(960), new Guid("651f2ee8-2631-4cb3-9926-24afd922426d") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ExternalId" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(970), new Guid("5dcf1889-8f37-4ab2-8390-11cdd4605df9") });
        }
    }
}
