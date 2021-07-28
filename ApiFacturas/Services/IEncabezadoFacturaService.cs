﻿using ApiFacturas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IEncabezadoFacturaService
    {
        Task AddEncabezadoFactura(EncabezadoFactura encabezadoFactura);
        Task<EncabezadoFactura> GetId(int id);
        List<EncabezadoFactura> GetAll();
        void UpdateEncabezadoFactura(EncabezadoFactura encabezadoFactura);
        Task DeleteEncabezadoFactura(EncabezadoFactura encabezadoFactura);
        Task DeleteId(int id);
    }
}
