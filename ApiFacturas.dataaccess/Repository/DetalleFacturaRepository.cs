using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public class DetalleFacturaRepository : IDetalleFacturaRepository
    {
        private readonly IDBContext _context;
        public DetalleFacturaRepository(IDBContext context)
        {
            _context = context;
        }
        public async Task AddDetalleFactura(DetalleFactura detalleFactura)
        {//C
            await _context.DetalleFacturas.AddAsync(detalleFactura);
            await _context.SaveChangesAsync();
        }
        public async Task<DetalleFactura> GetDetalleFactura(int id)
        {//R
            return await _context.DetalleFacturas.FindAsync(id);
        }
        public List<DetalleFactura> GetAll()
        {
            return _context.DetalleFacturas.Select(x => x).ToList();
        }
        public void UpdateDetalleFactura(DetalleFactura detalleFactura)
        {//U

            _context.DetalleFacturas.Update(detalleFactura);
            _context.SaveChanges();
        }
        public async Task DeleteDetalleFactura(DetalleFactura detalleFactura)//D
        {
            _context.DetalleFacturas.Remove(detalleFactura);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteId(int id)
        {
            var model = await GetDetalleFactura(id);
            await DeleteDetalleFactura(model);
        }
    }
}
