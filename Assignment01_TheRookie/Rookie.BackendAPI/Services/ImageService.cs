using System.Collections.Generic;
using System.Linq;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Models;
using Rookie.BackendAPI.Services.InterfaceServices;
namespace Rookie.BackendAPI.Services
{
    public class ImageService : IImageService
    {
        private readonly ApplicationDbContext _context;

        public ImageService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Image GetImageByProductId(int productId)
        {
            var image = _context.Images.Where(i => i.ProductId == productId).FirstOrDefault();
            return image;
        }
    }
}