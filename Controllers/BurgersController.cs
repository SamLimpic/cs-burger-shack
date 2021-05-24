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
    public class BurgersController : ControllerBase, IController<Burger>
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



        [HttpGet("{id}")]
        public ActionResult<Burger> GetById(int id)
        {
            try
            {
                Burger found = _service.GetById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPost]
        public ActionResult<Burger> Create([FromBody] Burger data)
        {
            try
            {
                Burger burger = _service.Create(data);
                return Ok(burger);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPut("{id}")]
        public ActionResult<Burger> Update([FromBody] Burger data)
        {
            try
            {
                Burger update = _service.Update(data);
                return Ok(update);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpDelete("{id}")]
        public ActionResult<Burger> Delete(int id)
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
