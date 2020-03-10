using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Model;

namespace Getway.Controllers
{
    [Route("api/[controller]")]   
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Please request with consumption";
        }

        [HttpGet("{consumption:decimal}")]
        //public IEnumerable<TariffResponseDTO> Get(decimal consumption)
        public IActionResult Get(decimal consumption)
            
        {
            if (consumption < 0) return BadRequest($"consumption could not be a negativ value");
            Calculator calc = new Calculator();
            return Ok(calc.calculateForAllApplications(consumption));            
        }
    }
}