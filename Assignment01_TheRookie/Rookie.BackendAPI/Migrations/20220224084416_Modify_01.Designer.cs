﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rookie.BackendAPI.Data;

namespace Rookie.BackendAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220224084416_Modify_01")]
    partial class Modify_01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Rookie.BackendAPI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .HasColumnType("ntext")
                        .HasColumnName("description");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Vegatables",
                            Description = "Vegetables are parts of plants that are consumed by humans or other animals as food"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruits",
                            Description = "a fruit is the seed-bearing structure in flowering plants that is formed from the ovary after flowering"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Juice",
                            Description = "Juice is a drink made from the extraction or pressing of the natural liquid contained in fruit and vegetables"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Dried",
                            Description = "Dried fruit is fruit from which the majority of the original water content has been removed either naturally, through sun drying, or through the use of specialized dryers or dehydrators"
                        });
                });

            modelBuilder.Entity("Rookie.BackendAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("product_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CateId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasColumnName("description");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("expiry_date");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("manufacturing_date");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal")
                        .HasColumnName("price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("product_name");

                    b.HasKey("ProductId");

                    b.HasIndex("CateId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 32m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 2,
                            CateId = 2,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 24m,
                            ProductName = "Ginger"
                        },
                        new
                        {
                            ProductId = 3,
                            CateId = 4,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 30m,
                            ProductName = "Celery"
                        },
                        new
                        {
                            ProductId = 4,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 5,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 32m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 6,
                            CateId = 2,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 24m,
                            ProductName = "Ginger"
                        },
                        new
                        {
                            ProductId = 7,
                            CateId = 4,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 30m,
                            ProductName = "Celery"
                        },
                        new
                        {
                            ProductId = 8,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 9,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 32m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 10,
                            CateId = 2,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 24m,
                            ProductName = "Ginger"
                        },
                        new
                        {
                            ProductId = 11,
                            CateId = 4,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 30m,
                            ProductName = "Celery"
                        },
                        new
                        {
                            ProductId = 12,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 13,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 32m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 14,
                            CateId = 2,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 24m,
                            ProductName = "Ginger"
                        },
                        new
                        {
                            ProductId = 15,
                            CateId = 4,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 30m,
                            ProductName = "Celery"
                        },
                        new
                        {
                            ProductId = 16,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 17,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 32m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 18,
                            CateId = 2,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 24m,
                            ProductName = "Ginger"
                        },
                        new
                        {
                            ProductId = 19,
                            CateId = 4,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 30m,
                            ProductName = "Celery"
                        },
                        new
                        {
                            ProductId = 20,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 21,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 22,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 23,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 24,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 25,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 26,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 27,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 28,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 29,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 30,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 31,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 32,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 33,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 34,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 35,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        },
                        new
                        {
                            ProductId = 36,
                            CateId = 1,
                            Description = "Vegetable is very healthy",
                            ExpiryDate = new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManufacturingDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            ProductName = "Mint"
                        });
                });

            modelBuilder.Entity("Rookie.BackendAPI.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Rookie.BackendAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Rookie.BackendAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rookie.BackendAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Rookie.BackendAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rookie.BackendAPI.Models.Product", b =>
                {
                    b.HasOne("Rookie.BackendAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}