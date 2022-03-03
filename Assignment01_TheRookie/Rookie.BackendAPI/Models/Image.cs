using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.BackendAPI.Models
{
    [Table("Image")]
    public class Image
    {
        [Key, Column("image_id", TypeName = "varchar(10)")]
        public string ImageID { get; set; }

        [Required]
        public string ProductId { get; set; }

        [ForeignKey("ProductId"), Column("product_id")]
        public Product Product { get; set; }

        [Column("image_01")]
        public string Image1 { get; set; }

        [Column("image_02")]
        public string Image2 { get; set; }

        [Column("image_03")]
        public string Image3 { get; set; }

        [Column("image_04")]
        public string Image4 { get; set; }

        [Column("image_05")]
        public string Image5 { get; set; }
    }
}