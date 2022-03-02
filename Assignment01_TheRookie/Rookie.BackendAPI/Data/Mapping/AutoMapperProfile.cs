using AutoMapper;
using Rookie.BackendAPI.Models;
using Rookie.ShareClass.Dto.Category;
using Rookie.ShareClass.Dto.Image;
using Rookie.ShareClass.Dto.Product;

namespace Rookie.BackendAPI.Data.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()  
        {  
            CreateMap<Product, ProductDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Image, ImageDto>();
        }  
    }
}