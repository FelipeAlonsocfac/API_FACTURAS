using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using ApiFacturas.Request;
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
        public async Task AddEncabezadoFactura(EncabezadoFacturaRequest encabezadoFactura)
        {
            await _encabezadoFacturaRepository.AddEncabezadoFactura(new EncabezadoFactura {
                NumeroFactura = encabezadoFactura.NumeroFactura,
                MetodoPago = encabezadoFactura.MetodoPago,
                Fecha = encabezadoFactura.Fecha,
                Total = encabezadoFactura.Total,
                ClienteID = encabezadoFactura.ClienteID,
                SedeId = encabezadoFactura.SedeId
            });
        }
        public async Task<EncabezadoFactura> GetId(int id)
        {
            return await _encabezadoFacturaRepository.GetEncabezadoFactura(id);
        }
        public List<EncabezadoFactura> GetAll()
        {
            return _encabezadoFacturaRepository.GetAll();
        }
        public void UpdateEncabezadoFactura(int encabezadoFacturaId, EncabezadoFacturaRequest encabezadoFactura)
        {
            _encabezadoFacturaRepository.UpdateEncabezadoFactura(new EncabezadoFactura {
                Id = encabezadoFacturaId,
                NumeroFactura = encabezadoFactura.NumeroFactura,
                MetodoPago = encabezadoFactura.MetodoPago,
                Fecha = encabezadoFactura.Fecha,
                Total = encabezadoFactura.Total,
                ClienteID = encabezadoFactura.ClienteID,
                SedeId = encabezadoFactura.SedeId
            });
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
