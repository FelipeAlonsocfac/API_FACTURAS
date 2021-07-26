using ApiFacturas.Models;
using System.Collections.Generic;

namespace ApiFacturas.Services
{
    public interface IProductoService
    {
        public void AddProducto(Producto producto);
        public void DeleteProducto(int id);
        public void DeleteProducto(Producto producto);
        public List<Producto> GetProductos();
        public Producto GetProducto(int id);
        public Producto UpdateProducto(Producto producto);
    }
}
