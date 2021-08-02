using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public class ProductoRepository : IProductoRepository
    {

        private readonly IDBContext _context;
        public ProductoRepository(IDBContext context)
        {
            _context = context;
        }

        public async Task AddProducto(Producto producto) {//C
            
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
        }
        public async Task<Producto> GetProducto(int id){//R
            return await _context.Productos.FindAsync(id);
        }
        public List<Producto> GetAll()
        {
            return _context.Productos.Select(x => x).ToList();
        }
        public void UpdateProducto(Producto producto){//U

            _context.Productos.Update(producto);
            _context.SaveChanges();
        }
        public async Task DeleteProducto(Producto producto)//D
        {
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteId(int id)
        {
            var model = await GetProducto(id);
            await DeleteProducto(model);
        }

    }
}
