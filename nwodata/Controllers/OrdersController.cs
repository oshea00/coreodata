using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using nwodata.Models;

namespace nwodata.Controllers
{
    public class OrdersController : ODataController 
    {
        private NorthwindContext _db;

        public OrdersController(NorthwindContext context)
        {
            _db = context;
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Orders);
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_db.Orders.FirstOrDefault(c => c.OrderId == key));

        }
    }
}
