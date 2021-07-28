using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly IDBContext _context;
        public EmpresaRepository(IDBContext context)
        {
            _context = context;
        }
        public async Task AddEmpresa(Empresa empresa)
        {//C

            await _context.Empresas.AddAsync(empresa);
            await _context.SaveChangesAsync();
        }
        public async Task<Empresa> GetEmpresa(int id)
        {//R
            return await _context.Empresas.FindAsync(id);
        }
        public List<Empresa> GetAll()
        {
            return _context.Empresas.Select(x => x).ToList();
        }
        public void UpdateEmpresa(Empresa empresa)
        {//U

            _context.Empresas.Update(empresa);
            _context.SaveChanges();
        }
        public async Task DeleteEmpresa(Empresa empresa)//D
        {
            _context.Empresas.Remove(empresa);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteId(int id)
        {
            var model = await GetEmpresa(id);
            await DeleteEmpresa(model);
        }
    }
}
