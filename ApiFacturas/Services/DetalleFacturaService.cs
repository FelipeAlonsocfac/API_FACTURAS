using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
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
        public async Task AddDetalleFactura(DetalleFactura detalleFactura)
        {
            await _detalleFacturaRepository.AddDetalleFactura(detalleFactura);
        }
        public async Task<DetalleFactura> GetId(int id)
        {
            return await _detalleFacturaRepository.GetDetalleFactura(id);
        }
        public List<DetalleFactura> GetAll()
        {
            return _detalleFacturaRepository.GetAll();
        }
        public void UpdateDetalleFactura(DetalleFactura detalleFactura)
        {
            _detalleFacturaRepository.UpdateDetalleFactura(detalleFactura);
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
