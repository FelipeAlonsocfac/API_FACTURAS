using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Request
{
    public class ClienteRequest
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Numero { get; set; }
    }
}
