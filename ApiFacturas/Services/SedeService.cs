using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiFacturas.Services
{
    public class SedeService : ISedeService
    {
        private readonly IDBContext _dbContext;
        public SedeService(IDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddSede(Sede sede)
        {

            _dbContext.Sedes.Add(sede);
            _dbContext.SaveChanges();
        }
        public void DeleteSede(int id)
        {
            var sede = GetSede(id);
            DeleteSede(sede);
        }
        public void DeleteSede(Sede sede)
        {
            _dbContext.Sedes.Remove(sede);
            _dbContext.SaveChanges();
        }
        public List<Sede> GetSedes()
        {
            return _dbContext.Sedes.Select(x => x).ToList();
        }
        public Sede GetSede(int id)
        {
            return _dbContext.Sedes.Where(x => x.SedeId == id).FirstOrDefault();
        }
        public Sede UpdateSede(Sede sede)
        {

            var sedeUpdated = _dbContext.Sedes.Update(sede).Entity;
            _dbContext.SaveChanges();
            return sedeUpdated;
        }
    }
}
