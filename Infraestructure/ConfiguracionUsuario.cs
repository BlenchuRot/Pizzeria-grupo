using Api.Dominio;
using Microsoft.EntityFrameworkCore;

namespace API.Infraestructure
{
    //creamos una clase para configurar un usuario
    public class UserConfiguration
    {
        /*creamos un método publico estatico y que no devuelva nada,
          y creamos el tipo ModelBuilder con la propiedad modelBuilder, */
        public static void Apply(ModelBuilder modelBuilder)
        {
            /*creamos el constructor de modelos (modelBuilder) el cual se utiliza
              para crear la entidad usuario (.Entity) y la (HasKey) que es la
              asociación de la pk a ese usuario*/
            modelBuilder
            /*creamos la entidad usuario para la base de datos*/
              .Entity<User>(user =>
              {
                  user.HasKey(user => user.Id);
                  /*creamos el email de usuario como único*/
                  user.HasAlternateKey(user => user.Email);
              });
            /*creamos la asociación de el Id a ese usuario como pk*/

        }
    }
}