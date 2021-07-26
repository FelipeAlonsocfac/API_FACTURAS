using ApiFacturas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiFacturas.DataAcces
{
    public interface IDBContext
    {

        DbSet<DetalleFactura> DetalleFacturas { get; set; }
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Empresa> Empresas { get; set; }
        DbSet<EncabezadoFactura> EncabezadosFacturas { get; set; }
        DbSet<Producto> Productos { get; set; }
        DbSet<Sede> Sedes { get; set; }
        public DbSet<Impuesto> Impuestos { get; set; }
        int SaveChanges();
        
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
