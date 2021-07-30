using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Models
{
    public class EncabezadoFactura
    {
        public int Id { get; set; }
        public string NFactura { get; set; }
        public string MetodoPago { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteID { get; set; }
        public Sede Sede { get; set; }
        public int SedeId { get; set; }
        public List<DetalleFactura> DetallesFacturas { get; set; }
    }
}
