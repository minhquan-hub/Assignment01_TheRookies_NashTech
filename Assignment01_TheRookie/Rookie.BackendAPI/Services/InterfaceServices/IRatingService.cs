using Rookie.BackendAPI.Models;
using Rookie.ShareClass.Dto.Rating;

namespace Rookie.BackendAPI.Services.InterfaceServices
{
    public interface IRatingService
    {
        public void InsertRating(RatingDto ratingDto);
    }
}