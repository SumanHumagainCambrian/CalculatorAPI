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


    }
}
