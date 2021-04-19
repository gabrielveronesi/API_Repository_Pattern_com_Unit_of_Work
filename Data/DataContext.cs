using LojaUnit.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaUnit.Data
{
    
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
    {
        
    }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}