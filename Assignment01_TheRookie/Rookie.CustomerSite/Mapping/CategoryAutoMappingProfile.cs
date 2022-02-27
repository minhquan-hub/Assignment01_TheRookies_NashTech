using AutoMapper;
using Rookie.CustomerSite.ViewModel;
using Rookie.CustomerSite.ViewModel.Product;
using Rookie.CustomerSite.ViewModel.Category;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Dto.Category;

namespace Rookie.CustomerSite.Mapping
{
    public class CategoryAutoMappingProfile : Profile
    {
        public CategoryAutoMappingProfile()
        {
            CreateMap<CategoryDto, CategoryVM>().ReverseMap();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();
            CreateMap<PagedResponseDto<CategoryDto>, PagedResponseVM<ProductVM>>().ReverseMap();
        }
    }
}