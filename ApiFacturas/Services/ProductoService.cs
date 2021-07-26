using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiFacturas.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IDBContext _dbContext;
        public ProductoService(IDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddProducto(Producto producto)
        {

            _dbContext.Productos.Add(producto);
            _dbContext.SaveChanges();
        }
        public void DeleteProducto(int id)
        {
            var producto = GetProducto(id);
            DeleteProducto(producto);
        }
        public void DeleteProducto(Producto producto)
        {
            _dbContext.Productos.Remove(producto);
            _dbContext.SaveChanges();
        }
        public List<Producto> GetProductos()
        {
            return _dbContext.Productos.Select(x => x).ToList();
        }
        public Producto GetProducto(int id)
        {
            return _dbContext.Productos.Where(x => x.ProductoId == id).FirstOrDefault();
        }
        public Producto UpdateProducto(Producto producto)
        {

            var productoUpdated = _dbContext.Productos.Update(producto).Entity;
            _dbContext.SaveChanges();
            return productoUpdated;
        }
    }
}
