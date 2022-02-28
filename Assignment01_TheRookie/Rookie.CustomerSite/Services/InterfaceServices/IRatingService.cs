using System.Threading.Tasks;
using Rookie.ShareClass.Dto.Rating;

namespace Rookie.CustomerSite.Services.InterfaceServices
{
    public interface IRatingService
    {
        public Task InsertRatingAsync(RatingDto ratingDto);
    }
}