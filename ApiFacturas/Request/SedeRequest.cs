using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Request
{
    public class SedeRequest
    {
        public int SedeId { get; set; }
        public string Nombre { get; set; }
        public int EmpresaId { get; set; }
        public string Direccion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public int ZipCode { get; set; }
        public long Telefono { get; set; }
    }
}
