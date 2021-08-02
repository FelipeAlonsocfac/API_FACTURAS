using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }
        public EncabezadoFactura Encabezado { get; set; }
        public int EncabezadoId { get; set; }
    }
}
