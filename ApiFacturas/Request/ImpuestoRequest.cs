using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Request
{
    public class ImpuestoRequest
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
    }
}
