using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public interface IEncabezadoFacturaRepository
    {
        Task AddEncabezadoFactura(EncabezadoFactura encabezadoFactura);
        Task<EncabezadoFactura> GetEncabezadoFactura(int id);
        List<EncabezadoFactura> GetAll();
        void UpdateEncabezadoFactura(EncabezadoFactura encabezadoFactura);
        Task DeleteEncabezadoFactura(EncabezadoFactura encabezadoFactura);
        Task DeleteId(int id);
    }
}
