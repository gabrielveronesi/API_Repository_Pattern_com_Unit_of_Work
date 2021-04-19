using LojaUnit.Interfaces;

namespace LojaUnit.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {
            // NÃO FAZ NADA!
        }
    }
}