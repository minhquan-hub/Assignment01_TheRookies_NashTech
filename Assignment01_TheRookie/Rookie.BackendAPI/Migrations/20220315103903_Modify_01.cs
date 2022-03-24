using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.BackendAPI.Migrations
{
    public partial class Modify_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "Category");
        }
    }
}
