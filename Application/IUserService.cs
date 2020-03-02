using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IUserService
    {
        UserRegistered Register(UserRegistration userRegistration);
        UserRegistered FindId(Guid id);
        User FindById(object userId);
    }
}
