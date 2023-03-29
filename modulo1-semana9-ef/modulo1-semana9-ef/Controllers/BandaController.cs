using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modulo1_semana9_ef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandaController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post()
        {
            return Ok(true);
        }
    }
}
