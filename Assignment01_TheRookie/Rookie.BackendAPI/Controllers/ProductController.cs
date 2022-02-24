

using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Services.IntefaceServices;
using Rookie.ShareClass.Dto.Product;
using RookieShop.Shared.Dto;
using Rookie.BackendAPI.Extensions;
using System.Linq;
using Rookie.BackendAPI.Models;
using System;

namespace Rookie.BackendAPI.Controllers{

    [Route("api/[controller]")]
    [EnableCors("AllowOrigins")]
    [ApiController]
    public class ProductController : ControllerBase {
        
        private readonly ApplicationDbContext _context;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        // private readonly IFileStorageService _fileStorageService;
        
        public ProductController(
            ApplicationDbContext context,
            IMapper mapper, IProductService productService)
        {
            _context = context;
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<PagedResponseDto<ProductDto>>> GetProduct(ProductCriteriaDto productCriteriaDto, 
        CancellationToken cancellationToken)
        {
            var product = _productService.GetAllByName(productCriteriaDto.Search);
            var productQuery = ProductFilter(product, productCriteriaDto) ;
            var pageProduct = await product.AsNoTracking().PaginateAsync(productCriteriaDto, cancellationToken);
            return new PagedResponseDto<ProductDto>();
        }

        private IQueryable<Product> ProductFilter(
            IQueryable<Product> productQuery,
            ProductCriteriaDto productCriteriaDto)
        {
            if (!String.IsNullOrEmpty(productCriteriaDto.Search))
            {
                productQuery = productQuery.Where(p =>
                    p.ProductName.Contains(productCriteriaDto.Search));
            }

            // if (productCriteriaDto.Types != null &&
            //     productCriteriaDto.Types.Count() > 0 &&
            //    !productCriteriaDto.Types.Any(x => x == (int)BrandTypeEnum.All))
            // {
            //     productQuery = productQuery.Where(x => 
            //         productQuery.Types.Any(t => t == x.Type));
            // }

            return productQuery;
        }
    }
}