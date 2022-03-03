

using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Product;
using Rookie.ShareClass.Dto;
using Rookie.BackendAPI.Extensions;
using System.Linq;
using Rookie.BackendAPI.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Rookie.ShareClass.Dto.Image;

namespace Rookie.BackendAPI.Controllers
{

    [Route("api/[controller]")]
    [EnableCors("AllowOrigins")]
    [ApiController]
    public class ProductController : ControllerBase 
    {
        
        private readonly ApplicationDbContext _context;
        private readonly IProductService _productService;
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;
        // private readonly IFileStorageService _fileStorageService;
        
        public ProductController(ApplicationDbContext context,IMapper mapper, IProductService productService, IImageService imageService)
        {
            _context = context;
            _mapper = mapper;
            _productService = productService;
            _imageService = imageService;
        }

        // GET: https://localhost:5001/api/Product?Search=Mint&SortOrder=0&SortColumn=3&Limit=12&Page=2
        [HttpPost]
        //[AllowAnonymous]
        public async Task<ActionResult<PagedResponseDto<ProductDto<ImageDto>>>> GetAllProductByNameAndPage(ProductCriteriaDto productCriteriaDto)
        {
            var product =  await _productService.GetAllProductByNameAndPage(productCriteriaDto.Search);
            var productQuery =  ProductFilter(product, productCriteriaDto) ;
            var pageProducts = await productQuery.AsNoTracking().PaginateAsync(productCriteriaDto);
            // var productDto = _mapper.Map<IEnumerable<ProductDto>>(pageProducts.Items);
            // foreach (var item in productDto)
            // {
            //     var image =  _imageService.GetImageByProductId(item.ProductId);
            //     var imageDto = _mapper.Map<ImageDto>(image);
            //     item.Image = imageDto;
            // }
            var productDto = MapProductDtoAndInsertImage(pageProducts.Items);
            return new PagedResponseDto<ProductDto<ImageDto>>{
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

        [HttpPost("AllProduct")]
        //[AllowAnonymous]
        public async Task<ActionResult<PagedResponseDto<ProductDto<ImageDto>>>> GetAllProductAndPage(ProductCriteriaDto productCriteriaDto)
        {
            var product = _productService.GetAllProductAndPage();
            var pageProducts = await product.AsNoTracking().PaginateAsync(productCriteriaDto);
            var productDto = MapProductDtoAndInsertImage(pageProducts.Items);
            return new PagedResponseDto<ProductDto<ImageDto>>{
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

        //GET: https://localhost:5001/api/Product/Category?Search=Vegatables&SortOrder=0&SortColumn=2&Limit=12&Page=2
        [HttpPost("Category")]
        public async Task<ActionResult<PagedResponseDto<ProductDto<ImageDto>>>> GetProductByCategoryAndPage(ProductCriteriaDto productCriteriaDto)
        {
            var product = _productService.GetAllProductByCategoryAndPage(productCriteriaDto.Search);
            var productQuery =  ProductFilter(await product, productCriteriaDto) ;
            var pageProducts = await productQuery.AsNoTracking().PaginateAsync(productCriteriaDto);
            var productDto = MapProductDtoAndInsertImage(pageProducts.Items);
            return new PagedResponseDto<ProductDto<ImageDto>>{
                CurrentPage = pageProducts.CurrentPage,
                TotalItems = pageProducts.TotalItems,
                TotalPages = pageProducts.TotalPages,
                Search = productCriteriaDto.Search,
                SortOrder = productCriteriaDto.SortOrder,
                SortColumn = productCriteriaDto.SortColumn,
                Limit = productCriteriaDto.Limit,
                Page = productCriteriaDto.Page,
                Items = productDto
            };
        }
        

        //GET: https://localhost:5001/api/Product/Mint
        [HttpGet("{productName}")]
        public  ActionResult<ProductDto<ImageDto>> GetProductByName(string productName)
        {
            var product = _productService.GetAllProductByName(productName);
            var productDto =  MapProductDtoAndInsertImage(product);
            return Ok(productDto);
        }

        //GET: https://localhost:5001/api/Product/id/1
        [HttpGet("id/{productId}")]
        public ActionResult<ProductDto<ImageDto>> GetProductById(int productId){
            var product = _productService.GetProductById(productId);
            var productDto = _mapper.Map<ProductDto<ImageDto>>(product);
            productDto.Image = _mapper.Map<ImageDto>(_imageService.GetImageByProductId(productDto.ProductId));
            return Ok(productDto);
        }

        //GET: https://localhost:5001/api/Product/Category/Fruits
        // [HttpGet("Category/{productCategoryName}")]
        // public ActionResult<ProductDto> GetProductByCategory(string productCategoryName){
        //     var product = _productService.GetAllProductByCategory(productCategoryName);
        //     var productDto =  _mapper.Map<IEnumerable<ProductDto>>(product);
        //     return Ok(productDto);
        // }

        #region Private Method
        private IEnumerable<ProductDto<ImageDto>> MapProductDtoAndInsertImage(IList<Product> product)
        {
            var productDto = _mapper.Map<IEnumerable<ProductDto<ImageDto>>>(product);
            foreach (var item in productDto)
            {
                var image =  _imageService.GetImageByProductId(item.ProductId);
                var imageDto = _mapper.Map<ImageDto>(image);
                item.Image = imageDto;
            }
            return productDto;
        }

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