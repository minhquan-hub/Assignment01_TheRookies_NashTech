using Microsoft.EntityFrameworkCore;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Data.SeedData
{
    public static class RatingDataInitializer
    {
        public static void SeedRatingData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasData(
                new Rating{
                    RateId = "R1001",
                    ProductId = "P4004"
                }
            );
        }
    }
}