using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.BackendAPI.Models{
    [Table("Product")]
    public class Product {

        [Key, Column("product_id", TypeName = "varchar(10)")]
        public string ProductId { get; set; }

        [Required, Column("product_name", TypeName = "varchar(255)")]
        public string ProductName { get; set; }

        [Required, Column("description", TypeName = "varchar(300)")]
        public string Description { get; set; }

        [Required, Column("manufacturing_date", TypeName = "datetime2")]
        public DateTime ManufacturingDate { get; set; }
        [Required, Column("expiry_date", TypeName = "datetime2")]
        public DateTime ExpiryDate { get; set; }

        [Column("price", TypeName = "decimal")]
        public decimal Price { get; set; }

        public string CateId { get; set; }

        [Required, ForeignKey("CateId"), Column("cate_id")]
        public Category Category { get; set; }

        public Image Image { get; set; }

        public List<Rating> Ratings { get; set;}

        [Column("is_delete")]
        public bool IsDelete { get; set; }

    }
}