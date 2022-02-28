using System.Collections.Generic;
using System.Threading.Tasks;
using Rookie.ShareClass.Dto.Category;

namespace Rookie.CustomerSite.Services.InterfaceServices
{
    public interface ICategoryService
    {
        public Task<IList<CategoryDto>>  GetAllCategoryAsync();
    }
}