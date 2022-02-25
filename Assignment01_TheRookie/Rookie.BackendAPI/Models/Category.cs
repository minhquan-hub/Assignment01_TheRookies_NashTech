using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.BackendAPI.Models
{
    [Table("Category")]
    public class Category{

        [Required, Column("category_id")]
        public int CategoryId { get; set; }

        [Required, Column("category_name", TypeName = "varchar(255)")]
        public string CategoryName { get; set; }

        [Column("description", TypeName = "ntext")]
        public string Description { get; set; }
    }
}