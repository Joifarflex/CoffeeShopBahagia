using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWeb.Models
{
    public class CouponDto
    {
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmout { get; set; }
        public int MinAmount { get; set; }
    }
}
