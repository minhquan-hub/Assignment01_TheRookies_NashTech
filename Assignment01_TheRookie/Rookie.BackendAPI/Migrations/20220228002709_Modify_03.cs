using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.BackendAPI.Migrations
{
    public partial class Modify_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "rate_id", "ProductId", "rate_number", "user_id" },
                values: new object[] { "R1", 24, 0, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "rate_id",
                keyValue: "R1");
        }
    }
}
