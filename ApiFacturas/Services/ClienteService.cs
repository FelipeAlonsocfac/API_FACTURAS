using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiFacturas.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IDBContext _dbContext;
        public ClienteService(IDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddCliente(Cliente cliente)
        {

            _dbContext.Clientes.Add(cliente);
            _dbContext.SaveChanges();
        }
        public void DeleteCliente(int id)
        {
            var cliente = GetCliente(id);
            DeleteCliente(cliente);
        }
        public void DeleteCliente(Cliente cliente)
        {
            _dbContext.Clientes.Remove(cliente);
            _dbContext.SaveChanges();
        }
        public List<Cliente> GetClientes()
        {
            return _dbContext.Clientes.Select(x => x).ToList();
        }
        public Cliente GetCliente(int id)
        {
            return _dbContext.Clientes.Where(x => x.ClienteId == id).FirstOrDefault();
        }
        public Cliente UpdateCliente(Cliente cliente)
        {

            var clientUpdated = _dbContext.Clientes.Update(cliente).Entity;
            _dbContext.SaveChanges();
            return clientUpdated;
        }
    }
}
