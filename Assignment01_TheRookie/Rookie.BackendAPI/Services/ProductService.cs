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
using Rookie.ShareClass.Dto.Product;

namespace Rookie.BackendAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateProduct(ProductCreateRequest productCreateRequest)
        {
            var productLast = _context.Products.OrderBy(p => p.ProductId).Last();
            var imageLast = _context.Images.OrderBy(i => i.ImageID).Last();

            if(productLast == null || imageLast == null)
            {
                throw new Exception("CreateProduct of ProductService");
            }

            var productIdNew = CreateProductId(productLast.ProductId);
            var product = new Product{
                ProductId = productIdNew,
                ProductName = productCreateRequest.ProductName,
                Description = productCreateRequest.Description,
                ManufacturingDate = productCreateRequest.ManufacturingDate,
                ExpiryDate = productCreateRequest.ExpiryDate,
                Price = productCreateRequest.Price,
                CateId = productCreateRequest.CateId
            };

            var image = new Image{
                ImageID = CreateImageId(imageLast.ImageID),
                ProductId = productIdNew,
                Image1 = productCreateRequest.ImageCreateRequest.Image1,
                Image2 = productCreateRequest.ImageCreateRequest.Image2,
                Image3 = productCreateRequest.ImageCreateRequest.Image3,
                Image4 = productCreateRequest.ImageCreateRequest.Image4,
                Image5 = productCreateRequest.ImageCreateRequest.Image5,
            };

            _context.Products.Add(product);
            _context.Images.Add(image);

            await _context.SaveChangesAsync();
        }

        public IQueryable<Product> GetAllProduct(string productName)
        {
            IQueryable<Product> product = null;
            if(!string.IsNullOrEmpty(productName))
            {
                product = from p in _context.Products
                        where (p.ProductName == productName && !p.IsDelete) select p;
            } else
            {
                product = from p in _context.Products
                        where !p.IsDelete select p;
            }

            if (product == null)
            {
                throw new Exception("GetAllProduct of ProductService");
            }

            return product;
        }

        public IQueryable<Product> GetAllProductByCategory(string productCategoryName)
        {
            var productByCategory =
                from p in _context.Products
                where !p.IsDelete
                join c
                in _context.Categories
                on p.CateId
                equals c.CategoryId
                where c.CategoryName == productCategoryName
                select p;

            if (productByCategory == null)
            {
                throw new Exception("GetAllProductByCategory of ProductService");
            }

<<<<<<< HEAD
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

=======
            return productByCategory;
        }
>>>>>>> develop

        public Product GetProductById(string productId)
        {
            var product = _context
                            .Products
                            .Where(p => p.ProductId.Equals(productId) && !p.IsDelete)
                            .FirstOrDefault();

            if (product == null)
            {
                throw new Exception("GetProductById of ProductService");
            }

            return product;
        }
<<<<<<< HEAD
=======

        public async Task UpdateProduct(string productId, ProductCreateRequest productCreateRequest)
        {
            var product = _context.Products
                            .Where(p => p.ProductId.Equals(productId) && !p.IsDelete)
                            .FirstOrDefault();

            if (product == null)
            {
                throw new Exception("UpdateProduct of ProductService");
            }

            product.ProductName = productCreateRequest.ProductName;
            product.Description = productCreateRequest.Description;
            product.ManufacturingDate = productCreateRequest.ManufacturingDate;
            product.ExpiryDate = productCreateRequest.ExpiryDate;
            product.Price = productCreateRequest.Price;
            product.CateId = productCreateRequest.CateId;

            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(string productId)
        {
            var product = _context
                            .Products
                            .Where(p => p.ProductId.Equals(productId) && !p.IsDelete)
                            .FirstOrDefault();

            if (product == null)
            {
                throw new Exception("DeleteProduct of ProductService");
            }

            product.IsDelete = true;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        

        public string CreateProductId(string productIdOld)
        {
            var separateIdString = productIdOld.Substring(1);
            var productIdParse = int.Parse(separateIdString)+1;
            return "P"+ productIdParse.ToString();
        }

        public string CreateImageId(string imageIdOld)
        {
            var separateIdString = imageIdOld.Substring(1);
            var imageIdParse = int.Parse(separateIdString)+1;
            return "I"+ imageIdParse.ToString();
        }
>>>>>>> develop
    }
}
