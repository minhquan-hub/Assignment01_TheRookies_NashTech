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
<<<<<<< HEAD
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetProductAndPageAsync(string productName);
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetProductByCategoryAndPageAsync(string productCategoryName);
        public Task<IList<ProductDto<ImageDto>>> GetProductByNameAsync(string productName);
        public Task<IList<ProductDto<ImageDto>>> GetProductByCategoryAsync(string productCategoryName);
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetAllProduct();
        public Task<ProductDto<ImageDto>> GetProductById(string id);
=======
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetProductByCategoryAndPageAsync(CategoryCriteriaDto categoryCriteriaDto);
        public Task<PagedResponseDto<ProductDto<ImageDto>>> GetAllProductAndPageAsync(ProductCriteriaDto productCriteriaDto);
        public Task<ProductDto<ImageDto>> GetProductByIdAsync(string id);
>>>>>>> 22aac2b36c4a4e4499d1d4deb7d83e7139fb1427
        
    }
}