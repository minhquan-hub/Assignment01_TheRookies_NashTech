using System;
using System.Linq;
using System.Threading.Tasks;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Models;
using Rookie.BackendAPI.Services.IntefaceServices;
using Rookie.ShareClass.Dto.Product;

namespace Rookie.BackendAPI.Services{

    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<int> CreateProduct(Product product)
        {
            throw new System.NotImplementedException();
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

        public Task<int> UpdateProduct(int productId, Product product)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Product> GetAllById(int productId)
        {
            var product = _context.Products.Where(p => p.ProductId == productId).FirstOrDefault();
            return product;
        }

        public async Task<PagedResponseDto<ProductDto>>> GetAllByName(string productName)
        {
            var product = _context.Products.Where(p => p.ProductName == productName).AsQueryable();
            var productQuery = ProductFilter(product, productCriteriaDto) ;
            var pageProduct = await product.AsNoTracking().PaginateAsync(productCriteriaDto, cancellationToken);
            return new PagedResponseDto<ProductDto>;
        }
    }
}