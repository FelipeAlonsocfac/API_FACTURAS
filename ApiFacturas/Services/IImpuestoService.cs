﻿using ApiFacturas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IImpuestoService
    {
        Task AddImpuesto(Impuesto impuesto);
        Task<Impuesto> GetId(int id);
        List<Impuesto> GetAll();
        void UpdateImpuesto(Impuesto impuesto);
        Task DeleteImpuesto(Impuesto impuesto);
        Task DeleteId(int id);
    }
}
