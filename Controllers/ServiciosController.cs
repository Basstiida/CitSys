using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SisCit_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        [HttpGet]
        public string pruebaConexcioN()
        {
            return "Api en funcionamiento";
        }
    }
}
