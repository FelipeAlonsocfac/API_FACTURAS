using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public class SedeRepository : ISedeRepository
    {
        private readonly IDBContext _context;
        public SedeRepository(IDBContext context)
        {
            _context = context;
        }
        public async Task AddSede(Sede sede)
        {//C

            await _context.Sedes.AddAsync(sede);
            await _context.SaveChangesAsync();
        }
        public async Task<Sede> GetSede(int id)
        {//R
            return await _context.Sedes.FindAsync(id);
        }
        public List<Sede> GetAll()
        {
            return _context.Sedes.Select(x => x).ToList();
        }
        public void UpdateSede(Sede sede)
        {//U

            _context.Sedes.Update(sede);
            _context.SaveChanges();
        }
        public async Task DeleteSede(Sede sede)//D
        {
            _context.Sedes  .Remove(sede);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteId(int id)
        {
            var model = await GetSede(id);
            await DeleteSede(model);
        }
    }
}
