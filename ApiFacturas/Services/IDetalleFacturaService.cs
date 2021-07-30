using ApiFacturas.Models;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IDetalleFacturaService
    {
        Task AddDetalleFactura(DetalleFacturaRequest detalleFactura);
        Task<DetalleFactura> GetId(int id);
        List<DetalleFactura> GetAll();
        void UpdateDetalleFactura(int detalleFacturaId, DetalleFacturaRequest detalleFactura);
        Task DeleteDetalleFactura(DetalleFactura detalleFactura);
        Task DeleteId(int id);
    }
}
