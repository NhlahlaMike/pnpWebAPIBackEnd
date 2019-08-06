using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pnpWebAPIBackEnd.Models
{
    public class Product
    {
        [Key]
        [Column(TypeName = "nvarchar(100)")]
        public string Barcode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string ProductType { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string ImageUrl { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Features { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int Usage { get; set; }
    }
}
