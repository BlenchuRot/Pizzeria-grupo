using Pizzeria.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Pizzeria.Infraestructure
{
    //creamos una clase para configurar un usuario
    public class PizzaIngredienteConfiguration
    {
        /*creamos un método publico estatico y que no devuelva nada,
          y creamos el tipo ModelBuilder con la propiedad modelBuilder, */
        public static void Apply(ModelBuilder modelBuilder)
        {
           
            modelBuilder
           
              .Entity<PizzaIngrediente>(pizzaIngrediente =>
              {
                  pizzaIngrediente.HasKey(pizzaIngrediente => new {pizzaIngrediente.PizzaId, pizzaIngrediente.IngredienteId});
                  
                  pizzaIngrediente
                  .HasOne(pizzaIngrediente => pizzaIngrediente.Pizza)
                  .WithMany(pizza => pizza.PizzaIngredientes)
                  .HasForeignKey(pizzaIngrediente => pizzaIngrediente.PizzaId);
                  
              });
           

        }
    }
}