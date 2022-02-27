using System.Collections.Generic;
using System.Threading.Tasks;
using Rookie.CustomerSite.ViewModel.Category;

namespace Rookie.CustomerSite.Services.InterfaceServices
{
    public interface ICategoryService
    {
        public Task<IList<CategoryVM>>  GetAllCategoryAsync();
    }
}