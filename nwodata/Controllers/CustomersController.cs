using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using nwodata.Models;

namespace nwodata.Controllers
{
    public class CustomersController : ODataController 
    {
        private NorthwindContext _db;

        public CustomersController(NorthwindContext context)
        {
            _db = context;
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Customers);
        }

        [EnableQuery]
        public IActionResult Get(string key)
        {
            return Ok(_db.Customers.FirstOrDefault(c => c.CustomerId == key));
        }
    }
}
