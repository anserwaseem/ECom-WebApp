using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommWebApp.Models;
using ECommWebApp.Repository.Generic;

namespace ECommWebApp.Repository.ProductRepo
{
    public interface IProductRepository:IGenericRepository<Product>
    {
    }
}
