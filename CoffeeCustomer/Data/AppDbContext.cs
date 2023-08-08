using CoffeeCustomer.Models;
using CoffeeCustomer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCustomer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
             
        }
        
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(new Customer { 
                //ex Customer
                Id = 1,
                CustomerName = "Aaron",
                MobileNumber = "053166778990",
                TotalAmout = 100000,

            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                //ex Customer
                Id = 2,
                CustomerName = "Sarai",
                MobileNumber = "051798822001",
                TotalAmout = 610000,
            });
        }
    }
}
