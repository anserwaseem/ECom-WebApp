using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Models;
using Microsoft.EntityFrameworkCore;
using ECommWebApp.Data;

namespace ECommWebApp.Repository.OrderItemRepo
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(AppDbContext context) : base(context)
        {
        }
    }
}
