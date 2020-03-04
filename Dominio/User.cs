using System;
using Pizzeria.DTO;

//Aquí se crea el dominio del usuario
namespace Pizzeria.Dominio
{
    //creo la clase usuario para un nuevo usuario
    public class User
    {
        //con el método User Create, creamos el nuevo usuario
        public static User Create(CreateUserDTO createUser)
        {
            var user = new User()
            {
                //generamos un id unico con el Guid.NewGuid
                Id = Guid.NewGuid(),
                //se registra el nombre de usuario       
                Name = createUser.Name,
                //se registra el email de usuario       
                Email = createUser.Email,
                //se registra el password del usuario       
                Password = createUser.Password
            };
            // retornamos los datos del usuario    
            return user;
        }
        //propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}