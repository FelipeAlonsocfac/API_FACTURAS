using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public Impuesto Impuesto { get; set; }
        public int ImpuestoId { get; set; }
    }
}
