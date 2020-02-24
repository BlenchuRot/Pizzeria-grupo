namespace API.Infraestructure
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        void Dispose();
    }
}