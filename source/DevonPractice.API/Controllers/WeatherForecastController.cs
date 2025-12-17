using Microsoft.AspNetCore.Mvc;

namespace DevonPractice.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
   

        [HttpGet]
        [ProducesResponseType<string>(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
        return Ok();
        }
    }
}
