using ApiFacturas.Models;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IEncabezadoFacturaService
    {
        Task AddEncabezadoFactura(EncabezadoFacturaRequest encabezadoFactura);
        Task<EncabezadoFactura> GetId(int id);
        List<EncabezadoFactura> GetAll();
        void UpdateEncabezadoFactura(int encabezadoFacturaId, EncabezadoFacturaRequest encabezadoFactura);
        Task DeleteEncabezadoFactura(EncabezadoFactura encabezadoFactura);
        Task DeleteId(int id);
    }
}
