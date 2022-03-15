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
            try
            {
                var product = _context.Products.Where(p => p.ProductId.Equals(productId)).FirstOrDefault();
            if(product == null)
            {
                throw new Exception("At DeleteProduct() of ProdutCategoy: Can't find product you want to remove");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"At DeleteProduct() of ProductService: {ex.Message}");
            }
        }

        public async Task<int> UpdateProduct(int productId, Product product)
        {
            return 1;
        }

        public IQueryable<Product> GetAllProductAndPage()
        {
            try
            {
                var product = from p in _context.Products select p;
                return product;
            }
            catch(Exception ex)
            {
                throw new Exception($"At GetAllProductAndPage() of ProductService: {ex.Message}");
            }
            
        }
        
        public IQueryable<Product> GetAllProductByNameAndPage(string productName)
        {
            try
            {
                var product = _context.Products.Where(p => p.ProductName == productName);
                return product;
            }
            catch(Exception ex)
            {
                throw new Exception($"At GetAllProductByNameAndPage() of ProductService: {ex.Message}");
            }
            
        }

        public IQueryable<Product> GetAllProductByCategoryAndPage(string productCategoryName)
        {
            try
            {
                var productByCategory = from p in _context.Products 
                          join c in _context.Categories 
                          on p.CateId equals c.CategoryId
                          where c.CategoryName == productCategoryName
                          select p;

                return productByCategory;
            }
            catch(Exception ex)
            {
                throw new Exception($"At GetAllProductByCategoryAndPage() of ProductService: {ex.Message}");
            }
            
        }


        public Product GetProductById(string productId)
        {
            try
            {
                var product =  _context.Products.Where(p => p.ProductId.Equals(productId)).FirstOrDefault();
                return product;
            }
            catch(Exception ex)
            {
                throw new Exception($"At GetProductById() of ProductService: {ex.Message}");
            }
            
        }
    }
}