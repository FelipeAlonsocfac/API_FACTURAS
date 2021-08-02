using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; } 
        public string NIT { get; set; }
        public string Nombre { get; set; }
        public static List<Sede> Sedes { get; set; }
    }
}
