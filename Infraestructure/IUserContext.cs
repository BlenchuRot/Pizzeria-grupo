using Microsoft.EntityFrameworkCore;
using Api.RegistroUsuario;
using Api.UsuarioRegistrado;

namespace API.Infraestructure
{
    public interface IUserContext : IUnitOfWork
    {
        DbSet<User> User { get; set; }
    }
}