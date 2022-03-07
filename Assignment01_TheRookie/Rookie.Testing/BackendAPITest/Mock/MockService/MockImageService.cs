using Moq;
using Rookie.BackendAPI.Models;
using Rookie.BackendAPI.Services.InterfaceServices;

namespace Rookie.Testing.BackendAPITest.Mock.MockService
{
    public class MockImageService : Mock<IImageService>
    {
        public MockImageService MockGetImageByProductId(Image result)
        {
            Setup(x => x.GetImageByProductId(It.IsAny<string>())).Returns(result);
            
            return this;
        }
    }
}