using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyService.Data.Model;
using MyService.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAngulerCoreMVC.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        ServiceContext context;
        public PersonController(ServiceContext _context)
        {
            context = _context;

        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return context.Person;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
