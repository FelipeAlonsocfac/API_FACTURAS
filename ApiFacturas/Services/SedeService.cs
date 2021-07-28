using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public class SedeService : ISedeService
    {
        private readonly ISedeRepository _sedeRepository;
        public SedeService(ISedeRepository sedeRepository)
        {
            _sedeRepository = sedeRepository;
        }
        public async Task AddSede(Sede sede)
        {
            await _sedeRepository.AddSede(sede);
        }
        public async Task<Sede> GetId(int id)
        {
            return await _sedeRepository.GetSede(id);
        }
        public List<Sede> GetAll()
        {
            return _sedeRepository.GetAll();
        }
        public void UpdateSede(Sede sede)
        {
            _sedeRepository.UpdateSede(sede);
        }
        public async Task DeleteSede(Sede sede)
        {
            await _sedeRepository.DeleteSede(sede);
        }
        public async Task DeleteId(int id)
        {
            await _sedeRepository.DeleteId(id);
        }
    }
}
