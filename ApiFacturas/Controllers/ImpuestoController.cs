using ApiFacturas.Models;
using ApiFacturas.Request;
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
    public class ImpuestoController : ControllerBase
    {
        private readonly IImpuestoService _impuestoService;
        public ImpuestoController(IImpuestoService impuestoService)
        {
            _impuestoService = impuestoService;
        }
        // GET: api/<ProductoController>
        [HttpGet]
        public List<Impuesto> Get()
        {

            return _impuestoService.GetAll();
        }
        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public async Task<Impuesto> Get(int id)
        {
            return await _impuestoService.GetId(id);
        }
        // POST api/<ProductoController>
        [HttpPost]
        public async Task Post([FromBody] ImpuestoRequest impuesto)
        {
            await _impuestoService.AddImpuesto(impuesto);
        }
        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ImpuestoRequest impuesto)
        {
            _impuestoService.UpdateImpuesto(id, impuesto);
        }
        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _impuestoService.DeleteId(id);
            return Ok();
        }
    }
}
