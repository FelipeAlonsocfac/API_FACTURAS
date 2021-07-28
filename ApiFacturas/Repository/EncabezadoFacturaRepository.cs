using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public class EncabezadoFacturaRepository : IEncabezadoFacturaRepository
    {
        private readonly IDBContext _context;
        public EncabezadoFacturaRepository(IDBContext context)
        {
            _context = context;
        }
        public async Task AddEncabezadoFactura(EncabezadoFactura encabezadoFactura)
        {//C
            await _context.EncabezadosFacturas.AddAsync(encabezadoFactura);
            await _context.SaveChangesAsync();
        }
        public async Task<EncabezadoFactura> GetEncabezadoFactura(int id)
        {//R
            return await _context.EncabezadosFacturas.FindAsync(id);
        }
        public List<EncabezadoFactura> GetAll()
        {
            return _context.EncabezadosFacturas.Select(x => x).ToList();
        }
        public void UpdateEncabezadoFactura(EncabezadoFactura encabezadoFactura)
        {//U

            _context.EncabezadosFacturas.Update(encabezadoFactura);
            _context.SaveChanges();
        }
        public async Task DeleteEncabezadoFactura(EncabezadoFactura encabezadoFactura)//D
        {
            _context.EncabezadosFacturas.Remove(encabezadoFactura);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteId(int id)
        {
            var model = await GetEncabezadoFactura(id);
            await DeleteEncabezadoFactura(model);
        }
    }
}
