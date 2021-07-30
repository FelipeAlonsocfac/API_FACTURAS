using ApiFacturas.Models;
using ApiFacturas.Request;
using ApiFacturas.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiFacturas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;
        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public List<Producto> Get(){

            return _productoService.GetAll();
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public async Task<Producto> Get(int id)
        {
            return await _productoService.GetId(id);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public async Task Post([FromBody] ProductoRequest producto)
        {
            await _productoService.AddProducto(producto);
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductoRequest producto)
        {
            _productoService.UpdateProducto(id, producto);
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productoService.DeleteId(id);
            return Ok();
        }
    }
}
