using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public interface IEmpresaRepository
    {
        Task AddEmpresa(Empresa empresa);
        Task<Empresa> GetEmpresa(int id);
        List<Empresa> GetAll();
        void UpdateEmpresa(Empresa empresa);
        Task DeleteEmpresa(Empresa empresa);
        Task DeleteId(int id);
    }
}
