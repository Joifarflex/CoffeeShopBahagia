using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCoupon.Models.Dto
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public double TotalAmout { get; set; }
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public CouponDto? Coupon { get; set; }
    }
}
