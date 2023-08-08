using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeProduct.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
