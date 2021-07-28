﻿using ApiFacturas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IClienteService
    {
        Task AddCliente(Cliente cliente);
        Task<Cliente> GetId(int id);
        List<Cliente> GetAll();
        void UpdateCliente(Cliente cliente);
        Task DeleteCliente(Cliente cliente);
        Task DeleteId(int id);
    }
}
