using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiFacturas.Services
{
    public class ImpuestoService : IImpuestoService
    {
        private readonly IDBContext _dbContext;
        public ImpuestoService(IDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddImpuesto(Impuesto impuesto)
        {

            _dbContext.Impuestos.Add(impuesto);
            _dbContext.SaveChanges();
        }
        public void DeleteImpuesto(int id)
        {
            var impuesto = GetImpuesto(id);
            DeleteImpuesto(impuesto);
        }
        public void DeleteImpuesto(Impuesto impuesto)
        {
            _dbContext.Impuestos.Remove(impuesto);
            _dbContext.SaveChanges();
        }
        public List<Impuesto> GetImpuestos()
        {
            return _dbContext.Impuestos.Select(x => x).ToList();
        }
        public Impuesto GetImpuesto(int id)
        {
            return _dbContext.Impuestos.Where(x => x.ImpuestoId == id).FirstOrDefault();
        }
        public Impuesto UpdateImpuesto(Impuesto impuesto)
        {

            var impuestoUpdated = _dbContext.Impuestos.Update(impuesto).Entity;
            _dbContext.SaveChanges();
            return impuestoUpdated;
        }
    }
}
