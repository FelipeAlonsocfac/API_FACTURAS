using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using ApiFacturas.Request;
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
        public async Task AddProducto(ProductoRequest producto)
        {
            await _productoRepository.AddProducto(new Producto {
                Descripcion = producto.Descripcion,
                Valor = producto.Valor,
                ImpuestoId = producto.ImpuestoId
    });
        }
        public async Task<Producto> GetId(int id)
        {
            return await _productoRepository.GetProducto(id);
        }
        public List<Producto> GetAll()
        {
            return _productoRepository.GetAll();
        }
        public void UpdateProducto(int productoId, ProductoRequest producto)
        {
            _productoRepository.UpdateProducto(new Producto {
                ProductoId = productoId,
                Descripcion = producto.Descripcion,
                Valor = producto.Valor,
                ImpuestoId = producto.ImpuestoId
            });
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
