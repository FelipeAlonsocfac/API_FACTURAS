using ApiFacturas.DataAcces;
using ApiFacturas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.Repository
{
    public class ClienteRepository : IClienteRepository
    {

        private readonly IDBContext _context;
        public ClienteRepository(IDBContext context)
        {
            _context = context;
        }
        public async Task AddCliente(Cliente cliente)
        {//C

            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }
        public async Task<Cliente> GetCliente(int id)
        {//R
            return await _context.Clientes.FindAsync(id);
        }
        public List<Cliente> GetAll()
        {
            return _context.Clientes.Select(x => x).ToList();
        }
        public void UpdateCliente(Cliente cliente)
        {//U

            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }
        public async Task DeleteCliente(Cliente cliente)//D
        {
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteId(int id)
        {
            var model = await GetCliente(id);
            await DeleteCliente(model);
        }
    }
}
