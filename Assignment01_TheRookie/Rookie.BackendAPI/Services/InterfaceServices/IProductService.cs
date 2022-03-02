using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Services.InterfaceServices{

    public interface IProductService{

        public Task<int> CreateProduct(Product product);
        public Task<int> DeleteProduct(int productId); 
        public Task<int> UpdateProduct(int productId, Product product); 
        public IQueryable<Product> GetAllProductAndPage();
        public Task<IQueryable<Product>> GetAllProductByNameAndPage(string productName);
        public Task<IQueryable<Product>> GetAllProductByCategoryAndPage(string productCategoryName);        
        public List<Product> GetAllProductByName(string productName);
        public Product GetProductById(int productId);
        public List<Product> GetAllProductByCategory(string productCategoryName);
    }
}