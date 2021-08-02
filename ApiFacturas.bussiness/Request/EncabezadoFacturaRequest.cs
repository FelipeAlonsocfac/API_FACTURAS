using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Request
{
    public class EncabezadoFacturaRequest
    {
        public string NumeroFactura { get; set; }
        public string MetodoPago { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public int ClienteID { get; set; }
        public int SedeId { get; set; }
    }
}
