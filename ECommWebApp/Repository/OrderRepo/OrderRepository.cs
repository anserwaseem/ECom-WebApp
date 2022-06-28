using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Models;
using Microsoft.EntityFrameworkCore;
using ECommWebApp.Repository.OrderRepo;
using ECommWebApp.Data;

namespace ECommWebApp.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
