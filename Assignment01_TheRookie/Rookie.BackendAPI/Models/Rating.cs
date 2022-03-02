using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.BackendAPI.Models
{
    [Table("Rating")]
    public class Rating 
    {
        [Key, Column("rate_id", Order=0)]
        public string RateId { get; set; }

        public int ProductId { get; set; }
        [Required, ForeignKey("ProductId"), Column("product_id")]
        public Product Product { get; set; }

        [Column("user_id")]
        public string UserId {get; set; }

        [Column("rate_number")]
        public int RateNumber { get; set; }
    }
}