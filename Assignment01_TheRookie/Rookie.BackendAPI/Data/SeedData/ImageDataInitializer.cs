using Microsoft.EntityFrameworkCore;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Data.SeedData
{
    public static class ImageDataInitializer 
    {
        public static void SeedImageData(this ModelBuilder modelbuilder){
            modelbuilder.Entity<Image>().HasData(
                new Image{
                    ImageID = "I01",
                    ProductId = 1,
                    Image1 = "/images/bg_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I02",
                    ProductId = 2,
                    Image1 = "/images/bg_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I03",
                    ProductId = 3,
                    Image1 = "/images/bg_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I04",
                    ProductId = 4,
                    Image1 = "/images/product-4.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I05",
                    ProductId = 5,
                    Image1 = "/images/image_5.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I06",
                    ProductId = 6,
                    Image1 = "/images/product-8.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I07",
                    ProductId = 7,
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I08",
                    ProductId = 8,
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I09",
                    ProductId = 9,
                    Image1 = "/images/image_5.jpg",
                    Image2 = "/images/product-4.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I10",
                    ProductId = 10,
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I11",
                    ProductId = 11,
                    Image1 = "/images/product-4.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I12",
                    ProductId = 12,
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-5.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I13",
                    ProductId = 13,
                    Image1 = "/images/product-6.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-7.jpg"
                },
                new Image{
                    ImageID = "I14",
                    ProductId = 14,
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I15",
                    ProductId = 15,
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I16",
                    ProductId = 16,
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I17",
                    ProductId = 17,
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I18",
                    ProductId = 18,
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I19",
                    ProductId = 19,
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I20",
                    ProductId = 20,
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I21",
                    ProductId = 21,
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I22",
                    ProductId = 22,
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I23",
                    ProductId = 23,
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I24",
                    ProductId = 24,
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I25",
                    ProductId = 25,
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I26",
                    ProductId = 26,
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I27",
                    ProductId = 27,
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I28",
                    ProductId = 28,
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I29",
                    ProductId = 29,
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I30",
                    ProductId = 30,
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I31",
                    ProductId = 31,
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I32",
                    ProductId = 32,
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I33",
                    ProductId = 33,
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I34",
                    ProductId = 34,
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I35",
                    ProductId = 35,
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I36",
                    ProductId = 36,
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                }
            );
        }
    }
}