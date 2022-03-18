using System.Collections.Generic;
using System.Threading.Tasks;
using Rookie.BackendAPI.Models;
using Rookie.ShareClass.Dto.Category;

namespace Rookie.BackendAPI.Services.InterfaceServices{

    public interface ICategoryService{

               
        public Task CreateCategory(CategoryCreateRequest categoryCreateRequest);
        public List<Category> GetAllCategory(); 
        public Task UpdateCategory(string categoryId, CategoryCreateRequest categoryCreateRequest);
        public Task DeleteCategory(string categoryId);
    }
}