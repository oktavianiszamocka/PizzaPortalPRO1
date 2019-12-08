using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PIZZAPORTAL.Models;

namespace PIZZAPORTAL.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private s17874Context _context;
        public CustomerController(s17874Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllCustomer()
        {
            return Ok(_context.Customer.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPizza(int id)
        {
            return Ok(_context.Customer.Find(id));
        }
    }
}