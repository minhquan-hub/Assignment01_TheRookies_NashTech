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

        public ProductService(
            ApplicationDbContext context
        )
        {
            _context = context;
        }

        public async Task CreateProduct(ProductCreateRequest productCreateRequest)
        {
            try{
            var productLast = _context.Products.OrderBy(p => p.ProductId).Last();
            var imageLast = _context.Images.OrderBy(i => i.ImageID).Last();
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
            catch(Exception ex)
            {
                throw new Exception($"At CreateProduct() of ProductService: {ex.Message}");
            }
        }

        public IQueryable<Product> GetAllProductAndPage(string productName)
        {
            try
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
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception($"At GetAllProductAndPage() of ProductService: {ex.Message}");
            }
        }

        public IQueryable<Product> GetAllProductByCategoryAndPage(string productCategoryName)
        {
            try
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
                return productByCategory;
            }
            catch (Exception ex)
            {
                throw new Exception($"At GetAllProductByCategoryAndPage() of ProductService: {ex.Message}");
            }
        }

        public Product GetProductById(string productId)
        {
            try
            {
                var product =
                    _context
                        .Products
                        .Where(p => p.ProductId.Equals(productId) && !p.IsDelete)
                        .FirstOrDefault();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception($"At GetProductById() of ProductService: {ex.Message}");
            }
        }

        public async Task UpdateProduct(string productId, ProductCreateRequest productCreateRequest)
        {
            try
            {
                var product = _context.Products
                            .Where(p => p.ProductId.Equals(productId) && !p.IsDelete)
                            .FirstOrDefault();

                if (product == null)
                {
                    throw new Exception("At UpdateProduct() of ProdutCategoy: Can't find product you want to remove");
                }
                
                if(!string.IsNullOrEmpty(productCreateRequest.ProductName) && !string.IsNullOrEmpty(productCreateRequest.CateId)){
                    product.ProductName = productCreateRequest.ProductName;
                    product.Description = productCreateRequest.Description;
                    product.ManufacturingDate = productCreateRequest.ManufacturingDate;
                    product.ExpiryDate = productCreateRequest.ExpiryDate;
                    product.Price = productCreateRequest.Price;
                    product.CateId = productCreateRequest.CateId;
                }
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"At DeleteProduct() of ProductService: {ex.Message}");
            }
        }

        public async Task DeleteProduct(string productId)
        {
            try
            {
                var product =
                    _context
                        .Products
                        .Where(p => p.ProductId.Equals(productId) && !p.IsDelete)
                        .FirstOrDefault();
                if (product == null)
                {
                    throw new Exception("At DeleteProduct() of ProdutCategoy: Can't find product you want to remove");
                }
                product.IsDelete = true;
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"At DeleteProduct() of ProductService: {ex.Message}");
            }
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
    }
}
