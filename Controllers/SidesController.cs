using cs_burger_shack.Services;
using Microsoft.AspNetCore.Mvc;


namespace cs_burger_shack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SidesController : ControllerBase
    {
        private readonly SidesService _service;
        public SidesController(SidesService service)
        {
            _service = service;
        }
    }
}