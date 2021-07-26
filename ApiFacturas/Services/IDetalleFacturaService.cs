using ApiFacturas.Models;
using System.Collections.Generic;

namespace ApiFacturas.Services
{
    public interface IDetalleFacturaService
    {
        public void AddFactura(DetalleFactura factura);
        public void DeleteDetalleFactura(int id);
        public void DeleteDetalleFactura(DetalleFactura factura);
        public List<DetalleFactura> GetFacturas();
        public DetalleFactura GetFactura(int id);
        public DetalleFactura UpdateDetalleFactura(DetalleFactura factura);
    }
}
