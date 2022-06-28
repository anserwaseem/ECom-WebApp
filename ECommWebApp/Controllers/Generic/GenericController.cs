using ECommWebApp.Repository.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommWebApp.Controllers.Generic
{
    [Route("api/[controller]")]
    [ApiController] // handles model validation errors automatically (!ModelState.IsValid becomes unnecessary)
    public class GenericController<T> : ControllerBase
    {
        private readonly IGenericRepository<T> _context;

        public GenericController(IGenericRepository<T> context)
        {
            _context = context;
        }


        // GET: api/<BaseController>
        [HttpGet]
        public List<T> Get()
        {
            return _context.GetAll();
        }

        // GET api/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _context.Get(id);
        }

        // POST api/<BaseController>
        [HttpPost]
        public bool Post([FromBody] T value)
        {
            return _context.Add(value) ? _context.Save() : false;
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public T Put(int id, [FromBody] T value)
        {
            T entity = _context.Update(id, value);
            _context.Save();
            return entity;
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _context.Remove(id) ? _context.Save() : false;
        }
    }
}
