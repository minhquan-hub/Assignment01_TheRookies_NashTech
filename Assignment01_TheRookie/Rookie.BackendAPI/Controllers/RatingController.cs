using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rookie.BackendAPI.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Rating;

namespace RookieShop.Backend.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigins")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly ILogger<RatingController> _logger;
        private readonly IRatingService _ratingService;

        public RatingController(ILogger<RatingController> logger, IRatingService ratingService)
        {
            _logger = logger;
            _ratingService = ratingService;
        }

        //Get: https://localhost:5001/api/Rating
        [HttpGet]
        public void InsertRating(RatingDto ratingDto)
        {
            _ratingService.InsertRating(ratingDto);
        }
    }
}