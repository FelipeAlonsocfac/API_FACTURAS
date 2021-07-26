using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Models
{
    public class Sede
    {
        public int SedeId { get; set; }
        public string Nombre { get; set; }
        public Empresa Empresa { get; set; }
        public string Direccion { get; set; }
    }
}
