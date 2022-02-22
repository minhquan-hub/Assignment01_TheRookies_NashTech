using Microsoft.EntityFrameworkCore;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Data.SeedData {
    public static class CategoryDataInitializer {
        public static void SeedCategoryData(this ModelBuilder modelbuilder){
            modelbuilder.Entity<Category>().HasData(
                new Category {
                    CategoryId = 1,
                    CategoryName = "Vegatables",
                    Description = "Vegetables are parts of plants that are consumed by humans or other animals as food"
                },
                new Category {
                    CategoryId = 2,
                    CategoryName = "Fruits",
                    Description = "a fruit is the seed-bearing structure in flowering plants that is formed from the ovary after flowering"
                },
                new Category {
                    CategoryId = 3,
                    CategoryName = "Juice",
                    Description = "Juice is a drink made from the extraction or pressing of the natural liquid contained in fruit and vegetables"
                },
                new Category {
                    CategoryId = 4,
                    CategoryName = "Dried",
                    Description = "Dried fruit is fruit from which the majority of the original water content has been removed either naturally, through sun drying, or through the use of specialized dryers or dehydrators"
                }
            );
        }
    }
}