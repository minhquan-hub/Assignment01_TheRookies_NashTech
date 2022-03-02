using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Models;
using Rookie.BackendAPI.Services.InterfaceServices;

namespace Rookie.BackendAPI.Services
{


    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context, IImageService imageService)
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
                throw new Exception("At DeleteProduct() of ProdutCategoy: Can't find product you want to remove");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateProduct(int productId, Product product)
        {
            return 1;
        }

        public IQueryable<Product> GetAllProductAndPage()
        {
            var product = from p in _context.Products select p;
            return product;
        }
        
        public async Task<IQueryable<Product>> GetAllProductByNameAndPage(string productName)
        {
            var product = _context.Products.Where(p => p.ProductName == productName);
            return await Task.FromResult(product);
        }

        public async Task<IQueryable<Product>> GetAllProductByCategoryAndPage(string productCategoryName)
        {
            var productByCategory = from p in _context.Products 
                          join c in _context.Categories 
                          on p.CateId equals c.CategoryId
                          where c.CategoryName == productCategoryName
                          select p;

            return await Task.FromResult(productByCategory);;
        }

        public List<Product> GetAllProductByName(string productName)
        {
           var product = _context.Products.Where(p => p.ProductName == productName).ToList();
           return product;
        }

        public Product GetProductById(int productId)
        {
            var product =  _context.Products.Where(p => p.ProductId == productId).FirstOrDefault();
            return product;
        }

        public List<Product> GetAllProductByCategory(string productCategoryName)
        {
            var product = (from p in _context.Products 
                          join c in _context.Categories 
                          on p.CateId equals c.CategoryId
                          where c.CategoryName == productCategoryName
                          select p).ToList();

            return product;
        }
    }
}