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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedProductData();
            builder.SeedCategoryData();
            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products {get; set; }
        public DbSet<Category> Categories {get; set; }
    }
}
