using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public List<int> Cantidad { get; set; }
        public double Total { get; set; }
        List<Producto> Productos { get; set; }
        public int ProductoId { get; set; }
        public EncabezadoFactura Encabezado { get; set; }
        public int EncabezadoId { get; set; }
    }
}
