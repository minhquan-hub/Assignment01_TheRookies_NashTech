using System;
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
        public Image GetImageByProductId(string productId)
        {
            try
            {
                var image = _context.Images.Where(i => i.ProductId.Equals(productId)).FirstOrDefault();
                return image;
            }
            catch (Exception ex)
            {
                throw new Exception($"At GetImageByProductId() of ImageService: {ex.Message}");
            }
        }
    }
}