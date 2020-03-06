using Pizzeria.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Pizzeria.Infraestructure
{
    
    public class PizzaConfiguration
    {
        
        public static void Apply(ModelBuilder modelBuilder)
        {
           
            modelBuilder
          
              .Entity<Pizza>(pizza =>
              {
                  pizza.HasKey(pizza => pizza.Id);
                  
                  pizza.HasAlternateKey(pizza => pizza.Name);

                   pizza
                        .HasMany<Comment>(p => p.Comments)
                        .WithOne();
                 
              });
            

        }
    }
}