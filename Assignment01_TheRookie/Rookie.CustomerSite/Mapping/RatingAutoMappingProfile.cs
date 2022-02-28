using AutoMapper;
using Newtonsoft.Json.Converters;
using Rookie.CustomerSite.ViewModel.Rating;
using Rookie.ShareClass.Dto.Rating;

namespace Rookie.CustomerSite.Mapping
{
    public class RatingAutoMappingProfile : Profile
    {
        public RatingAutoMappingProfile() 
        {
            CreateMap<RatingDto, RatingVM>().ReverseMap();
        }
    }
}