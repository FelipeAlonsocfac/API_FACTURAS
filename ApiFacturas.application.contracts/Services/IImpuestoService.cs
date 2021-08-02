using ApiFacturas.Models;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IImpuestoService
    {
        Task AddImpuesto(ImpuestoRequest impuesto);
        Task<Impuesto> GetId(int id);
        List<Impuesto> GetAll();
        void UpdateImpuesto(int impuestoId, ImpuestoRequest impuesto);
        Task DeleteImpuesto(Impuesto impuesto);
        Task DeleteId(int id);
    }
}
