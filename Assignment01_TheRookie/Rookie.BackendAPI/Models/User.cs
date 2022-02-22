using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Rookie.BackendAPI.Models{
    public class User : IdentityUser {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Address { get; set; }
        public string Email { get; set; }
    }
}