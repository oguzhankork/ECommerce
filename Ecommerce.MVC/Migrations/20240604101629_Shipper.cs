using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class Shipper : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(2547), new Guid("ed2e48f8-8724-4920-887f-54cf3b3a8800"), "Car", 3334.94m, (short)30 });

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
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 16, 29, 127, DateTimeKind.Local).AddTicks(3482), new Guid("ea70d2b4-f9eb-4933-9c2a-f19614bfeaca"), 5564.99m, (short)13 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 780, DateTimeKind.Local).AddTicks(7331), new Guid("dd0b8091-c12c-436f-a2d9-467f4f2de09b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 780, DateTimeKind.Local).AddTicks(7458), new Guid("d6d3b056-0889-48e4-b645-7c123f9db86c") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 780, DateTimeKind.Local).AddTicks(7501), new Guid("8fac8ded-9987-447b-be4f-76329f645db2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(7481), new Guid("7730502f-a9ec-4a78-a712-c443b64d90c3"), "Gloves", 5972.00m, (short)20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(7788), new Guid("86aab552-d9d1-4bda-af72-f743261e8e79"), "Soap", 2263.33m, (short)53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(7869), new Guid("716f6b84-e90d-431a-82fa-d125d369dd20"), "Pants", 7039.66m, (short)23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(7936), new Guid("0ca0edfc-7419-48bd-9303-8fdb42c15a32"), "Bacon", 9102.85m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8059), new Guid("27351e28-d9b0-42ab-a7de-3c9c2bc2a5a8"), "Computer", 8419.78m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8138), new Guid("4d131dc2-0677-472c-99e8-c4669ad3f22a"), "Keyboard", 5063.52m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8205), new Guid("c17f43ad-ca64-47aa-b65a-793d164fed73"), "Pants", 7191.66m, (short)11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8267), new Guid("ae99125b-e60c-46c1-8580-04f1d532f36f"), "Shoes", 506.06m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8345), new Guid("434f7203-bad1-4c30-ae77-a124198c3eb6"), "Chair", 9121.87m, (short)70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8411), new Guid("5e937381-cd2c-4d97-89bc-f754f0fdd6fa"), "Chicken", 3330.98m, (short)54 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8475), new Guid("2a7e50c4-94dd-4f9a-8207-a4dc638f5211"), "Bike", 3053.32m, (short)64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8537), new Guid("3a58576d-40d8-4d90-9572-2d01a6b57455"), "Ball", 6161.87m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8597), new Guid("3d49c505-0176-4a7e-be83-37c8ce09e8e8"), "Pants", 641.44m, (short)29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8657), new Guid("7700e67b-619e-43bc-b18b-b27ab0daf76c"), "Chips", 5670.00m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8719), new Guid("15a8c8b8-8756-4227-980e-a40910910bb5"), "Soap", 6182.73m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8780), new Guid("2d3c7caf-c28a-41bc-a658-7d549646dc77"), "Soap", 2732.77m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8846), new Guid("9b918f3a-6b2b-4599-a7aa-cc57dddb5282"), "Cheese", 4320.79m, (short)33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(8910), new Guid("5bfa33ee-c8d0-49ce-93c4-68d7f092f05f"), 3674.45m, (short)71 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(9022), new Guid("2f5f6a11-4751-4735-9742-128d1772a21f"), "Table", 228.20m, (short)27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 783, DateTimeKind.Local).AddTicks(9093), new Guid("038dc14e-7fa4-4f7b-8339-1367913379bb"), "Chair", 2975.03m, (short)96 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 784, DateTimeKind.Local).AddTicks(1239), new Guid("2e8da789-fec4-4ba7-af74-3251f8245a60") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 784, DateTimeKind.Local).AddTicks(1299), new Guid("d68b05c1-3302-48df-b8d3-25ccdf350fd2") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 47, 18, 784, DateTimeKind.Local).AddTicks(1334), new Guid("2102c24f-03d3-42ff-aaf7-4b834500ff47") });
        }
    }
}
