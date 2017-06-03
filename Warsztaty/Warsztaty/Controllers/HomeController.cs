using Microsoft.AspNetCore.Mvc;

namespace Warsztaty.API.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        => Content("Hello from Warsztaty API!");
    }
}
