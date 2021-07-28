﻿using ApiFacturas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IDetalleFacturaService
    {
        Task AddDetalleFactura(DetalleFactura detalleFactura);
        Task<DetalleFactura> GetId(int id);
        List<DetalleFactura> GetAll();
        void UpdateDetalleFactura(DetalleFactura detalleFactura);
        Task DeleteDetalleFactura(DetalleFactura detalleFactura);
        Task DeleteId(int id);
    }
}
