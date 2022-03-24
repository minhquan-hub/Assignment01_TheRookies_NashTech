using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Rookie.BackendAPI.Models;
using Rookie.ShareClass.Dto.Product;

namespace Rookie.Testing.BackendAPITest.Mock.MockIQueryable
{
    public class FakeDataProduct 
    {
                
        public FakeDataProduct()
        {
             var data = new List<Product>
                {
                    new Product{
                    ProductId = "P4001",
                    ProductName = "Tomato",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = "C3001" 
                },
                    new Product{
                    ProductId = "P4017",
                    ProductName = "Tomato",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = "C3001" 
                },
                 new Product{
                    ProductId = "P4022",
                    ProductName = "Tomato",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId =  "P4027",
                    ProductName = "Tomato",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4005",
                    ProductName = "Tomato",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = "C3002" 
                },
                new Product{
                    ProductId = "P4008",
                    ProductName = "Tomato",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4009",
                    ProductName = "Tomato",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 32,
                    CateId = "C3002" 
                },
                new Product{
                    ProductId = "P4012",
                    ProductName = "Tomato",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                },
                new Product{
                    ProductId = "P4013",
                    ProductName = "Tomato",
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
                    ProductName = "Tomato",
                    Description = "Vegetable is very healthy",
                    ManufacturingDate = DateTime.Parse("2022-02-22"),
                    ExpiryDate = DateTime.Parse("2022-04-13"),
                    Price = 50,
                    CateId = "C3001"
                }
                }.AsQueryable();

                MockProductIQueryable  = new Mock<IQueryable<Product>>();
                MockProductIQueryable.As<IQueryable<Product>>().Setup(m => m.Provider).Returns(data.Provider);
                MockProductIQueryable.As<IQueryable<Product>>().Setup(m => m.Expression)
                .Callback(() => ExpressionCalls++)
                .Returns(data.Expression);
                MockProductIQueryable.As<IQueryable<Product>>().Setup(m => m.ElementType).Returns(data.ElementType);
                MockProductIQueryable.As<IQueryable<Product>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

                ProductIQueryable = MockProductIQueryable.Object;
        }
        public int ExpressionCalls {get; private set;}

        public IQueryable<Product> ProductIQueryable {get; set;}
        public Mock<IQueryable<Product>> MockProductIQueryable {get; set;}
                
    }
}