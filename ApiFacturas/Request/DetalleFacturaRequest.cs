using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Request
{
    public class DetalleFacturaRequest
    {
        public int Cantidad { get; set; }
        public double Total { get; set; }
        public int ProductoId { get; set; }
        public int EncabezadoId { get; set; }
    }
}
