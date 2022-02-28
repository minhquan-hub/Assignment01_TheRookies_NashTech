using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Product;
using Rookie.ShareClass.Dto;

namespace Rookie.CustomerSite.Services
{
    public class ProductService : IProductService
    {
        public async Task<PagedResponseDto<ProductDto>> GetProductAndPageAsync(string productName)
        {
            var url = $"https://localhost:5001/api/Product";
            string jsoncontent = "{\"search\":\""+productName+"\",\"sortOrder\":0,\"sortColumn\":\"3\",\"limit\":12,\"page\":2,\"types\":[0]}";
            return JsonConvert.DeserializeObject<PagedResponseDto<ProductDto>>(await JsonResponseByPost(url,jsoncontent));
             
        }

        public async Task<PagedResponseDto<ProductDto>> GetProductByCategoryAndPageAsync(string productCategoryName){
            var url = $"https://localhost:5001/api/Product/Category";
            string jsoncontent = "{\"search\":\""+productCategoryName+"\",\"sortOrder\":0,\"sortColumn\":\"3\",\"limit\":12,\"page\":2,\"types\":[0]}";
            return JsonConvert.DeserializeObject<PagedResponseDto<ProductDto>>(await JsonResponseByPost(url,jsoncontent));
        }

        public async Task<IList<ProductDto>> GetProductByCategoryAsync(string productCategoryName)
        {
            var url = $"https://localhost:5001/api/Product/Category/{productCategoryName}";
            return JsonConvert.DeserializeObject<List<ProductDto>>(await JsonResponseByGet(url));
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            var url = $"https://localhost:5001/api/Product/id/{id}";
            return JsonConvert.DeserializeObject<ProductDto>(await JsonResponseByGet(url));
        }

        public async Task<IList<ProductDto>> GetProductByNameAsync(string productName)
        {
            var url = $"https://localhost:5001/api/Product/{productName}";
            return JsonConvert.DeserializeObject<List<ProductDto>>(await JsonResponseByGet(url));
        }

        public async Task<string> JsonResponseByGet(string url)
        {
            using var httpClient = new HttpClient();
            var jsonResponse = await httpClient.GetStringAsync(url);
            if(string.IsNullOrEmpty(jsonResponse))
            {
                throw new Exception("The client get don't have the data");
            }
            return jsonResponse;
        }

        public async Task<string> JsonResponseByPost(string url, string jsoncontent)
        {
            using var httpClient = new HttpClient();

                var httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Method = HttpMethod.Post;
                httpRequestMessage.RequestUri = new Uri(url);

                
                var httpContent = new StringContent(jsoncontent, Encoding.UTF8, "application/json");
                httpRequestMessage.Content = httpContent;

                var response = await httpClient.SendAsync(httpRequestMessage);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if(string.IsNullOrEmpty(jsonResponse)){
                    throw new Exception("The client post don't have the data");
                }
                return jsonResponse;
        }

    }
}