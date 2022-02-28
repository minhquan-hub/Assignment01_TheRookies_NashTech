using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rookie.BackendAPI.Data.SeedData;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedProductData();
            modelBuilder.SeedCategoryData();
            modelBuilder.SeedImageData();
            modelBuilder.SeedRatingData();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products {get; set; }
        public DbSet<Category> Categories {get; set; }
        public DbSet<Image> Images {get; set; }
        public DbSet<Rating> Ratings {get; set; }
    }
}
