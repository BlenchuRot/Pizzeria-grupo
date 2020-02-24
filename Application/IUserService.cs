using Api.RegistroUsuario;
using Api.UsuarioRegistrado;


namespace Api.Application
{
    public interface IUserService
    {
        UserRegistered Register(UserRegistration userRegistration);
    }
}
