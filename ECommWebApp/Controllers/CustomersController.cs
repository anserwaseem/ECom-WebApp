using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommWebApp.Data;
using ECommWebApp.Models;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Repository.CustomerRepo;
using ECommWebApp.Controllers.Generic;

namespace ECommWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : GenericController<Customer>
    {
        public CustomersController(ICustomerRepository context) : base(context)
        {
        }

        //private readonly ICustomerRepository _context;

        //public CustomersController(ICustomerRepository context)
        //{
        //    _context = context;
        //}

        //public CustomersController(IGenericRepository<Customer> genericRepository) : base(genericRepository)
        //{
        //}

        //// GET: api/<BaseController>
        //[HttpGet]
        //public List<Customer> Get()
        //{
        //    return _context.GetAll();
        //}

        //// GET api/5
        //[HttpGet("{id}")]
        //public Customer Get(int id)
        //{
        //    return _context.Get(id);
        //}

        //// POST api/<BaseController>
        //[HttpPost]
        //public bool Post([FromBody] Customer value)
        //{
        //    return _context.Add(value) && _context.Save();
        //}

        //// PUT api/<BaseController>/5
        //[HttpPut("{id}")]
        //public Customer Put(int id, [FromBody] Customer value)
        //{
        //    Customer entity = _context.Update(id, value);
        //    _context.Save();
        //    return entity;
        //}

        //// DELETE api/<BaseController>/5
        //[HttpDelete("{id}")]
        //public bool Delete(int id)
        //{
        //    return _context.Remove(id) && _context.Save();
        //}




        //// GET: api/Customers
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        //{
        //  if (_context.Customers == null)
        //  {
        //      return NotFound();
        //  }
        //    return await _context.Customers.ToListAsync();
        //}

        //// GET: api/Customers/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Customer>> GetCustomer(int id)
        //{
        //  if (_context.Customers == null)
        //  {
        //      return NotFound();
        //  }
        //    var customer = await _context.Customers.FindAsync(id);

        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    return customer;
        //}

        //// PUT: api/Customers/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCustomer(int id, Customer customer)
        //{
        //    if (id != customer.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(customer).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CustomerExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Customers
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        //{
        //  if (_context.Customers == null)
        //  {
        //      return Problem("Entity set 'AppDbContext.Customers'  is null.");
        //  }
        //    _context.Customers.Add(customer);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
        //}

        //// DELETE: api/Customers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCustomer(int id)
        //{
        //    if (_context.Customers == null)
        //    {
        //        return NotFound();
        //    }
        //    var customer = await _context.Customers.FindAsync(id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Customers.Remove(customer);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool CustomerExists(int id)
        //{
        //    return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
        //}

    }
}
