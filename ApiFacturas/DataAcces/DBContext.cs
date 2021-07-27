using ApiFacturas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiFacturas.DataAcces
{
    public class DBContext : DbContext, IDBContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<DetalleFactura> DetalleFacturas{get; set;}
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EncabezadoFactura> EncabezadosFacturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Impuesto> Impuestos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<DetalleFactura>().ToTable("DetalleFacturas");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Empresa>().ToTable("Empresas");
            modelBuilder.Entity<EncabezadoFactura>().ToTable("EncabezadosFacturas");
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<Sede>().ToTable("Sedes");
            modelBuilder.Entity<Impuesto>().ToTable("Impuestos");
        }
    }
}
