using ApiFacturas.Models;
using System.Collections.Generic;

namespace ApiFacturas.Services
{
    public interface ISedeService
    {
        public void AddSede(Sede sede);
        public void DeleteSede(int id);
        public void DeleteSede(Sede sede);
        public List<Sede> GetSedes();
        public Sede GetSede(int id);
        public Sede UpdateSede(Sede sede);
    }
}
