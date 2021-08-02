using ApiFacturas.Models;
using ApiFacturas.Request;
using ApiFacturas.Services;
using AutoMapper;
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
    public class AController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClienteService _clienteService;
        public AController(IMapper mapper, IClienteService clienteService)
        {
            _mapper = mapper;
            _clienteService = clienteService;
        }
        // GET: api/<ProductoController 
        //[HttpGet]
        //public List<Cliente> Get()
        //{
        //    return _clienteService.GetAll();
        //}
        //// GET api/<ProductoController>/5
        //[HttpGet("{id}")]
        //public async Task<Cliente> Get(int id)
        //{
        //    return await _clienteService.GetId(id);
        //}
        //// POST api/<ProductoController>
        //[HttpPost]
        //public async Task Post([FromBody] ClienteRequest cliente)
        //{
        //    _mapper.Map<ClienteRequest>
        //    await _clienteService.AddCliente(cliente);
        //} 
        // // PUT api/<ProductoController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] ClienteRequest cliente)
        //{
        //    _clienteService.UpdateCliente(id, cliente);
        //}
        //// DELETE api/<ProductoController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    await _clienteService.DeleteId(id);
        //    return Ok();
        //}
    }
}
