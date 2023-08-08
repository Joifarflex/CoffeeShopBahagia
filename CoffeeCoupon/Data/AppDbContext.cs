using CoffeeCoupon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCoupon.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
             
        }
        
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon { 
                //ex coupon
                Id = 1,
                CouponCode = "AA01",
                DiscountAmout = 1500,
                MinAmount = 65000,
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                //ex coupon
                Id = 2,
                CouponCode = "BA02",
                DiscountAmout = 2000,
                MinAmount = 65000,
            });
        }
    }
}
