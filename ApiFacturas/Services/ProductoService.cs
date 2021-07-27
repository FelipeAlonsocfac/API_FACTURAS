using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;
        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        public async Task AddProducto(Producto producto)
        {
            await _productoRepository.AddProducto(producto);
        }
        public async Task<Producto> GetId(int id)
        {
            return await _productoRepository.GetProducto(id);
        }
        public List<Producto> GetAll()
        {
            return _productoRepository.GetAll();
        }
        public void UpdateProducto(Producto producto)
        {
            _productoRepository.UpdateProducto(producto);
        }
        public async Task DeleteProducto(Producto producto)
        {
            await _productoRepository.DeleteProducto(producto);
        }
        public async Task DeleteId(int id)
        {
            await _productoRepository.DeleteId(id);
        }
    }
}
