using Pizzeria.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Pizzeria.Infraestructure
{
    //creamos una clase para configurar una pizza
    public class PizzaConfiguration
    {
        /*creamos un método publico estatico y que no devuelva nada,
           y creamos el tipo ModelBuilder con la propiedad modelBuilder, */
        public static void Apply(ModelBuilder modelBuilder)
        {
            /*creamos el constructor de modelos (modelBuilder) el cual se utiliza
              para crear la entidad pizza (.Entity) y la (HasKey) que es la
              asociación de la pk a esa pizza*/
            modelBuilder
            /*creamos la entidad pizza para la base de datos*/
              .Entity<Pizza>(pizza =>
              {
                  pizza.HasKey(pizza => pizza.Id);
                  /*creamos el nombre de la pizza como único*/
                  pizza.HasAlternateKey(pizza => pizza.Name);

                  // TODO: relaciones (comentario)
              });
            /*creamos la asociación de el Id a esa pizza como pk*/

        }
    }
}