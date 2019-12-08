using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PIZZAPORTAL.Models;

namespace PIZZAPORTAL.Controllers
{
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private s17874Context _context;

        public PizzaController(s17874Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllPizza()
        {
            return Ok(_context.Pizza.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPizza(int id)
        {
            return Ok(_context.Pizza.Find(id));
        }

    }
}