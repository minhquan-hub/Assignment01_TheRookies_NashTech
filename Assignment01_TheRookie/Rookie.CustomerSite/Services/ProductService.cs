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
using Rookie.ShareClass.Constants;
using Rookie.ShareClass.Dto.Category;
using RookieShop.Shared.Constants;

namespace Rookie.CustomerSite.Services
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ProductService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;   
        }
        // Method: Get
        public async Task<PagedResponseDto<ProductDto<ImageDto>>> GetProductByCategoryAndPageAsync(CategoryCriteriaDto categoryCriteriaDto)
        {
            var getProductByCategoryAndPageEndPoints = $"{EndPointConstants.GET_PRODUCT_BY_CATEGORY}?Search={categoryCriteriaDto.Search}&SortOrder={categoryCriteriaDto.SortOrder}&SortColumn={categoryCriteriaDto.SortColumn}&Limit={categoryCriteriaDto.Limit}&Page={categoryCriteriaDto.Page}";
            return JsonConvert.DeserializeObject<PagedResponseDto<ProductDto<ImageDto>>>(await JsonResponseByGet(getProductByCategoryAndPageEndPoints));
        }

        // Method: Get
        public async Task<PagedResponseDto<ProductDto<ImageDto>>> GetAllProductAndPageAsync(ProductCriteriaDto productCriteriaDto){
            var getAllProductEndPoints = $"{EndPointConstants.GET_ALL_PRODUCT}?Search={productCriteriaDto.Search}&SortOrder={productCriteriaDto.SortOrder}&SortColumn={productCriteriaDto.SortColumn}&Limit={productCriteriaDto.Limit}&Page={productCriteriaDto.Page}";
            return JsonConvert.DeserializeObject<PagedResponseDto<ProductDto<ImageDto>>>(await JsonResponseByGet(getAllProductEndPoints));
        }

        // Method: Get
        public async Task<ProductDto<ImageDto>> GetProductByIdAsync(string productId)
        {
<<<<<<< HEAD
            var url = $"https://localhost:5001/api/Product/Category/{productCategoryName}";
            return JsonConvert.DeserializeObject<List<ProductDto<ImageDto>>>(await JsonResponseByGet(url));
        }

        public async Task<PagedResponseDto<ProductDto<ImageDto>>> GetAllProduct(){
            var url = "https://localhost:5001/api/Product/AllProduct";
            string jsonContent = "{\"search\":\"string\",\"sortOrder\":0,\"sortColumn\":\"3\",\"limit\":12,\"page\":2,\"types\":[0]}";
            return JsonConvert.DeserializeObject<PagedResponseDto<ProductDto<ImageDto>>>(await JsonResponseByPost(url,jsonContent));
        }

        // Method: Get
        public async Task<ProductDto<ImageDto>> GetProductById(string id)
        {
            var url = $"https://localhost:5001/api/Product/id/{id}";
            return JsonConvert.DeserializeObject<ProductDto<ImageDto>>(await JsonResponseByGet(url));
=======
            var getProductByIdEndPoints = $"{EndPointConstants.GET_PRODUCT_BY_ID}/{productId}";
            return JsonConvert.DeserializeObject<ProductDto<ImageDto>>(await JsonResponseByGet(getProductByIdEndPoints));
>>>>>>> 22aac2b36c4a4e4499d1d4deb7d83e7139fb1427
        }       

        public async Task<string> JsonResponseByGet(string url)
        {
            var jsonResponse = "";
            try
            {   var client = _httpClientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
                jsonResponse = await client.GetStringAsync(url);
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
    }
}