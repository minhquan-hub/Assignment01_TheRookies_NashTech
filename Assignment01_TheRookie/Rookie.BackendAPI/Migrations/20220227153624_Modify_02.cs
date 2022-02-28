using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.BackendAPI.Migrations
{
    public partial class Modify_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    image_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    image_01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_05 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.image_id);
                    table.ForeignKey(
                        name: "FK_Image_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    rate_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rate_number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.rate_id);
                    table.ForeignKey(
                        name: "FK_Rating_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "image_id", "image_01", "image_02", "image_03", "image_04", "image_05", "ProductId" },
                values: new object[,]
                {
                    { "I01", "/images/bg_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 1 },
                    { "I21", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 21 },
                    { "I22", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 22 },
                    { "I23", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 23 },
                    { "I24", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 24 },
                    { "I25", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 25 },
                    { "I26", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 26 },
                    { "I20", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 20 },
                    { "I27", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 27 },
                    { "I29", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, 29 },
                    { "I30", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, 30 },
                    { "I31", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, 31 },
                    { "I32", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, 32 },
                    { "I33", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 33 },
                    { "I34", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 34 },
                    { "I28", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, 28 },
                    { "I19", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 19 },
                    { "I18", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 18 },
                    { "I17", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 17 },
                    { "I02", "/images/bg_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 2 },
                    { "I03", "/images/bg_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 3 },
                    { "I04", "/images/product-4.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 4 },
                    { "I05", "/images/image_5.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 5 },
                    { "I06", "/images/product-8.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 6 },
                    { "I07", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, 7 },
                    { "I08", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 8 },
                    { "I09", "/images/image_5.jpg", "/images/product-4.jpg", "/images/product-6.jpg", null, null, 9 },
                    { "I10", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 10 },
                    { "I11", "/images/product-4.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 11 },
                    { "I12", "/images/product-3.jpg", "/images/product-5.jpg", "/images/product-6.jpg", null, null, 12 },
                    { "I13", "/images/product-6.jpg", "/images/product-3.jpg", "/images/product-7.jpg", null, null, 13 },
                    { "I14", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 14 },
                    { "I15", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 15 },
                    { "I16", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 16 },
                    { "I35", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 35 },
                    { "I36", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, 36 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ProductId",
                table: "Rating",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Rating");
        }
    }
}
