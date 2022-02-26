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
            using (var httpClient = new HttpClient())
            {
                var endpoints = $"https://localhost:5001/api/Product?Search={productCategoryName}&SortOrder=0&Limit=12&Page=2";
                var jsonResponse = await httpClient.GetStringAsync(endpoints);
                var result = JsonConvert.DeserializeObject<PagedResponseDto<ProductDto>>(jsonResponse);
                return result;
            }
        }

        public async Task<IList<ProductDto>> GetProductByCategoryAsync(string productCategoryName)
        {
            using (var httpClient = new HttpClient())
            {
            var endpoints = $"https://localhost:5001/api/Product/Category/{productCategoryName}";
            var jsonResponse = await httpClient.GetStringAsync(endpoints);
            var result = JsonConvert.DeserializeObject<List<ProductDto>>(jsonResponse);
            return result;
            }
        }

        public async Task<IList<ProductDto>> GetProductByNameAsync(string productName)
        {
            using (var httpClient = new HttpClient()){
                var a = $"https://localhost:5001/api/Product/{productName}";
                Console.WriteLine(a);
                var jsonResponse = await httpClient.GetStringAsync(a); 
                Console.WriteLine(jsonResponse);
                var result = JsonConvert.DeserializeObject<List<ProductDto>>(jsonResponse);
                return result;
            }
            
        }

    }
}