using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;
using System;

namespace Pizzeria.Application
{
    class UserService : BaseService, IUserService 
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

        public User GetById(Guid id){
            return _context.User.Find(id);
        }
    }
}