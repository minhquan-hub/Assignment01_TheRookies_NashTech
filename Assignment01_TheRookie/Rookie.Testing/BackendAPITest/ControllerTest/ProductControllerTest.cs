using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Rookie.BackendAPI.Controllers;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Data.Mapping;
using Rookie.BackendAPI.Models;
using Rookie.BackendAPI.Services;
using Rookie.BackendAPI.Services.InterfaceServices;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Dto.Image;
using Rookie.ShareClass.Dto.Product;
using Rookie.Testing.BackendAPITest.Mock.MockIQueryable;
using Rookie.Testing.BackendAPITest.Mock.MockService;
using Xunit;

namespace Rookie.Testing.ControllerTest
{
    public class ProductControllerTest
    {
        private static IMapper _mapper;
        
        public ProductControllerTest()
        {
            if(_mapper == null){
                var mappingConfig = new MapperConfiguration(mc => 
                {
                    mc.AddProfile(new AutoMapperProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [Fact]
        public async Task PostAllProductByNameAndPage_CheckProductName_ReturnPagedResponseDto()
        {
            // Arrange
            var productCriteriaDtoModel = new ProductCriteriaDto{
                Search = "Tomato",
                SortOrder = 0,
                SortColumn = "3",
                Limit = 3,
                Page = 2,
                Types = new int[] {0}
            };
            
            var fakeProductIQueryable = new FakeDataProduct(); 
            var mockProductService = new MockProductService().MockGetAllProductByNameAndPage(fakeProductIQueryable.ProductIQueryable);
            var mockImageService = new MockImageService().MockGetImageByProductId(new Image());
            var productController = new ProductController(_mapper, mockProductService.Object, mockImageService.Object);

            // Act
            var productResult = await productController.PostAllProductByNameAndPage(productCriteriaDtoModel);

            // Assert
            var returnValue = Assert.IsType<PagedResponseDto<ProductDto<ImageDto>>>(productResult.Value);
            Assert.Equal(productCriteriaDtoModel.Search, returnValue.Items.FirstOrDefault().ProductName);
        }

        [Fact]
        public async Task PostAllProductAndPage_CheckCountProductAndReturnType_ReturnPagedResponseDto()
        {
            // Arrange
            var productCriteriaDtoModel = new ProductCriteriaDto{
                Search = "",
                SortOrder = 0,
                SortColumn = "3",
                Limit = 3,
                Page = 2,
                Types = new int[] {0}
            };

            var fakeProductIQueryable = new FakeDataProduct();
            var mockProductService = new MockProductService().MockGetAllProductAndPage(fakeProductIQueryable.ProductIQueryable);
            var mockImageService = new MockImageService().MockGetImageByProductId(new Image());
            var productController = new ProductController(_mapper, mockProductService.Object, mockImageService.Object);

            // Act
            var productResult = await productController.PostAllProductAndPage(productCriteriaDtoModel);

            // Assert
            var returnValue = Assert.IsType<PagedResponseDto<ProductDto<ImageDto>>>(productResult.Value);
            Assert.Equal(productCriteriaDtoModel.Limit, returnValue.Items.Count());
            Assert.IsType<ActionResult<PagedResponseDto<ProductDto<ImageDto>>>>(productResult);
        }

        [Fact]
        public void GetProductById_CheckProductIdAndName_ReturnProductDto()
        {
            // Arrange
            var productModel = new Product{
                ProductId = "P4019",
                ProductName = "Celery",
                Description = "Vegetable is very healthy",
                ManufacturingDate = DateTime.Parse("2022-02-22"),
                ExpiryDate = DateTime.Parse("2022-04-13"),
                Price = 30,
                CateId = "C3004"
            };

            var imageModel = new Image{
                ImageID = "I2019",
                ProductId = "P4019",
                Image1 = "/images/product-1.jpg",
                Image2 = "/images/product-3.jpg",
                Image3 = "/images/product-6.jpg"
            };

            var productId = "P4019";
            var mockProductService = new MockProductService().MockGetProductById(productModel);
            var mockImageService = new MockImageService().MockGetImageByProductId(imageModel);
            var productController = new ProductController(_mapper,mockProductService.Object, mockImageService.Object); 

            // Act
            var productResult =  productController.GetProductById(productId);

            // Assert
            var result = productResult.Result as OkObjectResult;
            var returnValue = Assert.IsType<ProductDto<ImageDto>>(result.Value);
            
            Assert.Equal(productModel.ProductName, returnValue.ProductName);
            Assert.Equal(productId,  returnValue.ProductId);
        }

    }
}