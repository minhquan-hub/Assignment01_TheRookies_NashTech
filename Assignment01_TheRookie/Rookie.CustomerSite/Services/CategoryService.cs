using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.CustomerSite.ViewModel.Category;
using Rookie.ShareClass.Dto.Category;

namespace Rookie.CustomerSite.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<IList<CategoryDto>> GetAllCategoryAsync()
        {
            string url = "https://localhost:5001/api/Category";
            return JsonConvert.DeserializeObject<IList<CategoryDto>>(await JsonResponseByGet(url));
        }

        public async Task<string> JsonResponseByGet(string url)
        {
            using var httpClient = new HttpClient();
            var jsonResponse = await httpClient.GetStringAsync(url);
            if(string.IsNullOrEmpty(jsonResponse))
            {
                throw new Exception("The client product get don't have the data");
            }
            return jsonResponse;
        }
    }
}