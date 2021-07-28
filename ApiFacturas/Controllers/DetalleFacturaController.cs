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
    public class DetalleFacturaController : ControllerBase
    {
        private readonly IDetalleFacturaService _detalleFacturaService;
        public DetalleFacturaController(IDetalleFacturaService detalleFacturaService)
        {
            _detalleFacturaService = detalleFacturaService;
        }
        // GET: api/<ProductoController 
        [HttpGet]
        public List<DetalleFactura> Get()
        {

            return _detalleFacturaService.GetAll();
        }
        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public async Task<DetalleFactura> Get(int id)
        {
            return await _detalleFacturaService.GetId(id);
        }
        // POST api/<ProductoController>
        [HttpPost]
        public async Task Post([FromBody] DetalleFactura detalleFactura)
        {
            await _detalleFacturaService.AddDetalleFactura(detalleFactura);
        } 
        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] DetalleFactura detalleFactura)
        {
            _detalleFacturaService.UpdateDetalleFactura(detalleFactura);
        }
        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _detalleFacturaService.DeleteId(id);
            return Ok();
        }
    }
}
