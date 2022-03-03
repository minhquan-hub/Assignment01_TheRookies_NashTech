using System;
using Microsoft.EntityFrameworkCore;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Data.SeedData {
    public static class ProductDataInitializer {
        public static void SeedProductData(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Product>().HasData(
                new Product{
                    ProductId = "P4001",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = "C3001" 
                },
                new Product{
                    ProductId = "P4002",
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4003",
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = "C3004"
                },
                new Product{
                    ProductId = "P4004",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4005",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = "C3002" 
                },
                new Product{
                    ProductId = "P4006",
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4007",
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = "C3004"
                },
                new Product{
                    ProductId = "P4008",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4009",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = "C3002" 
                },
                new Product{
                    ProductId = "P4010",
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4011",
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = "C3004"
                },
                new Product{
                    ProductId = "P4012",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4013",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = "C3002" 
                },
                new Product{
                    ProductId = "P4014",
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4015",
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = "C3004"
                },
                new Product{
                    ProductId = "P4016",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4017",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = "C3001" 
                },
                new Product{
                    ProductId = "P4018",
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4019",
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = "C3004"
                },
                new Product{
                    ProductId = "P4020",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4021",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4022",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4023",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4024",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4025",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4026",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId =  "P4027",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4028",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4029",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4030",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4031",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4032",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4033",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4034",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4035",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4036",
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4037",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4038",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4039",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4040",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4041",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4042",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4043",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4044",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4045",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4046",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4047",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4048",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4049",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4050",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4051",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4052",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4053",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                },
                new Product{
                    ProductId = "P4054",
                    ProductName = "Apple",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 48,
                    CateId = "C3002"
                }
            );
        }
    }
}