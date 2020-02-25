using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IUserService
    {
        UserRegistered Register(UserRegistration userRegistration);
    }
}
