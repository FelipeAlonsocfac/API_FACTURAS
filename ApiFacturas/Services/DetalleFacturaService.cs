using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiFacturas.Services
{
    public class DetalleFacturaService : IDetalleFacturaService
    {

        private readonly IDBContext _dbContext;
        public DetalleFacturaService(IDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddFactura(DetalleFactura factura) {
           
            _dbContext.DetalleFacturas.Add(factura);
            _dbContext.SaveChanges();
        }
        public void DeleteDetalleFactura(int id) {
            var factura = GetFactura(id);
            DeleteDetalleFactura(factura);
        }
        public void DeleteDetalleFactura(DetalleFactura factura)
        {
            _dbContext.DetalleFacturas.Remove(factura);
            _dbContext.SaveChanges();
        }
        public List<DetalleFactura> GetFacturas() {
            return _dbContext.DetalleFacturas.Select(x => x).ToList();
        }
        public DetalleFactura GetFactura(int id) {
            return _dbContext.DetalleFacturas.Where(x => x.Id == id).FirstOrDefault();
        }
        public DetalleFactura UpdateDetalleFactura(DetalleFactura factura) {

            var factUpdated = _dbContext.DetalleFacturas.Update(factura).Entity;
            _dbContext.SaveChanges();
            return factUpdated;
        }
    }
}
