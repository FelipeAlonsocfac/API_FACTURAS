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
        public Impuesto Iva { get; set; }
        public int IvaId { get; set; }
    }
}
