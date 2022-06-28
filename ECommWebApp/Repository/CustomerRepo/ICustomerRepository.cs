using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Models;

namespace ECommWebApp.Repository.CustomerRepo
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        //public List<Customer> GetCustomersByAge(int age, bool max = true);
        //bool Delete(Customer customer);
    }
}
