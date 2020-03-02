using Microsoft.EntityFrameworkCore;
using Pizzeria.Dominio;

namespace Pizzeria.Infraestructure
{
    public interface IUserContext : IUnitOfWork
    {
        DbSet<User> User {get; set;}
    }
    
        
    }

