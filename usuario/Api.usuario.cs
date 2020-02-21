using System;
using Api.RegistroUsuario;

//Aquí se crea el dominio del usuario
namespace Api.Dominio
{
    //creo la clase usuario para un nuevo usuario
    public class User
    {
        //con el método User Create, creamos el nuevo usuario
        public static User Create(UserRegistration userRegistration)
        {
            var user = new User()
            {
         //generamos un id unico con el Guid.NewGuid
                Id = Guid.NewGuid(),
         //se registra el nombre de usuario       
                Name = userRegistration.Name,
         //se registra el email de usuario       
                Email = userRegistration.Email,
         //se registra el password del usuario       
                Password = userRegistration.Password
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