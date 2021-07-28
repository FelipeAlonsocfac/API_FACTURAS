using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
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
        public async Task AddEmpresa(Empresa empresa)
        {
            await _empresaRepository.AddEmpresa(empresa);
        }
        public async Task<Empresa> GetId(int id)
        {
            return await _empresaRepository.GetEmpresa(id);
        }
        public List<Empresa> GetAll()
        {
            return _empresaRepository.GetAll();
        }
        public void UpdateEmpresa(Empresa empresa)
        {
            _empresaRepository.UpdateEmpresa(empresa);
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
