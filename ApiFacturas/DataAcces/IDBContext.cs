using ApiFacturas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        DbSet<Impuesto> Impuestos { get; set; }
        //dbcontextmethods
        DbSet<TEntity> Set<TEntity>([NotNullAttribute] string name) where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();

        void RemoveRange([NotNullAttribute] IEnumerable<object> entities);
        EntityEntry Update([NotNullAttribute] object entity);
    }
}
