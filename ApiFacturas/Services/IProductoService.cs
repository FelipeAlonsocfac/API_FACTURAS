﻿using ApiFacturas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IProductoService
    {
        Task AddProducto(Producto producto);
        Task<Producto> GetId(int id);
        List<Producto> GetAll();
        void UpdateProducto(Producto producto);
        Task DeleteProducto(Producto producto);
        Task DeleteId(int id);
    }
}