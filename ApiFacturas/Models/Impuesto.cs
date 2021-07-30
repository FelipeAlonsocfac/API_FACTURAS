using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Models
{
    public class Impuesto
    {
        public int ImpuestoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public List<Producto> Productos{get; set;}
    }
}
