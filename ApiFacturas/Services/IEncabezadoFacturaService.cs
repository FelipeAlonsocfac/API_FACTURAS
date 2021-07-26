using ApiFacturas.Models;
using System.Collections.Generic;

namespace ApiFacturas.Services
{
    public interface IEncabezadoFacturaService
    {
        public void AddEncabezadoFactura(EncabezadoFactura encabezado);
        public void DeleteEncabezadoFactura(int id);
        public void DeleteEncabezadoFactura(EncabezadoFactura encabezado);
        public List<EncabezadoFactura> GetEncabezadoFacturas();
        public EncabezadoFactura GetEncabezadoFactura(int id);
        public EncabezadoFactura UpdateEncabezadoFactura(EncabezadoFactura encabezado);
    }
}
