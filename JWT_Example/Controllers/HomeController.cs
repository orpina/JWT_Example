using Microsoft.AspNetCore.Mvc;

namespace JWT_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DateTime.Now);
        }
    }
}
