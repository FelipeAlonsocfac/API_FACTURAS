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
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;
        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }
        // GET: api/<ProductoController 
        [HttpGet]
        public List<Empresa> Get()
        {

            return _empresaService.GetAll();
        }
        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public async Task<Empresa> Get(int id)
        {
            return await _empresaService.GetId(id);
        }
        // POST api/<ProductoController>
        [HttpPost]
        public async Task Post([FromBody] Empresa empresa)
        {
            await _empresaService.AddEmpresa(empresa);
        }
            
         // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Empresa empresa)
        {
            _empresaService.UpdateEmpresa(empresa);
        }
        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _empresaService.DeleteId(id);
            return Ok();
        }
    }
}
