using System;
using System.Collections.Generic;
using cs_burger_shack.Models;
using cs_burger_shack.Services;
using Microsoft.AspNetCore.Mvc;

namespace cs_burger_shack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BurgersController : ControllerBase
    {
        private readonly BurgersService _service;
        public BurgersController(BurgersService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Burger>> GetAll()
        {
            try
            {
                IEnumerable<Burger> burgers = _service.GetAll();
                return Ok(burgers);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
