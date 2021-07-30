using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Request
{
    public class ProductoRequest
    {
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public int ImpuestoId { get; set; }
    }
}
