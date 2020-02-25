using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;

namespace Pizzeria.Application
{
    class UserService : IUserService
    {
        private readonly PizzeriaContext _context;
        public UserService(PizzeriaContext context)
        {
            _context = context;
        }

        public UserRegistered Register(UserRegistration userRegistration)
        {
            var user = User.Create(userRegistration); //se crea nuevo user.Registration
            _context.User.Add(user);  //se descarga
            _context.SaveChanges(); //se guardan los cambios
            _context.Dispose();
            return UserRegistered.Create(user); //devuelve el usuario creado
        }
    }
}