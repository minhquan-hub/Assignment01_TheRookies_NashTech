using System.Collections.Generic;
using System.Threading.Tasks;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.CustomerSite.ViewModel.Category;

namespace Rookie.CustomerSite.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<IList<CategoryVM>> GetAllCategoryAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}