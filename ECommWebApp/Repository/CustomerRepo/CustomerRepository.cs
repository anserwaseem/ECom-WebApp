using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Models;
using Microsoft.EntityFrameworkCore;
using ECommWebApp.Data;

namespace ECommWebApp.Repository.CustomerRepo
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }

        //public List<Customer> GetCustomersByAge(int age, bool max = true)
        //{
        //    //Context.
        //    List<Customer> AllCustomers = GetAll();
        //    if (max)
        //        return AllCustomers.Where(customer => customer.Age >= age).ToList();
        //    return AllCustomers.Where(customer => customer.Age < age).ToList();
        //}
        //public bool Delete(Customer customer)
        //{
        //    bool deleted = Remove(customer);
        //    //if (deleted)
        //    //    Customer.CustomerCount--;
        //    return deleted;
        //}
        
        //public EComContext EComContext
        //{
        //    get { return Context as EComContext; }
        //}
    }
}
