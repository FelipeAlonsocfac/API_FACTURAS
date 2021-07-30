using ApiFacturas.Models;
using ApiFacturas.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IClienteService
    {
        Task AddCliente(ClienteRequest cliente);
        Task<Cliente> GetId(int id);
        List<Cliente> GetAll();
        void UpdateCliente(int clienteId, ClienteRequest cliente);
        Task DeleteCliente(Cliente cliente);
        Task DeleteId(int id);
    }
}
