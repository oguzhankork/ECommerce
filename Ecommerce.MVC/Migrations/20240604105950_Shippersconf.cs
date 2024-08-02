using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class Shippersconf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 965, DateTimeKind.Local).AddTicks(3215), new Guid("e3dd5ef3-14a4-473b-b5b9-1f502f67b637") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 965, DateTimeKind.Local).AddTicks(3346), new Guid("b9027090-6508-4ef5-8836-8ce4f97a258e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 965, DateTimeKind.Local).AddTicks(3389), new Guid("e0cdfeee-8c01-4604-b1c0-154102808f49") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(1909), new Guid("53c80123-b03c-4ab1-9a24-8f3c04effb21"), "Salad", 7553.15m, (short)44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2280), new Guid("dac24d41-0fec-423b-bae1-c2b81e65ee77"), "Chicken", 754.83m, (short)2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2364), new Guid("cf0b5f8e-dee1-42df-bba5-97851330147d"), "Car", 7817.35m, (short)63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2433), new Guid("5c5e60de-5e3c-4355-8f07-f82c331ee7f3"), "Bacon", 6680.19m, (short)60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2499), new Guid("faf79201-7883-46ce-8dff-422fb548c54f"), "Mouse", 3316.89m, (short)33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2569), new Guid("ef542c1f-4d21-495f-91ef-c40df5494806"), "Table", 8195.61m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2649), new Guid("b78a7c91-98bb-46ea-b9ff-5bd371b808f0"), "Fish", 9968.96m, (short)7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2768), new Guid("b92f3905-cc46-485c-b20c-92642b86d55b"), "Car", 6526.22m, (short)72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2838), new Guid("5a689863-4e38-4920-9855-e164cbf2ae90"), "Tuna", 3261.42m, (short)16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2903), new Guid("2148fb4e-4171-4f74-bfcd-89aaec2995a7"), "Mouse", 4593.74m, (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(2968), new Guid("e919bd9d-c79b-42e3-b231-4b1b31d26479"), "Keyboard", 308.65m, (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(3030), new Guid("37ad50c3-d031-4c69-8b8c-1964f2a38af4"), "Towels", 6512.24m, (short)1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(3091), new Guid("fa30317f-c14c-4beb-973c-b1a4592ee7d7"), "Soap", 500.45m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(3153), new Guid("9c793d07-44c1-4561-aea9-fdf691413327"), "Sausages", 4226.53m, (short)82 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(3219), new Guid("56986f51-c93f-4e80-b0cd-41017fd7f510"), "Chair", 7162.40m, (short)20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(3282), new Guid("26d1d3a9-0978-40d5-b6e5-8232fa924841"), "Shoes", 4906.77m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(3344), new Guid("26dcdf53-c89b-46b7-878f-a797db8914e3"), "Gloves", 5421.45m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(3408), new Guid("71c18527-360a-40ec-94d8-7288a745e8ef"), "Shirt", 3439.23m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(3470), new Guid("c58ad336-687d-4268-a919-41637b04a89e"), "Table", 2399.39m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(3530), new Guid("4594cfa1-49f4-484d-b78b-adaa9adc9ee8"), "Soap", 8204.87m, (short)62 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(6173), new Guid("62a6ca75-6837-4e3a-825f-ea292ec787e8") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(6290), new Guid("b8d406c0-a17b-41e6-b5d2-98eaaea73a59") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 59, 49, 971, DateTimeKind.Local).AddTicks(6335), new Guid("ce1b9a25-c0a7-4cc7-b20d-c520810989d7") });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 125, DateTimeKind.Local).AddTicks(1366), new Guid("9d8808b8-4aeb-4534-a187-9ea2cddc4263") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 125, DateTimeKind.Local).AddTicks(1508), new Guid("c59ce867-7948-42b0-9f47-f5ee970cec97") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 125, DateTimeKind.Local).AddTicks(1551), new Guid("004866af-c652-47d8-b677-f8874330fe10") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(7559), new Guid("362e9d3d-dec2-40ff-862f-ed0d2b54bb19"), "Hat", 7149.72m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(7938), new Guid("6fa74534-dd31-40d2-9811-bc69b5209623"), "Pants", 9286.06m, (short)70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8017), new Guid("f6352eef-b6a1-470e-8011-e7c78272f5e8"), "Chicken", 187.51m, (short)54 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8085), new Guid("e780606e-b746-491a-af4d-a40ac62463a3"), "Hat", 5846.65m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8146), new Guid("dbfc1707-6dad-4601-b563-114598a02f25"), "Car", 5641.44m, (short)89 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8209), new Guid("9447d500-e016-491c-97ca-8546f65c3d28"), "Salad", 4301.36m, (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8273), new Guid("46578090-aa5d-44a9-9511-1f4855a624e4"), "Shirt", 7242.06m, (short)58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8332), new Guid("45e42e3f-da8c-4602-8c7d-0785721cd33b"), "Chicken", 7284.07m, (short)74 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8412), new Guid("c8ce807f-c49e-428a-85f1-e7989848334c"), "Mouse", 3064.48m, (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8474), new Guid("a5fcbd58-035d-406e-b061-1b10b66bc49f"), "Ball", 2521.53m, (short)83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8535), new Guid("18b1f1d3-340a-4f5f-a8b6-35385422e6eb"), "Towels", 2734.82m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8595), new Guid("da34d769-be48-41aa-9e22-e88b3b5ef1cd"), "Cheese", 1848.19m, (short)2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8652), new Guid("0f6778c1-30c1-45cd-9fb6-2e483ccd29e9"), "Chicken", 8242.52m, (short)90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8711), new Guid("04c2a248-521b-4b61-b61a-795961e89af8"), "Cheese", 7083.73m, (short)14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8768), new Guid("0ff366f6-e9ff-4697-b22f-e45becc85ae6"), "Ball", 9342.62m, (short)57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8882), new Guid("5090b515-a6be-46c8-9e19-c14364f8a4fc"), "Bacon", 9310.48m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8951), new Guid("64430e5b-9877-4900-b425-faae2dc4fefe"), "Fish", 3088.76m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(9014), new Guid("d7d21c7b-f7da-4e25-a727-aa3830053605"), "Gloves", 5461.34m, (short)44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(9074), new Guid("55566725-c24d-4fdd-a1bc-220593ef16b0"), "Car", 1735.50m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(9132), new Guid("31391bc0-d656-4c72-b563-fe8469962f66"), "Mouse", 5917.80m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 129, DateTimeKind.Local).AddTicks(1583), new Guid("724f6151-c9ec-4b70-8fdd-994e6a31aaaa") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 129, DateTimeKind.Local).AddTicks(1641), new Guid("11b4a7af-2b21-44d7-a435-dc9287cdb567") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 129, DateTimeKind.Local).AddTicks(1675), new Guid("68a359a3-b662-4d5a-9d49-2d354f1892e0") });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
