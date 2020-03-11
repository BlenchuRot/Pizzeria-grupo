using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;
using System;
using Microsoft.EntityFrameworkCore;

namespace Pizzeria.Application
{
    class UserService : IUserService
    {
        private readonly PizzeriaContext _context;
        public UserService(PizzeriaContext context)
        {
            _context = context;

        }

        public ReadUserDTO Register(CreateUserDTO userRegistration)
        {
            var user = User.Create(userRegistration); //se crea nuevo user.Registration
            _context.User.Add(user);  //se descarga
            _context.SaveChanges(); //se guardan los cambios
            _context.Dispose();
            return ReadUserDTO.Create(user); //devuelve el usuario creado
        }

         public User FindById(Guid id)
        {
           return _context.User.Find(id);
        }
   }
}