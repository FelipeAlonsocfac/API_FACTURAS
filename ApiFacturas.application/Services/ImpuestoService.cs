using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using ApiFacturas.Request;
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
        public async Task AddImpuesto(ImpuestoRequest impuesto)
        {
            await _impuestoRepository.AddImpuesto(new Impuesto {
                Nombre = impuesto.Nombre,
                Descripcion = impuesto.Descripcion,
                Valor = impuesto.Valor
            });
        }
        public async Task<Impuesto> GetId(int id)
        {
            return await _impuestoRepository.GetImpuesto(id);
        }
        public List<Impuesto> GetAll()
        {
            return _impuestoRepository.GetAll();
        }
        public void UpdateImpuesto(int impuestoId, ImpuestoRequest impuesto)
        {
            _impuestoRepository.UpdateImpuesto(new Impuesto {
                ImpuestoId = impuestoId,
                Nombre = impuesto.Nombre,
                Descripcion = impuesto.Descripcion,
                Valor = impuesto.Valor
            });
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
