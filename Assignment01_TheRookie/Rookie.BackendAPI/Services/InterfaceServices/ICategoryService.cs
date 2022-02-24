using System.Threading.Tasks;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Services.InterfaceServices{

    public interface ICategoryService{

        public Task<Category> GetAllById(int categoryId);        public Task<int> CreateCategory(Category category);
        public Task<int> DeleteCategory(int categoryId);

        public Task<int> UpdateCategory(int categoryId, Category category);
    }
}