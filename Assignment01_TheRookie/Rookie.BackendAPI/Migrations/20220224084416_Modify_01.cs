using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.BackendAPI.Migrations
{
    public partial class Modify_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) => migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "product_id", "CateId", "description", "expiry_date", "manufacturing_date", "price", "product_name" },
                values: new object[,]
                {
                    { 5, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { 34, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 33, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 32, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 31, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 30, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 29, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 28, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 27, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 26, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 25, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 24, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 23, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 22, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 21, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 20, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 19, 4, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" },
                    { 18, 2, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { 17, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { 16, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 15, 4, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" },
                    { 14, 2, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { 13, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { 12, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 11, 4, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" },
                    { 10, 2, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { 9, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { 8, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 7, 4, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" },
                    { 6, 2, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { 35, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 36, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" }
                });

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 36);
        }
    }
}
