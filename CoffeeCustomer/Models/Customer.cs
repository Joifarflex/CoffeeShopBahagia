using CoffeeCoupon.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCustomer.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        public double TotalAmout { get; set; }
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        [NotMapped]
        public CouponDto Coupon { get; set; }
    }
}
