using DevonPracticeInfrastructure;
using DevonPracticeInfrastructure.Widgets;
using Microsoft.AspNetCore.Mvc;

namespace DevonPractice.API.Controllers
{
    /// <inheritdoc/>
    [ApiController]
    [Route("widget")]
    public class WidgetController : ControllerBase
    {


        public ApplicationContext   Context { get; set; }

        public WidgetController(ApplicationContext context)
        {
            Context = context;
        }

    
       
        /// <summary>
        /// Gets my widget
        /// </summary>
        /// <returns><see cref="IActionResult"/>.</returns>
        [HttpGet]
        [ProducesResponseType<string>(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            Context.Widgets.Add(new Widget());
        Context.SaveChanges();
        return Ok("hello!");
        }
    }
}
