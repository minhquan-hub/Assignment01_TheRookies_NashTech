using System.Collections.Generic;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Services.InterfaceServices
{
    public interface IImageService
    {
        public Image GetImageByProductId(int productId);
    }
}