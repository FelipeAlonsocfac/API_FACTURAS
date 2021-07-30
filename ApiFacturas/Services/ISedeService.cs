using ApiFacturas.Models;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface ISedeService
    {
        Task AddSede(SedeRequest sede);
        Task<Sede> GetId(int id);
        List<Sede> GetAll();
        void UpdateSede(int sedeId, SedeRequest sede);
        Task DeleteSede(Sede sede);
        Task DeleteId(int id);
    }
}
