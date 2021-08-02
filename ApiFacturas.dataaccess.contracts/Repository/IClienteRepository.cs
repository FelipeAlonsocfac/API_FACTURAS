using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public interface IClienteRepository
    {
        Task AddCliente(Cliente cliente);
        Task<Cliente> GetCliente(int id);
        List<Cliente> GetAll();
        void UpdateCliente(Cliente cliente);
        Task DeleteCliente(Cliente cliente);
        Task DeleteId(int id);
    }
}
