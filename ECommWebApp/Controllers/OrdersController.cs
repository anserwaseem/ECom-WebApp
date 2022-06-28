using ECommWebApp.Controllers.Generic;
using ECommWebApp.Models;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Repository.OrderRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : GenericController<Order>
    {
        public OrdersController(IOrderRepository context) : base(context)
        {
        }
    }
}
