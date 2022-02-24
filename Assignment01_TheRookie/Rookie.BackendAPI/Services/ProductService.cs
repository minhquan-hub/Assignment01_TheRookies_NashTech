using System;
using System.Collections.Generic;
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

        public async Task<int> CreateProduct(Product product)
        {
            return 1;
        }

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

        public async Task<int> UpdateProduct(int productId, Product product)
        {
            return 1;
        }

        public async Task<Product> GetAllById(int productId)
        {
            var product = _context.Products.Where(p => p.ProductId == productId).FirstOrDefault();
            return product;
        }

        public async Task<IQueryable<Product>> GetAllByNameAndPage(string productName)
        {
            var product = _context.Products.Where(p => p.ProductName == productName);
            
            return await Task.FromResult(product);
        }

        public List<Product> GetAllByName(string productName)
        {
           var product = _context.Products.Where(p => p.ProductName == productName).ToList();
           return product;
        }

        public List<Product> GetAllByCategory(string productCategory)
        {
            var product = (from p in _context.Products 
                          join c in _context.Categories 
                          on p.CateId equals c.CategoryId
                          where c.CategoryName == productCategory
                          select p).ToList();

            return product;
        }
    }
}