using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public class EncabezadoFacturaService : IEncabezadoFacturaService
    {
        private readonly IEncabezadoFacturaRepository _encabezadoFacturaRepository;
        public EncabezadoFacturaService(IEncabezadoFacturaRepository encabezadoFacturaRepository)
        {
            _encabezadoFacturaRepository = encabezadoFacturaRepository;
        }
        public async Task AddEncabezadoFactura(EncabezadoFactura encabezadoFactura)
        {
            await _encabezadoFacturaRepository.AddEncabezadoFactura(encabezadoFactura);
        }
        public async Task<EncabezadoFactura> GetId(int id)
        {
            return await _encabezadoFacturaRepository.GetEncabezadoFactura(id);
        }
        public List<EncabezadoFactura> GetAll()
        {
            return _encabezadoFacturaRepository.GetAll();
        }
        public void UpdateEncabezadoFactura(EncabezadoFactura encabezadoFactura)
        {
            _encabezadoFacturaRepository.UpdateEncabezadoFactura(encabezadoFactura);
        }
        public async Task DeleteEncabezadoFactura(EncabezadoFactura encabezadoFactura)
        {
            await _encabezadoFacturaRepository.DeleteEncabezadoFactura(encabezadoFactura);
        }
        public async Task DeleteId(int id)
        {
            await _encabezadoFacturaRepository.DeleteId(id);
        }
    }
}
