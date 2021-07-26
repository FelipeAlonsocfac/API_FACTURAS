using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiFacturas.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IDBContext _dbContext;
        public EmpresaService(IDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddEmpresa(Empresa empresa)
        {

            _dbContext.Empresas.Add(empresa);
            _dbContext.SaveChanges();
        }
        public void DeleteEmpresa(int id)
        {
            var empresa = GetEmpresa(id);
            DeleteEmpresa(empresa);
        }
        public void DeleteEmpresa(Empresa empresa)
        {
            _dbContext.Empresas.Remove(empresa);
            _dbContext.SaveChanges();
        }
        public List<Empresa> GetEmpresas()
        {
            return _dbContext.Empresas.Select(x => x).ToList();
        }
        public Empresa GetEmpresa(int id)
        {
            return _dbContext.Empresas.Where(x => x.EmpresaId== id).FirstOrDefault();
        }
        public Empresa UpdateEmpresa(Empresa empresa)
        {

            var empUpdated = _dbContext.Empresas.Update(empresa).Entity;
            _dbContext.SaveChanges();
            return empUpdated;
        }
    }
}
