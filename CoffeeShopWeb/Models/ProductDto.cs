using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWeb.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
