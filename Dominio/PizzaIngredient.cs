
using System;
namespace Pizzeria.Dominio
{
    public class PizzaIngredient 
    {
        public Ingredient Ingredient { get; set; }
        public Guid IngredientId { get; set; }
        public Pizza Pizza { get; set; }
        public Guid PizzaId { get; set; }
      
    }
}
