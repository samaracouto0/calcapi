using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        // Método para somar
        [HttpGet("somar")]
        public ActionResult<double> Somar([FromQuery] double a, [FromQuery] double b)
        {
            return Ok((a + b).ToString());
        }

        // Método para subtrair
        [HttpGet("subtrair")]
        public ActionResult<double> Subtrair([FromQuery] double a, [FromQuery] double b)
        {
            return Ok((a - b).ToString());
        }

        // Método para multiplicar
        [HttpGet("multiplicar")]
        public ActionResult<double> Multiplicar([FromQuery] double a, [FromQuery] double b)
        {
            return Ok((a * b).ToString());
        }

        // Método para dividir
        [HttpGet("dividir")]
        public ActionResult<double> Dividir([FromQuery] double a, [FromQuery] double b)
        {
            if (b == 0)
                return BadRequest("Divisão por zero não é permitida.");
            return Ok((a / b).ToString());
        }
    }
}