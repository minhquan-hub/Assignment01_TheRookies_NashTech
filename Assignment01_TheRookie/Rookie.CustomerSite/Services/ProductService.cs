using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Product;
using RookieShop.Shared.Dto;

namespace Rookie.CustomerSite.Services
{
    public class ProductService : IProductService
    {
        public async Task<PagedResponseDto<ProductDto>> GetProductAndPageAsync(string productCategoryName)
        {
                var url = $"https://localhost:5001/api/Product?Search={productCategoryName}&SortOrder=0&Limit=12&Page=2";
                return JsonConvert.DeserializeObject<PagedResponseDto<ProductDto>>(await JsonResponse(url));
        }

        public async Task<IList<ProductDto>> GetProductByCategoryAsync(string productCategoryName)
        {
            var url = $"https://localhost:5001/api/Product/Category/{productCategoryName}";
            return JsonConvert.DeserializeObject<List<ProductDto>>(await JsonResponse(url));
        }

        public async Task<ProductDto> GetProductById(int id)
        {
                var url = $"https://localhost:5001/api/Product/{id}";
                return JsonConvert.DeserializeObject<ProductDto>(await JsonResponse(url));
        }

        public async Task<IList<ProductDto>> GetProductByNameAsync(string productName)
        {
                var url = $"https://localhost:5001/api/Product/{productName}";
                return JsonConvert.DeserializeObject<List<ProductDto>>(await JsonResponse(url));
        }

        public async Task<string> JsonResponse(string url){
            using var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }

    }
}