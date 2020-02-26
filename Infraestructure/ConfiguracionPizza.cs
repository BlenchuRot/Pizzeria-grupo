using Pizzeria.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Pizzeria.Infraestructure
{
    //creamos una clase para configurar un usuario
    public class PizzaConfiguration
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
              .Entity<Pizza>(pizza =>
              {
                  pizza.HasKey(pizza => pizza.Id);
                  /*creamos el email de usuario como único*/
                  pizza.HasAlternateKey(pizza => pizza.Name);
              });
            /*creamos la asociación de el Id a ese usuario como pk*/

        }
    }
}