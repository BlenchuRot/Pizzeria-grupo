using Api.RegistroUsuario;
using Api.RegistroUsuariode;


namespace Api.Application
{
    public interface IUserService
    {
        UserRegistered Register(UserRegistration userRegistration);
    }
}
