using AutoMapper;
using Rookie.CustomerSite.ViewModel.Product;
using Rookie.CustomerSite.ViewModel;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Dto.Product;
using Rookie.ShareClass.Dto.Image;
using Rookie.CustomerSite.ViewModel.Image;

namespace Rookie.CustomerSite.Mapping
{
    public class ProductAutoMappingProfile : Profile
    {
        public ProductAutoMappingProfile()
        {
            CreateMap<ProductDto<ImageDto>, ProductVM<ImageVM>>().ReverseMap();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();
            CreateMap<PagedResponseDto<ProductDto<ImageDto>>, PagedResponseVM<ProductVM<ImageVM>>>().ReverseMap();
        }
    }
}