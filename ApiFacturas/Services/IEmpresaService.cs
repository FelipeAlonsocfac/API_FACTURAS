using ApiFacturas.Models;
using System.Collections.Generic;

namespace ApiFacturas.Services
{
    public interface IEmpresaService
    {
        public void AddEmpresa(Empresa empresa);
        public void DeleteEmpresa(int id);
        public void DeleteEmpresa(Empresa empresa);
        public List<Empresa> GetEmpresas();
        public Empresa GetEmpresa(int id);
        public Empresa UpdateEmpresa(Empresa empresa);
    }
}
