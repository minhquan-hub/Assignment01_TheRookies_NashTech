using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.BackendAPI.Migrations
{
    public partial class Modify_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CateId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Category",
                type: "ntext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "category_id", "category_name", "description" },
                values: new object[,]
                {
                    { 1, "Vegatables", "Vegetables are parts of plants that are consumed by humans or other animals as food" },
                    { 2, "Fruits", "a fruit is the seed-bearing structure in flowering plants that is formed from the ovary after flowering" },
                    { 3, "Juice", "Juice is a drink made from the extraction or pressing of the natural liquid contained in fruit and vegetables" },
                    { 4, "Dried", "Dried fruit is fruit from which the majority of the original water content has been removed either naturally, through sun drying, or through the use of specialized dryers or dehydrators" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "product_id", "CateId", "description", "expiry_date", "manufacturing_date", "price", "product_name" },
                values: new object[,]
                {
                    { 1, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { 4, 1, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { 2, 2, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { 3, 4, "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CateId",
                table: "Product",
                column: "CateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CateId",
                table: "Product",
                column: "CateId",
                principalTable: "Category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CateId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CateId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "product_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CateId",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Category",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldNullable: true);
        }
    }
}
