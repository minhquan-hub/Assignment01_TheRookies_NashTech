using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Services.InterfaceServices{

    public interface IProductService{

        public Task<int> CreateProduct(Product product);
        public Task<int> DeleteProduct(int productId); 
        public Task<int> UpdateProduct(int productId, Product product);
        public Task<Product> GetAllById(int productId); 
        public Task<IQueryable<Product>> GetAllByNameAndPage(string productName);
        public List<Product> GetAllByName(string productName);
        public List<Product> GetAllByCategory(string productCategory);
    }
}