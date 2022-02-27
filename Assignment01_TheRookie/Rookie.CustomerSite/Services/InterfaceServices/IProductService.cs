using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rookie.ShareClass.Dto.Product;
using Rookie.ShareClass.Dto;

namespace Rookie.CustomerSite.Services.InterfaceServices
{
    public interface IProductService
    {
        public Task<PagedResponseDto<ProductDto>> GetProductAndPageAsync(string productName);
        public Task<PagedResponseDto<ProductDto>> GetProductByCategoryAndPageAsync(string productCategoryName);
        public Task<IList<ProductDto>> GetProductByNameAsync(string productName);
        public Task<IList<ProductDto>> GetProductByCategoryAsync(string productCategoryName);
        public Task<ProductDto> GetProductById(int id);
        
    }
}