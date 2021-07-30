using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        public async Task AddEmpresa(EmpresaRequest empresa)
        {
            await _empresaRepository.AddEmpresa(new Empresa {
                NIT = empresa.NIT,
                Nombre = empresa.Nombre
            });
        }
        public async Task<Empresa> GetId(int id)
        {
            return await _empresaRepository.GetEmpresa(id);
        }
        public List<Empresa> GetAll()
        {
            return _empresaRepository.GetAll();
        }
        public void UpdateEmpresa(int empresaId, EmpresaRequest empresa)
        {
            _empresaRepository.UpdateEmpresa(new Empresa {
                EmpresaId = empresaId,
                NIT = empresa.NIT,
                Nombre = empresa.Nombre
            });
        }
        public async Task DeleteEmpresa(Empresa empresa)
        {
            await _empresaRepository.DeleteEmpresa(empresa);
        }
        public async Task DeleteId(int id)
        {
            await _empresaRepository.DeleteId(id);
        }
    }
}
