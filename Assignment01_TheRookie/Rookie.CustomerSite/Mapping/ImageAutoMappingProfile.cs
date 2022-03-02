using AutoMapper;
using Rookie.CustomerSite.ViewModel;
using Rookie.ShareClass.Dto;
using Rookie.CustomerSite.ViewModel.Image;

namespace Rookie.CustomerSite.Mapping
{
    public class ImageAutoMappingProfile : Profile
    {
        public ImageAutoMappingProfile()
        {
            CreateMap<ImageDto, ImageVM>().ReverseMap();
        }
    }
}