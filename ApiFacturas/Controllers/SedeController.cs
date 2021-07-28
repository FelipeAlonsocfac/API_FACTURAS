using ApiFacturas.Models;
using ApiFacturas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SedeController : ControllerBase
    {
        private readonly ISedeService _sedeService;
        public SedeController(ISedeService sedeService)
        {
            _sedeService = sedeService;
        }
        // GET: api/<ProductoController 
        [HttpGet]
        public List<Sede> Get()
        {
            return _sedeService.GetAll();
        }
        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public async Task<Sede> Get(int id)
        {
            return await _sedeService.GetId(id);
        }
        // POST api/<ProductoController>
        [HttpPost]
        public async Task Post([FromBody] Sede sede)
        {
            await _sedeService.AddSede(sede);
        }
            
         // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Sede sede)
        {
            _sedeService.UpdateSede(sede);
        }
        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _sedeService.DeleteId(id);
            return Ok();
        }
    }
}
