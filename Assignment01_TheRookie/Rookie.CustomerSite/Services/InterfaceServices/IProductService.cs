using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rookie.ShareClass.Dto.Product;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Dto.Image;
using Rookie.ShareClass.Dto.Category;

namespace Rookie.CustomerSite.Services.InterfaceServices
{
    public interface IProductService
    {
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetProductByCategoryAndPageAsync(CategoryCriteriaDto categoryCriteriaDto);
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetAllProductAndPageAsync(ProductCriteriaDto productCriteriaDto);
        public Task<ProductDto<ImageDto>> GetProductByIdAsync(string id);
        
    }
}