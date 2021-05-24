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
    public class DrinksController : ControllerBase, IController<Drink>
    {
        private readonly DrinksService _service;
        public DrinksController(DrinksService service)
        {
            _service = service;
        }



        [HttpGet]
        public ActionResult<IEnumerable<Drink>> GetAll()
        {
            try
            {
                IEnumerable<Drink> drinks = _service.GetAll();
                return Ok(drinks);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpGet("{id}")]
        public ActionResult<Drink> GetById(int id)
        {
            try
            {
                Drink found = _service.GetById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPost]
        public ActionResult<Drink> Create([FromBody] Drink data)
        {
            try
            {
                Drink drink = _service.Create(data);
                return Ok(drink);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPut("{id}")]
        public ActionResult<Drink> Update([FromBody] Drink data)
        {
            try
            {
                Drink update = _service.Update(data);
                return Ok(update);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpDelete("{id}")]
        public ActionResult<Drink> Delete(int id)
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
