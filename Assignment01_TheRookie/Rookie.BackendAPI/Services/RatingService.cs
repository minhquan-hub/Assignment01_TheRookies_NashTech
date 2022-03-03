using System;
using System.Linq;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Models;
using Rookie.BackendAPI.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Rating;

namespace Rookie.BackendAPI.Services
{
    public class RatingService : IRatingService
    {
        private readonly ApplicationDbContext _context;
        
        public RatingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void InsertRating(RatingDto ratingDto)
        {
            try{
                var rating = _context.Ratings.OrderBy(r => r.RateId).Last();
                var InsertRating = new Rating {
                RateId = CreateRateId(rating.RateId),
                ProductId = ratingDto.ProductId,
                RateNumber = ratingDto.RateNumber
                };
                _context.Ratings.Add(InsertRating);
                if(_context.SaveChanges() == 0){
                    throw new Exception("Can not insert rating into database");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"At InsertRating method of RatingService: {ex.Message}");
            }
            
        }

        public string CreateRateId(string rateIdOld)
        {
            var createIdString1 = rateIdOld.Substring(1);
            var rateIdParse = int.Parse(createIdString1)+1;
            return "R"+ rateIdParse.ToString();
        }
        
    }
}