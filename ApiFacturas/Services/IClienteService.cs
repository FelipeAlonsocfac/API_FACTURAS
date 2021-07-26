using ApiFacturas.Models;
using System.Collections.Generic;


namespace ApiFacturas.Services
{
    public interface IClienteService
    {
        void AddCliente(Cliente cliente);
        void DeleteCliente(int id);
        void DeleteCliente(Cliente cliente);
        List<Cliente> GetClientes();
        Cliente GetCliente(int id);
        Cliente UpdateCliente(Cliente cliente);
    }
}
