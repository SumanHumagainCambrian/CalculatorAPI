using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET add action
        [HttpGet("add")]
        public ActionResult<decimal> Add(decimal param1, decimal param2)
        {
            var result = param1 + param2;
            return Ok(result);
        }

        // GET subtract action
        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract(decimal param1, decimal param2)
        {
            var result = param1 - param2;
            return Ok(result);
        }

        // GET multiply action
        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply(decimal param1, decimal param2)
        {
            var result = param1 * param2;
            return Ok(result);
        }

        // GET divide action
        [HttpGet("divide")]
        public ActionResult<decimal> Divide(decimal param1, decimal param2)
        {
            if(param2 == 0)
            {
                return BadRequest("Divide by zero expection");
            }
            var result = param1 / param2;
            return Ok(result);
        }

        // GET modular division
        [HttpGet("modulo")]
        public ActionResult<decimal> Modulo(decimal param1, decimal param2)
        {
            if (param2 == 0)
            {
                return BadRequest("Cannot perform modulo by zero.");
            }
            var result = param1 % param2;
            return Ok(result);
        }

    }
}
