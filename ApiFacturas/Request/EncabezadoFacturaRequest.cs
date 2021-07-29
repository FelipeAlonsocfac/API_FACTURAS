using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Request
{
    public class EncabezadoFacturaRequest
    {
        public int Id { get; set; }
        public int ClienteID { get; set; }
        public int SedeId { get; set; }
    }
}
