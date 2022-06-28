using ECommWebApp.Models;
using ECommWebApp.Repository.CustomerRepo;
using ECommWebApp.Repository.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? Items { get; set; }
        public DbSet<Product>? Products { get; set; }
    }
}
