using LojaUnit.Data;
using LojaUnit.Models;

namespace LojaUnit.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DataContext _context;
        public PedidoRepository(DataContext context)
        {
            _context = context;
        }
        public void Salvar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
        }
    }
}