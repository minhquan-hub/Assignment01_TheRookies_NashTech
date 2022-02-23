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
                }
            );
        }
    }
}