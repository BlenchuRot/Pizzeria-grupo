using Pizzeria.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Pizzeria.Infraestructure
{
    public class PizzaIngredientConfiguration
    {
        public static void Apply(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PizzaIngredient>(pi =>
                {
                    pi.HasKey(pi => new { pi.PizzaId, pi.IngredientId });

                    pi
                        .HasOne<Pizza>(pi => pi.Pizza)
                        .WithMany(p => p.PizzaIngredients)
                        .HasForeignKey(pi => pi.PizzaId);

                    pi
                        .HasOne<Ingredient>(pi => pi.Ingredient)
                        .WithMany()
                        .HasForeignKey(pi => pi.IngredientId);

                });
        }
    }
}