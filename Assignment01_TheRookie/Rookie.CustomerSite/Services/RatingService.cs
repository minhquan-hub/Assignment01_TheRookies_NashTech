using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.ShareClass.Constants;
using Rookie.ShareClass.Dto.Rating;
using RookieShop.Shared.Constants;

namespace Rookie.CustomerSite.Services
{
    public class RatingService : IRatingService
    {
        public IHttpClientFactory _httpClientFactory;

        public RatingService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // Method: Post
        public async Task InsertRatingAsync(RatingDto ratingDto)
        {
            try
            {
                var postRatingEndPoints = $"{EndPointConstants.POST_RATING}";
                var jsoncontent = JsonConvert.SerializeObject(ratingDto);

                var client = _httpClientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
                var stringContent = new StringContent(jsoncontent, Encoding.UTF8, "application/json");
                await client.PostAsync(postRatingEndPoints, stringContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"At JsonResponseByPost of ProductService: {ex.Message}");
            }
        }
    }
}
