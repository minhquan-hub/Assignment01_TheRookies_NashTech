using Microsoft.EntityFrameworkCore;
using Rookie.BackendAPI.Models;

namespace Rookie.BackendAPI.Data.SeedData
{
    public static class ImageDataInitializer 
    {
        public static void SeedImageData(this ModelBuilder modelbuilder){
            modelbuilder.Entity<Image>().HasData(
                new Image{
                    ImageID = "I2001",
                    ProductId = "P4001",
                    Image1 = "/images/bg_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2002",
                    ProductId = "P4002",
                    Image1 = "/images/bg_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2003",
                    ProductId = "P4003",
                    Image1 = "/images/bg_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2004",
                    ProductId = "P4004",
                    Image1 = "/images/product-4.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2005",
                    ProductId = "P4005",
                    Image1 = "/images/image_5.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2006",
                    ProductId = "P4006",
                    Image1 = "/images/product-8.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2007",
                    ProductId = "P4007",
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2008",
                    ProductId = "P4008",
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2009",
                    ProductId = "P4009",
                    Image1 = "/images/image_5.jpg",
                    Image2 = "/images/product-4.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2010",
                    ProductId = "P4010",
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2011",
                    ProductId = "P4011",
                    Image1 = "/images/product-4.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2012",
                    ProductId = "P4012",
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-5.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2013",
                    ProductId = "P4013",
                    Image1 = "/images/product-6.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-7.jpg"
                },
                new Image{
                    ImageID = "I2014",
                    ProductId = "P4014",
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2015",
                    ProductId = "P4015",
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2016",
                    ProductId = "P4016",
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2017",
                    ProductId = "P4017",
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2018",
                    ProductId = "P4018",
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2019",
                    ProductId = "P4019",
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2020",
                    ProductId = "P4020",
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2021",
                    ProductId = "P4021",
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2022",
                    ProductId = "P4022",
                    Image1 = "/images/product-1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2023",
                    ProductId = "P4023",
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2024",
                    ProductId = "P4024",
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2025",
                    ProductId = "P4025",
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2026",
                    ProductId = "P4026",
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2027",
                    ProductId = "P4027",
                    Image1 = "/images/category-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2028",
                    ProductId = "P4028",
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2029",
                    ProductId = "P4029",
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2030",
                    ProductId = "P4030",
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2031",
                    ProductId = "P4031",
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2032",
                    ProductId = "P4032",
                    Image1 = "/images/product-3.jpg",
                    Image2 = "/images/product-7.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2033",
                    ProductId = "P4033",
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2034",
                    ProductId = "P4034",
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2035",
                    ProductId = "P4035",
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2036",
                    ProductId = "P4036",
                    Image1 = "/images/image_1.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2037",
                    ProductId = "P4037",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2038",
                    ProductId = "P4038",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2039",
                    ProductId = "P4039",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2040",
                    ProductId = "P4040",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2041",
                    ProductId = "P4041",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2042",
                    ProductId = "P4042",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2043",
                    ProductId = "P4043",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2044",
                    ProductId = "P4044",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2045",
                    ProductId = "P4045",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2046",
                    ProductId = "P4046",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2047",
                    ProductId = "P4047",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2048",
                    ProductId = "P4048",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2049",
                    ProductId = "P4049",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2050",
                    ProductId = "P4050",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2051",
                    ProductId = "P4051",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2052",
                    ProductId = "P4052",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2053",
                    ProductId = "P4053",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                },
                new Image{
                    ImageID = "I2054",
                    ProductId = "P4054",
                    Image1 = "/images/product-2.jpg",
                    Image2 = "/images/product-3.jpg",
                    Image3 = "/images/product-6.jpg"
                }
            );
        }
    }
}