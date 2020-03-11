using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IUserService
    {
        ReadUserDTO Register(CreateUserDTO userRegistration);
        User FindById(Guid id);
        
    }
}
