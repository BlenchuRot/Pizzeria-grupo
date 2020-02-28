namespace Pizzeria.Infraestructure
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        void Dispose();
    }
}