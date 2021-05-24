using System;
using System.Collections.Generic;
using cs_burger_shack.Interfaces;
using cs_burger_shack.Models;
using cs_burger_shack.Services;
using Microsoft.AspNetCore.Mvc;

namespace cs_burger_shack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SidesController : ControllerBase, IController<Side>
    {
        private readonly SidesService _service;
        public SidesController(SidesService service)
        {
            _service = service;
        }



        [HttpGet]
        public ActionResult<IEnumerable<Side>> GetAll()
        {
            try
            {
                IEnumerable<Side> sides = _service.GetAll();
                return Ok(sides);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpGet("{id}")]
        public ActionResult<Side> GetById(int id)
        {
            try
            {
                Side found = _service.GetById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPost]
        public ActionResult<Side> Create([FromBody] Side data)
        {
            try
            {
                Side side = _service.Create(data);
                return Ok(side);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPut("{id}")]
        public ActionResult<Side> Update([FromBody] Side data)
        {
            try
            {
                Side update = _service.Update(data);
                return Ok(update);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpDelete("{id}")]
        public ActionResult<Side> Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return Ok("Successfully Deleted!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
