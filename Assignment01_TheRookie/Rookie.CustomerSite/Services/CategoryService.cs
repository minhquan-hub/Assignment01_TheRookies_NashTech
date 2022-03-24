using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.CustomerSite.ViewModel.Category;
using Rookie.ShareClass.Constants;
using Rookie.ShareClass.Dto.Category;
using RookieShop.Shared.Constants;

namespace Rookie.CustomerSite.Services
{
    public class CategoryService : ICategoryService
    {
        public IHttpClientFactory _httpClientFactory;

        public CategoryService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // Method: Get
        public async Task<IList<CategoryDto>> GetAllCategoryAsync()
        {
            var getCategoryEndPoints = $"{EndPointConstants.GET_CATEGORY}";
            return JsonConvert.DeserializeObject<IList<CategoryDto>>(await JsonResponseByGet(getCategoryEndPoints));
        }

        public async Task<string> JsonResponseByGet(string url)
        {
            var client = _httpClientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var jsonResponse = await client.GetStringAsync(url);

            if (string.IsNullOrEmpty(jsonResponse))
            {
                throw new Exception("The client category don't have the data");
            }
             
            return jsonResponse;
        }
    }
}
