using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using warsztaty.messages.Commands;

namespace Warsztaty.API.Controllers
{
    [Route("[controller]")]
    public class RecordsController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            return Accepted();
        }
    }
}
