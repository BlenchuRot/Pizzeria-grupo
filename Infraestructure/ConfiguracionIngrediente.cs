using Pizzeria.Dominio;
using Microsoft.EntityFrameworkCore;


namespace Pizzeria.Infraestructure
{
  public class IngredientConfiguration
  {
    public static void Apply(ModelBuilder modelBuilder)
    {
     modelBuilder
    .Entity<Ingredient>(ingredient =>{

    
    ingredient.HasKey(ingredient => ingredient.Id);});
    }
}
}