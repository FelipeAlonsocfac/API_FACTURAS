using ApiFacturas.Models;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IEmpresaService
    {
        Task AddEmpresa(EmpresaRequest empresa);
        Task<Empresa> GetId(int id);
        List<Empresa> GetAll();
        void UpdateEmpresa(int empresaId, EmpresaRequest empresa);
        Task DeleteEmpresa(Empresa empresa);
        Task DeleteId(int id);
    }
}
