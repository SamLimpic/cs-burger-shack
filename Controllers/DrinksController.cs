using cs_burger_shack.Services;
using Microsoft.AspNetCore.Mvc;


namespace cs_burger_shack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrinksController : ControllerBase
    {
        private readonly DrinksService _service;
        public DrinksController(DrinksService service)
        {
            _service = service;
        }
    }
}
