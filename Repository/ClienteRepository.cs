using LojaUnit.Data;
using LojaUnit.Models;

namespace LojaUnit.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _context;
        public ClienteRepository(DataContext context)
        {
            _context = context;
        }
        public void Salvar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }
    }
}