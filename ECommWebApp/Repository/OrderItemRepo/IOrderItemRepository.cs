using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Models;

namespace ECommWebApp.Repository.OrderItemRepo
{
    public interface IOrderItemRepository:IGenericRepository<OrderItem>
    {
    }
}
