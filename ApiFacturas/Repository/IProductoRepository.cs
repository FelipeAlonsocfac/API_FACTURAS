using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public interface IProductoRepository
    {
        Task AddProducto(Producto producto);
        Task<Producto> GetProducto(int id);
        List<Producto> GetAll();
        void UpdateProducto(Producto producto);
        Task DeleteProducto(Producto producto);
        Task DeleteId(int id);
    }
}
