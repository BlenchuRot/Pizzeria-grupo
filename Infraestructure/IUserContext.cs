using Microsoft.EntityFrameworkCore;
using Api.Dominio;

namespace API.Infraestructure
{
    public interface IUserContext : IUnitOfWork
    {
        DbSet<User> User { get; set; }
    }
}