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
    public class EncabezadoFacturaController : ControllerBase
    {
        private readonly IEncabezadoFacturaService _encabezadoFacturaService;
        public EncabezadoFacturaController(IEncabezadoFacturaService encabezadoFacturaService)
        {
            _encabezadoFacturaService = encabezadoFacturaService;
        }
        // GET: api/<ProductoController 
        [HttpGet]
        public List<EncabezadoFactura> Get()
        {

            return _encabezadoFacturaService.GetAll();
        }
        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public async Task<EncabezadoFactura> Get(int id)
        {
            return await _encabezadoFacturaService.GetId(id);
        }
        // POST api/<ProductoController>
        [HttpPost]
        public async Task Post([FromBody] EncabezadoFacturaRequest encabezadoFactura)
        {
            await _encabezadoFacturaService.AddEncabezadoFactura(encabezadoFactura);
        }
            
         // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EncabezadoFacturaRequest encabezadoFactura)
        {
            _encabezadoFacturaService.UpdateEncabezadoFactura(id, encabezadoFactura);
        }
        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _encabezadoFacturaService.DeleteId(id);
            return Ok();
        }
    }
}
