using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rookie.BackendAPI.Models;
using Rookie.ShareClass.Dto.Product;

namespace Rookie.BackendAPI.Services.InterfaceServices{

    public interface IProductService{

<<<<<<< HEAD
        public Task<int> CreateProduct(Product product);
        public Task<int> DeleteProduct(int productId); 
        public Task<int> UpdateProduct(int productId, Product product); 
        public IQueryable<Product> GetAllProductAndPage();
        public IQueryable<Product> GetAllProductByNameAndPage(string productName);
        public IQueryable<Product> GetAllProductByCategoryAndPage(string productCategoryName);
        public Product GetProductById(string productId);
=======
        public Task CreateProduct(ProductCreateRequest productCreateRequest);
        public IQueryable<Product> GetAllProduct(string productName);
        public IQueryable<Product> GetAllProductByCategory(string productCategoryName);
        public Product GetProductById(string productId);
        public Task DeleteProduct(string productId); 
        public Task UpdateProduct(string productId, ProductCreateRequest productCreateRequest);
>>>>>>> develop
    }
}