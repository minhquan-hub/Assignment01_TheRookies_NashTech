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
        private readonly IProductService _productService;
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;
        
        public ProductController(IMapper mapper, IProductService productService, IImageService imageService)
        {
            _mapper = mapper;
            _productService = productService;
            _imageService = imageService;
        }

        [HttpPost]
        public ActionResult PostProduct([FromForm]ProductCreateRequest productCreateRequest){
            if(!string.IsNullOrEmpty(productCreateRequest.ProductName)
            && !string.IsNullOrEmpty(productCreateRequest.CateId))
            {
                _productService.CreateProduct(productCreateRequest);
            }
            return Ok();
        }

        // GET: https://localhost:5001/api/Product/AllProduct?Search=Apple&SortColumn=3&Limit=12&Page=2
        [HttpGet("allproduct")]
        //[AllowAnonymous]
       public async Task<ActionResult<PagedResponseDto<ProductDto<ImageDto>>>> GetAllProductAndPage([FromQuery]ProductCriteriaDto productCriteriaDto)
        {
            var product = _productService.GetAllProductAndPage(productCriteriaDto.Search);
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

        // GET: https://localhost:5001/api/Product/Category?Search=Fruits&SortColumn=3&Limit=12&Page=2
        [HttpGet("category")]
        public async Task<ActionResult<PagedResponseDto<ProductDto<ImageDto>>>> GetProductByCategoryAndPage([FromQuery]ProductCriteriaDto productCriteriaDto)
        {
            var product = _productService.GetAllProductByCategoryAndPage(productCriteriaDto.Search);
            var pageProducts = await product.AsNoTracking().PaginateAsync(productCriteriaDto);
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
        
        //GET: https://localhost:5001/api/Product/id/P4029
        [HttpGet("id/{productId}")]
        public ActionResult<ProductDto<ImageDto>> GetProductById(string productId)
        {
            if(string.IsNullOrEmpty(productId))
            {
                return NotFound();
            }
            var product = _productService.GetProductById(productId);
            var productDto = _mapper.Map<ProductDto<ImageDto>>(product);
            productDto.Image = _mapper.Map<ImageDto>(_imageService.GetImageByProductId(productDto.ProductId));
            return Ok(productDto);
        }

        // PUT: https://localhost:5001/api/Product/P4014
        [HttpPut("{productId}")]
        public ActionResult PutProduct(string productId,[FromForm]ProductCreateRequest productCreateRequest){
            if(string.IsNullOrEmpty(productId))
            {
                return NotFound();
            }

            _productService.UpdateProduct(productId, productCreateRequest);
            return Ok(true);
        }

        // DELETE: https://localhost:5001/api/Product/P4014
        [HttpDelete("{productId}")]
        public ActionResult DeleteProduct(string productId){
            if(string.IsNullOrEmpty(productId))
            {
                return NotFound();
            }
            
            _productService.DeleteProduct(productId);

            return Ok(true);
        }

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
        #endregion
    }
}