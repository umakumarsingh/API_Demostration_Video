using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StandredApiExample.Entities;

namespace StandredApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomCustomerController : ControllerBase
    {
        /// <summary>
        /// This method call based on name
        /// </summary>
        /// <returns></returns>
        
        //[HttpGet]
        [Route("AllCustomerInApp")]
        ///If we remove the HttpGet attribute not going to work, so we have to call with its fully qualified name.
        public ActionResult<IEnumerable<string>> AllCustomerInApp()
        {
            var customer = new Customer { Id = 1, Name = "Steve Smith" };
            return new JsonResult(customer);
        }
    }
}
