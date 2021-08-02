using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public class ImpuestoRepository : IImpuestoRepository
    {
        private readonly IDBContext _context;
        public ImpuestoRepository(IDBContext context)
        {
            _context = context;
        }
        public async Task AddImpuesto(Impuesto impuesto)
        {//C

            await _context.Impuestos.AddAsync(impuesto);
            await _context.SaveChangesAsync();
        }
        public async Task<Impuesto> GetImpuesto(int id)
        {//R
            return await _context.Impuestos.FindAsync(id);
        }
        public List<Impuesto> GetAll()
        {
            return _context.Impuestos.Select(x => x).ToList();
        }
        public void UpdateImpuesto(Impuesto impuesto)
        {//U

            _context.Impuestos.Update(impuesto);
            _context.SaveChanges();
        }
        public async Task DeleteImpuesto(Impuesto impuesto)//D
        {
            _context.Impuestos.Remove(impuesto);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteId(int id)
        {
            var model = await GetImpuesto(id);
            await DeleteImpuesto(model);
        }
    }
}
