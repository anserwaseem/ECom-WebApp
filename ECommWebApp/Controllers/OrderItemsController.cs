using ECommWebApp.Controllers.Generic;
using ECommWebApp.Models;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Repository.OrderItemRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : GenericController<OrderItem>
    {
        public OrderItemsController(IOrderItemRepository context) : base(context)
        {
        }
    }
}
