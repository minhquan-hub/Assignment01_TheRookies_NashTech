

using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Product;
using RookieShop.Shared.Dto;
using Rookie.BackendAPI.Extensions;
using System.Linq;
using Rookie.BackendAPI.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Rookie.BackendAPI.Controllers
{

    [Route("api/[controller]")]
    [EnableCors("AllowOrigins")]
    [ApiController]
    public class ProductController : ControllerBase 
    {
        
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
        //[AllowAnonymous]
        public async Task<ActionResult<PagedResponseDto<ProductDto>>> GetProductAndPage([FromQuery]ProductCriteriaDto productCriteriaDto)
        {
            var product = _productService.GetAllByNameAndPage(productCriteriaDto.Search);
            var productQuery =  ProductFilter(await product, productCriteriaDto) ;
            var pageProducts = await productQuery.AsNoTracking().PaginateAsync(productCriteriaDto);
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(pageProducts.Items);
            return new PagedResponseDto<ProductDto>{
                CurrentPage = pageProducts.CurrentPage,
                TotalItems = pageProducts.TotalItems,
                TotalPages = pageProducts.TotalPages,
                SortOrder = productCriteriaDto.SortOrder,
                SortColumn = productCriteriaDto.SortColumn,
                Limit = productCriteriaDto.Limit,
                Page = productCriteriaDto.Page,
                Items = productDto
            };
        }

        [HttpGet("{productName}")]
        public  ActionResult<ProductDto> GetProductByName(string productName)
        {
            var product = _productService.GetAllByName(productName);

            var productDto =  _mapper.Map<IEnumerable<ProductDto>>(product);
            return Ok(productDto);
        }

        // [HttpGet("Category/{productCategoryName}")]
        // public ActionResult<ProductDto> GetProductByCategory(string productCategoryName){
        //     var product = _productService.GetAllByCategory(productCategoryName);

        //     var productDto =  _mapper.Map<IEnumerable<ProductDto>>(product);
        //     return Ok(productDto);
        // }
        #region Private Method
        private  IQueryable<Product> ProductFilter(
            IQueryable<Product> productQuery,
            ProductCriteriaDto productCriteriaDto)
        {
            // if (!String.IsNullOrEmpty(productCriteriaDto.Search))
            // {
            //     productQuery = productQuery.Where(p =>
            //         p.ProductName.Contains(productCriteriaDto.Search));
            // }

            // if (productCriteriaDto.Types != null &&
            //     productCriteriaDto.Types.Count() > 0 &&
            //    !productCriteriaDto.Types.Any(x => x == (int)BrandTypeEnum.All))
            // {
            //     productQuery = productQuery.Where(x => 
            //         productQuery.Types.Any(t => t == x.Type));
            // }

            return productQuery;
        }
        #endregion
    }
}