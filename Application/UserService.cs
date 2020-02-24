using Api.RegistroUsuario;
using Api.UsuarioRegistrado;
using API.Infraestructure;
using Api.Application;

namespace Api.Application
{
    class UserService : BaseService, IUserService
    {
        private readonly IUserContext _context;
        public UserService(IUserContext context) : base(context)
        {
            _context = context;
        }

        public UserRegistered Register(UserRegistration userRegistration)
        {
            var user = User.Create(userRegistration);
            _context.User.Add(user);
            _context.SaveChanges();
            return UserRegistered.Create(user);
        }
    }
}