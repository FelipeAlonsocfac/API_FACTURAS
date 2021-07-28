using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public interface IImpuestoRepository
    {
        Task AddImpuesto(Impuesto impuesto);
        Task<Impuesto> GetImpuesto(int id);
        List<Impuesto> GetAll();
        void UpdateImpuesto(Impuesto impuesto);
        Task DeleteImpuesto(Impuesto impuesto);
        Task DeleteId(int id);
    }
}
