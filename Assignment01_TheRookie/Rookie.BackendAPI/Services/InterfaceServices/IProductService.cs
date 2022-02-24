using System.Linq;
using System.Threading.Tasks;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Services.InterfaceServices{

    public interface IProductService{

        public Task<Product> GetAllById(int productId);
        public Task<int> CreateProduct(Product product);
        public Task<int> DeleteProduct(int productId);

        public Task<int> UpdateProduct(int productId, Product product);
        Task<IQueryable<Product>> GetAllByName(string productName);
    }
}