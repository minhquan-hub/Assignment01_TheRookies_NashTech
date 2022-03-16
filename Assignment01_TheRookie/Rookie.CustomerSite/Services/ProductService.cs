using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Product;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Dto.Image;

namespace Rookie.CustomerSite.Services
{
    public class ProductService : IProductService
    {
        
        // Method: Get
        public async Task<PagedResponseDto<ProductDto<ImageDto>>> GetProductByCategoryAndPageAsync(string productCategoryName)
        {
            var url = $"https://localhost:5001/api/Product/category?Search={productCategoryName}&SortOrder=1&SortColumn=3&Limit=12&Page=2";
            return JsonConvert.DeserializeObject<PagedResponseDto<ProductDto<ImageDto>>>(await JsonResponseByGet(url));
        }

        // Method: Get
        public async Task<PagedResponseDto<ProductDto<ImageDto>>> GetAllProductAsync(string productName){
            var url = $"https://localhost:5001/api/Product/allproduct?Search={productName}&SortOrder=1&SortColumn=3&Limit=12&Page=2";
            return JsonConvert.DeserializeObject<PagedResponseDto<ProductDto<ImageDto>>>(await JsonResponseByGet(url));
        }

        // Method: Get
        public async Task<ProductDto<ImageDto>> GetProductByIdAsync(string id)
        {
            var url = $"https://localhost:5001/api/Product/id/{id}";
            return JsonConvert.DeserializeObject<ProductDto<ImageDto>>(await JsonResponseByGet(url));
        }       

        public async Task<string> JsonResponseByGet(string url)
        {
            var jsonResponse = "";
            try
            {
                using var httpClient = new HttpClient();
                jsonResponse = await httpClient.GetStringAsync(url);
                if(string.IsNullOrEmpty(jsonResponse))
                {
                    throw new Exception("The client product get don't have the data");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"At JsonResponseByGet ProductService: {ex.Message}");
            }
            
            return jsonResponse;
        }
    	
        public async Task<string> JsonResponseByPost(string url, string jsoncontent)
        {
            var jsonResponse = "";
            try
            {
                using var httpClient = new HttpClient();

                var httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Method = HttpMethod.Post;
                httpRequestMessage.RequestUri = new Uri(url);
                
                var httpContent = new StringContent(jsoncontent, Encoding.UTF8, "application/json");
                httpRequestMessage.Content = httpContent;

                var response = await httpClient.SendAsync(httpRequestMessage);
                jsonResponse = await response.Content.ReadAsStringAsync();
                if(string.IsNullOrEmpty(jsonResponse))
                {
                    throw new Exception("The client product post don't have the data");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"At JsonResponseByPost of ProductService: {ex.Message}");
            }
            return jsonResponse;
        }

    }
}