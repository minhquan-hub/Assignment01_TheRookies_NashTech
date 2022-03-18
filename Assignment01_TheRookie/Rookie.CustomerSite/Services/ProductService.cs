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
            var getProductByIdEndPoints = $"{EndPointConstants.GET_PRODUCT_BY_ID}/{productId}";
            return JsonConvert.DeserializeObject<ProductDto<ImageDto>>(await JsonResponseByGet(getProductByIdEndPoints));
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