using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class Shippers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 57, 0, 128, DateTimeKind.Local).AddTicks(8146), new Guid("dbfc1707-6dad-4601-b563-114598a02f25"), 5641.44m, (short)89 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 123, DateTimeKind.Local).AddTicks(9129), new Guid("9528c5aa-3b3e-46cd-83b9-000d6b7496ff") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 123, DateTimeKind.Local).AddTicks(9264), new Guid("cfe7e4bf-0788-410c-9775-309b17b7eb0f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 123, DateTimeKind.Local).AddTicks(9305), new Guid("75dbf7aa-de92-45e4-aef7-9d3b23d0be1b") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(1980), new Guid("deb270a1-8870-44a2-8728-d6d71fe261f1"), "Fish", 4911.97m, (short)55 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2334), new Guid("f4b6c28c-6c7c-4208-826d-eaa917bbc854"), "Cheese", 1116.81m, (short)63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2415), new Guid("7ffcbc5d-7d12-4045-b756-8f83e1e2b0d5"), "Sausages", 3629.78m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2484), new Guid("c86c33ae-21ad-4f3d-95a4-07853addd2d8"), "Soap", 3470.58m, (short)64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2547), new Guid("ed2e48f8-8724-4920-887f-54cf3b3a8800"), 3334.94m, (short)30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2615), new Guid("34affa34-f825-495b-ab3b-d63a971cac38"), "Tuna", 1740.20m, (short)81 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2678), new Guid("3e5e4291-d18e-4e4d-9ad2-337ee316a5fa"), "Salad", 4276.46m, (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2740), new Guid("2cbca052-5b9f-485c-bd75-8345872c35d1"), "Keyboard", 1340.38m, (short)93 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2821), new Guid("0dc1c59b-1b2c-4e71-9f76-e6ed3c743f6e"), "Car", 2988.98m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2964), new Guid("a0eceb88-94ba-4a1f-b29e-cf560ab6faa2"), "Shoes", 460.06m, (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3045), new Guid("14bbd48c-c15b-4bc3-b272-c339d0b90b4b"), "Computer", 6694.34m, (short)54 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3109), new Guid("ade290ac-e1e4-4d2e-b897-845136f0c507"), "Hat", 5913.24m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3170), new Guid("ea5aa93f-2e07-4407-9cd9-0b4f229765a9"), "Fish", 6597.83m, (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3231), new Guid("42c522d3-c992-43e5-9f49-1d153e3e72ab"), "Sausages", 1646.80m, (short)7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3291), new Guid("c99c6eb4-b0ca-45d7-ad82-3ea040466164"), "Car", 2559.91m, (short)92 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3351), new Guid("c3ba79b6-246a-4ded-ac5d-924bfb769754"), "Towels", 8416.93m, (short)91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3417), new Guid("fc4d7dce-ee37-4554-bdf2-c0a8f852ce2f"), "Pizza", 7818.21m, (short)28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3482), new Guid("ea70d2b4-f9eb-4933-9c2a-f19614bfeaca"), "Sausages", 5564.99m, (short)13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3544), new Guid("e5b41a01-769b-41a7-9d09-ac96d9ad5b79"), "Shoes", 8687.44m, (short)55 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3603), new Guid("eaf2ce4c-3a6b-48fe-8e6b-a84c46c34570"), "Pants", 1624.20m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(6035), new Guid("251005ad-444e-404e-a596-cb51329aa3f3") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(6090), new Guid("d4a3e6f1-c40c-43d7-8620-1fde22930e50") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(6123), new Guid("f1812691-7cbe-44b9-a076-f7ce2700de4d") });
        }
    }
}
