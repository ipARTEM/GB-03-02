using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Values _values;

        public ValuesController(
            //Values values
            )
        {
            //_values = values;

        }

        [HttpGet]
        public IActionResult GetHi()
        {
            return Ok("Hi, I am cpu controller");
        }
    }
}
