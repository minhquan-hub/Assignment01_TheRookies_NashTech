using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Rookie.BackendAPI.Controllers;
using Rookie.BackendAPI.Models;
using Rookie.BackendAPI.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Image;
using Rookie.ShareClass.Dto.Product;

namespace Rookie.Testing.BackendAPITest.Mock.MockService
{
    public class MockProductService : Mock<IProductService>
    {
        public MockProductService MockGetAllProductAndPage(IQueryable<Product> result)
        {
            Setup(x => x.GetAllProductAndPage()).Returns(result);

            return this;
        }

        public MockProductService MockGetAllProductByNameAndPage(IQueryable<Product> result)
        {
            Setup(x => x.GetAllProductByNameAndPage(It.IsAny<string>())).Returns(result);
            return this;
        }

        public MockProductService MockGetAllProductByCategoryAndPage(IQueryable<Product> result)
        {
            Setup(x => x.GetAllProductByCategoryAndPage(It.IsAny<string>())).Returns(result);
            return this;
        }

        public MockProductService MockGetProductById(Product result)
        {
            Setup(x => x.GetProductById(It.IsAny<string>())).Returns(result);

            return this;
        }
    }
}