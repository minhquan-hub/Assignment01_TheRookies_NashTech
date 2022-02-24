using System;
using Microsoft.EntityFrameworkCore;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Data.SeedData {
    public static class ProductDataInitializer {
        public static void SeedProductData(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Product>().HasData(
                new Product{
                    ProductId = 1,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = 1 
                },
                new Product{
                    ProductId = 2,
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = 2
                },
                new Product{
                    ProductId = 3,
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = 4
                },
                new Product{
                    ProductId = 4,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 5,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = 1 
                },
                new Product{
                    ProductId = 6,
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = 2
                },
                new Product{
                    ProductId = 7,
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = 4
                },
                new Product{
                    ProductId = 8,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 9,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = 1 
                },
                new Product{
                    ProductId = 10,
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = 2
                },
                new Product{
                    ProductId = 11,
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = 4
                },
                new Product{
                    ProductId = 12,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 13,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = 1 
                },
                new Product{
                    ProductId = 14,
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = 2
                },
                new Product{
                    ProductId = 15,
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = 4
                },
                new Product{
                    ProductId = 16,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 17,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = 1 
                },
                new Product{
                    ProductId = 18,
                    ProductName = "Ginger",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 24,
                    CateId = 2
                },
                new Product{
                    ProductId = 19,
                    ProductName = "Celery",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 30,
                    CateId = 4
                },
                new Product{
                    ProductId = 20,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 21,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 22,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 23,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 24,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 25,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 26,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 27,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 28,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 29,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 30,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 31,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 32,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 33,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 34,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 35,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                },
                new Product{
                    ProductId = 36,
                    ProductName = "Mint",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = 1
                }
            );
        }
    }
}