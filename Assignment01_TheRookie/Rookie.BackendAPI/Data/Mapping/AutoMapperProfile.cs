using AutoMapper;
using Rookie.BackendAPI.Models;
using Rookie.ShareClass.Dto.Product;

namespace Rookie.BackendAPI.Data.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()  
        {  
            CreateMap<Product, ProductDto>();
                
        }  
    }
}