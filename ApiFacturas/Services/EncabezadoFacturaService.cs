using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiFacturas.Services
{
    public class EncabezadoFacturaService : IEncabezadoFacturaService
    {
        private readonly IDBContext _dbContext;
        public EncabezadoFacturaService(IDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddEncabezadoFactura(EncabezadoFactura encabezado)
        {

            _dbContext.EncabezadosFacturas.Add(encabezado);
            _dbContext.SaveChanges();
        }
        public void DeleteEncabezadoFactura(int id)
        {
            var encabezado = GetEncabezadoFactura(id);
            DeleteEncabezadoFactura(encabezado);
        }
        public void DeleteEncabezadoFactura(EncabezadoFactura encabezado)
        {
            _dbContext.EncabezadosFacturas.Remove(encabezado);
            _dbContext.SaveChanges();
        }
        public List<EncabezadoFactura> GetEncabezadoFacturas()
        {
            return _dbContext.EncabezadosFacturas.Select(x => x).ToList();
        }
        public EncabezadoFactura GetEncabezadoFactura(int id)
        {
            return _dbContext.EncabezadosFacturas.Where(x => x.Id == id).FirstOrDefault();
        }
        public EncabezadoFactura UpdateEncabezadoFactura(EncabezadoFactura encabezado)
        {

            var encabezadoUpdated = _dbContext.EncabezadosFacturas.Update(encabezado).Entity;
            _dbContext.SaveChanges();
            return encabezadoUpdated;
        }
    }
}
