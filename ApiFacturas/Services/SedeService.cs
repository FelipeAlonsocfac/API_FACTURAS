using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using ApiFacturas.Request;
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
        public async Task AddSede(SedeRequest sede)
        {
            await _sedeRepository.AddSede(new Sede {

                Nombre = sede.Nombre,
                Direccion = sede.Direccion,
                Pais = sede.Pais,
                Ciudad = sede.Ciudad,
                ZipCode = sede.ZipCode,
                Telefono = sede.Telefono,
                EmpresaId = sede.EmpresaId
            });
        }
        public async Task<Sede> GetId(int id)
        {
            return await _sedeRepository.GetSede(id);
        }
        public List<Sede> GetAll()
        {
            return _sedeRepository.GetAll();
        }
        public void UpdateSede(int sedeId, SedeRequest sede)
        {
            _sedeRepository.UpdateSede(new Sede {
                SedeId = sedeId,
                Nombre = sede.Nombre,
                Direccion = sede.Direccion,
                Pais = sede.Pais,
                Ciudad = sede.Ciudad,
                ZipCode = sede.ZipCode,
                Telefono = sede.Telefono,
                EmpresaId = sede.EmpresaId
            });
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
