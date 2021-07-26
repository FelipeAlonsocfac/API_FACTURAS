using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFacturas.Models;
using ApiFacturas.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiFacturas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDetalleFacturaService _facturaService;
        private readonly IClienteService _clienteService;
        private readonly IEmpresaService _empresaService;
        private readonly IEncabezadoFacturaService _encabezadoFacturaService;
        private readonly IProductoService _productoService;
        private readonly ISedeService _sedeService;
        public ValuesController(IDetalleFacturaService facturaService, IClienteService clienteService, IEmpresaService empresaService,
                                IEncabezadoFacturaService encabezadoFacturaService, IProductoService productoService, ISedeService sedeService)
        {
            _facturaService = facturaService;
            _clienteService = clienteService;
            _empresaService = empresaService;
            _encabezadoFacturaService = encabezadoFacturaService;
            _productoService = productoService;
            _sedeService = sedeService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //_facturaService.AddFactura(new Deta {
                
            //    Nit = 1,
            //    MetodoPago = "efectivo",
            //    Total = 0,
            //    Fecha = DateTime.Now

            //});


            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}