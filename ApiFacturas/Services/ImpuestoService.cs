using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public class ImpuestoService : IImpuestoService
    {
        private readonly IImpuestoRepository _impuestoRepository;
        public ImpuestoService(IImpuestoRepository impuestoRepository)
        {
            _impuestoRepository = impuestoRepository;
        }
        public async Task AddImpuesto(Impuesto impuesto)
        {
            await _impuestoRepository.AddImpuesto(impuesto);
        }
        public async Task<Impuesto> GetId(int id)
        {
            return await _impuestoRepository.GetImpuesto(id);
        }
        public List<Impuesto> GetAll()
        {
            return _impuestoRepository.GetAll();
        }
        public void UpdateImpuesto(Impuesto impuesto)
        {
            _impuestoRepository.UpdateImpuesto(impuesto);
        }
        public async Task DeleteImpuesto(Impuesto impuesto)
        {
            await _impuestoRepository.DeleteImpuesto(impuesto);
        }
        public async Task DeleteId(int id)
        {
            await _impuestoRepository.DeleteId(id);
        }
    }
}
