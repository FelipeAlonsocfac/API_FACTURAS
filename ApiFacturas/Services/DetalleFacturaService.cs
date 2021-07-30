using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public class DetalleFacturaService : IDetalleFacturaService
    {

        private readonly IDetalleFacturaRepository _detalleFacturaRepository;
        public DetalleFacturaService(IDetalleFacturaRepository detalleFacturaRepository)
        {
            _detalleFacturaRepository = detalleFacturaRepository;
        }
        public async Task AddDetalleFactura(DetalleFacturaRequest detalleFactura)
        {
            await _detalleFacturaRepository.AddDetalleFactura(new DetalleFactura { 
                Cantidad = detalleFactura.Cantidad,
                Total = detalleFactura.Total,
                ProductoId = detalleFactura.ProductoId,
                EncabezadoId = detalleFactura.EncabezadoId
            });
        }
        public async Task<DetalleFactura> GetId(int id)
        {
            return await _detalleFacturaRepository.GetDetalleFactura(id);
        }
        public List<DetalleFactura> GetAll()
        {
            return _detalleFacturaRepository.GetAll();
        }
        public void UpdateDetalleFactura(int detalleFacturaId, DetalleFacturaRequest detalleFactura)
        {
            _detalleFacturaRepository.UpdateDetalleFactura(new DetalleFactura {
                Id = detalleFacturaId,
                Cantidad = detalleFactura.Cantidad,
                Total = detalleFactura.Total,
                ProductoId = detalleFactura.ProductoId,
                EncabezadoId = detalleFactura.EncabezadoId
            });
        }
        public async Task DeleteDetalleFactura(DetalleFactura detalleFactura)
        {
            await _detalleFacturaRepository.DeleteDetalleFactura(detalleFactura);
        }
        public async Task DeleteId(int id)
        {
            await _detalleFacturaRepository.DeleteId(id);
        }
    }
}
