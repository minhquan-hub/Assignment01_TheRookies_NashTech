using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rookie.ShareClass.Dto.Product;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Dto.Image;

namespace Rookie.CustomerSite.Services.InterfaceServices
{
    public interface IProductService
    {
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetProductByCategoryAndPageAsync(string productCategoryName);
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetProductByNameAndPageAsync(string productName);        
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetAllProductAsync();
        public Task<ProductDto<ImageDto>> GetProductByIdAsync(string id);
        
    }
}