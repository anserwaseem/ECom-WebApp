using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Models;
using ECommWebApp.Repository.ProductRepo;
using Microsoft.EntityFrameworkCore;
using ECommWebApp.Data;

namespace ECommWebApp.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
