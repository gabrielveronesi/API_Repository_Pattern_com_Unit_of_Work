namespace LojaUnit.Interfaces
{
    public interface IUnitOfWork
    {
         void Commit();
         void RollBack();
    }
}