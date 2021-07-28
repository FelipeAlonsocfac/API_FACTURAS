using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public interface ISedeRepository
    {
        Task AddSede(Sede sede);
        Task<Sede> GetSede(int id);
        List<Sede> GetAll();
        void UpdateSede(Sede sede);
        Task DeleteSede(Sede sede);
        Task DeleteId(int id);
    }
}
