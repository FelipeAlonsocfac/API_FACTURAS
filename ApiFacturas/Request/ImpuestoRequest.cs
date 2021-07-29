using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Request
{
    public class ImpuestoRequest
    {
        public int ImpuestoId { get; set; }
        string Descripcion { get; set; }
        public double Valor { get; set; }
    }
}
