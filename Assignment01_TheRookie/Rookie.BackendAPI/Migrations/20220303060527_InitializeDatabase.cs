using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.BackendAPI.Migrations
{
    public partial class InitializeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    category_id = table.Column<string>(type: "varchar(10)", nullable: false),
                    category_name = table.Column<string>(type: "varchar(255)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    product_id = table.Column<string>(type: "varchar(10)", nullable: false),
                    product_name = table.Column<string>(type: "varchar(255)", nullable: false),
                    description = table.Column<string>(type: "varchar(300)", nullable: false),
                    manufacturing_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expiry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<decimal>(type: "decimal", nullable: false),
                    CateId = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CateId",
                        column: x => x.CateId,
                        principalTable: "Category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    image_id = table.Column<string>(type: "varchar(10)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(10)", nullable: false),
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
                    rate_id = table.Column<string>(type: "varchar(10)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(10)", nullable: false),
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
                table: "Category",
                columns: new[] { "category_id", "category_name", "description" },
                values: new object[,]
                {
                    { "C3001", "Vegatables", "Vegetables are parts of plants that are consumed by humans or other animals as food" },
                    { "C3002", "Fruits", "a fruit is the seed-bearing structure in flowering plants that is formed from the ovary after flowering" },
                    { "C3003", "Juice", "Juice is a drink made from the extraction or pressing of the natural liquid contained in fruit and vegetables" },
                    { "C3004", "Dried", "Dried fruit is fruit from which the majority of the original water content has been removed either naturally, through sun drying, or through the use of specialized dryers or dehydrators" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "product_id", "CateId", "description", "expiry_date", "manufacturing_date", "price", "product_name" },
                values: new object[,]
                {
                    { "P4001", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { "P4014", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { "P4018", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { "P4037", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4038", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4039", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4040", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4041", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4042", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4043", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4044", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4045", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4046", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4047", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4048", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4049", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4050", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4051", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4052", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4053", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4054", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, "Apple" },
                    { "P4003", "C3004", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" },
                    { "P4007", "C3004", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" },
                    { "P4011", "C3004", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" },
                    { "P4013", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { "P4010", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { "P4009", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { "P4006", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { "P4004", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4008", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4012", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4016", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4017", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { "P4020", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4021", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4022", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4023", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4024", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4025", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4015", "C3004", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" },
                    { "P4026", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4028", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "product_id", "CateId", "description", "expiry_date", "manufacturing_date", "price", "product_name" },
                values: new object[,]
                {
                    { "P4029", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4030", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4031", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4032", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4033", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4034", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4035", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4036", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4002", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, "Ginger" },
                    { "P4005", "C3002", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, "Mint" },
                    { "P4027", "C3001", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, "Mint" },
                    { "P4019", "C3004", "Vegetable is very healthy", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Celery" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "image_id", "image_01", "image_02", "image_03", "image_04", "image_05", "ProductId" },
                values: new object[,]
                {
                    { "I2001", "/images/bg_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4001" },
                    { "I2013", "/images/product-6.jpg", "/images/product-3.jpg", "/images/product-7.jpg", null, null, "P4013" },
                    { "I2014", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4014" },
                    { "I2018", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4018" },
                    { "I2037", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4037" },
                    { "I2038", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4038" },
                    { "I2039", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4039" },
                    { "I2040", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4040" },
                    { "I2041", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4041" },
                    { "I2042", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4042" },
                    { "I2043", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4043" },
                    { "I2044", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4044" },
                    { "I2010", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4010" },
                    { "I2045", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4045" },
                    { "I2047", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4047" },
                    { "I2048", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4048" },
                    { "I2049", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4049" },
                    { "I2050", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4050" },
                    { "I2051", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4051" },
                    { "I2052", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4052" },
                    { "I2053", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4053" },
                    { "I2054", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4054" },
                    { "I2003", "/images/bg_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4003" },
                    { "I2007", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, "P4007" },
                    { "I2011", "/images/product-4.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4011" },
                    { "I2046", "/images/product-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4046" },
                    { "I2015", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4015" },
                    { "I2009", "/images/image_5.jpg", "/images/product-4.jpg", "/images/product-6.jpg", null, null, "P4009" },
                    { "I2005", "/images/image_5.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4005" },
                    { "I2004", "/images/product-4.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4004" },
                    { "I2008", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4008" },
                    { "I2012", "/images/product-3.jpg", "/images/product-5.jpg", "/images/product-6.jpg", null, null, "P4012" },
                    { "I2016", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4016" },
                    { "I2017", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4017" },
                    { "I2020", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4020" },
                    { "I2021", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4021" },
                    { "I2022", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4022" },
                    { "I2023", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4023" },
                    { "I2024", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4024" },
                    { "I2006", "/images/product-8.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4006" },
                    { "I2025", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4025" },
                    { "I2027", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4027" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "image_id", "image_01", "image_02", "image_03", "image_04", "image_05", "ProductId" },
                values: new object[,]
                {
                    { "I2028", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, "P4028" },
                    { "I2029", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, "P4029" },
                    { "I2030", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, "P4030" },
                    { "I2031", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, "P4031" },
                    { "I2032", "/images/product-3.jpg", "/images/product-7.jpg", "/images/product-6.jpg", null, null, "P4032" },
                    { "I2033", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4033" },
                    { "I2034", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4034" },
                    { "I2035", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4035" },
                    { "I2036", "/images/image_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4036" },
                    { "I2002", "/images/bg_1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4002" },
                    { "I2026", "/images/category-2.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4026" },
                    { "I2019", "/images/product-1.jpg", "/images/product-3.jpg", "/images/product-6.jpg", null, null, "P4019" }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "rate_id", "ProductId", "rate_number", "user_id" },
                values: new object[] { "R1001", "P4004", 0, null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CateId",
                table: "Product",
                column: "CateId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ProductId",
                table: "Rating",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
