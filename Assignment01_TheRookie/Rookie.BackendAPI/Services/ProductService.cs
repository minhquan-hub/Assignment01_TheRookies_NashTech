using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Models;
using Rookie.BackendAPI.Services.InterfaceServices;

namespace Rookie.BackendAPI.Services
{

    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<int> CreateProduct(Product product)
        {
            return 1;
        }

        [HttpDelete]
        public async Task<int> DeleteProduct(int productId)
        {
            var product = _context.Products.Where(p => p.ProductId == productId).FirstOrDefault();
            if(product == null)
            {
                Console.WriteLine("Can't find product you want to remove");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        [HttpPut]
        public async Task<int> UpdateProduct(int productId, Product product)
        {
            return 1;
        }

        [HttpGet]
        public async Task<Product> GetAllById(int productId)
        {
            var product = _context.Products.Where(p => p.ProductId == productId).FirstOrDefault();
            return product;
        }

        [HttpGet]
        public Task<IQueryable<Product>> GetAllByName(string productName)
        {
            var product = _context.Products.Where(p => p.ProductName == productName);
            
            return Task.FromResult(product);
        }
    }
}