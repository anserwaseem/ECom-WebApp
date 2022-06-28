using ECommWebApp.Controllers.Generic;
using ECommWebApp.Models;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Repository.ProductRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : GenericController<Product>
    {
        public ProductsController(IProductRepository context) : base(context)
        {
        }
    }
}
