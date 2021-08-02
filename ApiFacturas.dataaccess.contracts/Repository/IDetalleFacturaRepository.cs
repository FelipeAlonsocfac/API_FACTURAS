using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public interface IDetalleFacturaRepository
    {
        Task AddDetalleFactura(DetalleFactura detalleFactura);
        Task<DetalleFactura> GetDetalleFactura(int id);
        List<DetalleFactura> GetAll();
        void UpdateDetalleFactura(DetalleFactura detalleFactura);
        Task DeleteDetalleFactura(DetalleFactura detalleFactura);
        Task DeleteId(int id);
    }
}
