using ApiFacturas.Models;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IProductoService
    {
        Task AddProducto(ProductoRequest producto);
        Task<Producto> GetId(int id);
        List<Producto> GetAll();
        void UpdateProducto(int productoId, ProductoRequest producto);
        Task DeleteProducto(Producto producto);
        Task DeleteId(int id);
    }
}
