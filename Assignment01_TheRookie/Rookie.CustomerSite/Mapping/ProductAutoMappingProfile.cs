using AutoMapper;
using Rookie.CustomerSite.ViewModel.Product;
using Rookie.CustomerSite.ViewModel;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Dto.Product;

namespace Rookie.CustomerSite.Mapping
{
    public class ProductAutoMappingProfile : Profile
    {
        public ProductAutoMappingProfile()
        {
            CreateMap<ProductDto, ProductVM>().ReverseMap();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();
            CreateMap<PagedResponseDto<ProductDto>, PagedResponseVM<ProductVM>>().ReverseMap();
        }
    }
}