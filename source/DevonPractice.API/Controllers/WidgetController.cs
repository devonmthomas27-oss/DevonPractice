using Microsoft.AspNetCore.Mvc;

namespace DevonPractice.API.Controllers
{
    /// <inheritdoc/>
    [ApiController]
    [Route("widget")]
    public class WidgetController : ControllerBase
    {
       /// <summary>
       /// Gets my widget
       /// </summary>
       /// <returns><see cref="IActionResult"/>.</returns>
        [HttpGet]
        [ProducesResponseType<string>(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
        return Ok("hello!");
        }
    }
}
