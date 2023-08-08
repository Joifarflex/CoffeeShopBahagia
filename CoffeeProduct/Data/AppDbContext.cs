using CoffeeProduct.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeProduct.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                //ex coupon
                Id = 1,
                ProductName = "BrazilianCoffee",
                ProductPrice = 80000,
                CategoryName = "Raw",
                ImageUrl = "https://placehold.co/603x403",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                //ex coupon
                Id = 2,
                ProductName = "JavaCoffee",
                ProductPrice = 55000,
                CategoryName = "Raw",
                ImageUrl = "https://placehold.co/602x402",
            });
        }
    }
}
