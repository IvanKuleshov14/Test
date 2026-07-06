using Microsoft.AspNetCore.Mvc;

namespace FirstService.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            return Ok();
        }
    }
}
