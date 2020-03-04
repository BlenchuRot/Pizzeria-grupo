using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IUserService
    {
        ReadUserDTO Register(CreateUserDTO userRegistration);
        ReadUserDTO FindId(Guid id);
        User FindById(object userId);
    }
}
