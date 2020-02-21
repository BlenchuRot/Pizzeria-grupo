using System;
using Api.Dominio;
//se comprueba que todo está bien y se devuelve la información que quiero que se vea al dominio
namespace Api.RegistroUsuariode
{
    public class UserRegistered
    {
        public static UserRegistered Create(User user)
        {
            //devuelvo la información del usuario sin el password, 
            //para que no se vea esa informacion
            var userRegistered = new UserRegistered()
            {
                Id = user.Id,

                Name = user.Name,

                Email = user.Email

            };
            return userRegistered;
        }
        //propiedades
         public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}