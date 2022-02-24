using System.Threading.Tasks;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Services.IntefaceServices{

    public interface IProductService{

        public Task<Product> GetAllById(int productId);
        public Task<Product> GetAllByName(string productName);
        public Task<int> CreateProduct(Product product);
        public Task<int> DeleteProduct(int productId);

        public Task<int> UpdateProduct(int productId, Product product);
    }
}