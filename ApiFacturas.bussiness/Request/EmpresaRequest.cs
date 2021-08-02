using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Request
{
    public class EmpresaRequest
    {
        public string NIT { get; set; }
        public string Nombre { get; set; }
    }
}