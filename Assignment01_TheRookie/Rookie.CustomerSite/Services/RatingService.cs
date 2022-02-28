using System;
using System.Net.Http;
using System.Threading.Tasks;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Rating;

namespace Rookie.CustomerSite.Services
{
    public class RatingService : IRatingService
    {
        public async Task InsertRatingAsync(RatingDto ratingDto)
        {
            string url = $"https://localhost:5001/api/Rating?ProductId={ratingDto.ProductId}&RateNumber={ratingDto.RateNumber}";
            await JsonResponseByGet(url);
        }

        public async Task JsonResponseByGet(string url)
        {
            try
            {
                using var httpClient = new HttpClient();
                var jsonResponse = await httpClient.GetAsync(url);
            }
            catch(Exception ex)
            {
                throw new Exception($"At JsonResponseByGet of RatingService: {ex.Message}");
            }
        }
    }
}