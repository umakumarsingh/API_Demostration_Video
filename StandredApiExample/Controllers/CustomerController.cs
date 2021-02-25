using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StandredApiExample.Entities;

namespace StandredApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        /// <summary>
        /// Get customer details based on simple http get method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var customer = new Customer { Id = 1, Name = "Steve Smith" };
            return new JsonResult(customer);
        }

        // GET api/values/5
        [HttpGet("{Id}")]
        public ActionResult<string> Get(int Id)
        {
            var customer = new Customer();
            //Create a new list of customer to show the list of json result to display.

            customer.Customers = new List<Customer>
            {
                new Customer{ Id = 1, Name = "Mike"},
                new Customer { Id = 2, Name = "Steve Smith" }
            };

            return new JsonResult(customer);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
