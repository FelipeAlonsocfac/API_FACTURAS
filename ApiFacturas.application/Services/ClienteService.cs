using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using ApiFacturas.Repository;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task AddCliente(ClienteRequest cliente)
        {
            await _clienteRepository.AddCliente(new Cliente
            {
                Cedula = cliente.Cedula,
                Nombre = cliente.Nombre,
                Correo = cliente.Correo,
                Numero = cliente.Numero
            });
        }
        public async Task<Cliente> GetId(int id)
        {
            return await _clienteRepository.GetCliente(id);
        }
        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }
        public void UpdateCliente(int clienteId, ClienteRequest cliente)
        {
            _clienteRepository.UpdateCliente(new Cliente {
                ClienteId = clienteId,
                Cedula = cliente.Cedula,
                Nombre = cliente.Nombre,
                Correo = cliente.Correo,
                Numero = cliente.Numero
            });
        }
        public async Task DeleteCliente(Cliente cliente)
        {
            await _clienteRepository.DeleteCliente(cliente);
        }
        public async Task DeleteId(int id)
        {
            await _clienteRepository.DeleteId(id);
        }
    }
}
