using System;
namespace Pizzeria.Dominio
{
    public class PizzaIngredient : Pizza
    {
        public Ingredient Ingredient { get; set; }
        public Guid IngredientId { get; set; }
        public Pizza Pizza { get; set; }
        public Guid PizzaId { get; set; }
        

        public PizzaIngredient(Ingredient ingredient, Pizza pizza, Guid pizzaId, Guid ingredientId)
        {
            Ingredient = ingredient;

            IngredientId = ingredientId;

            Pizza = pizza;

            PizzaId = PizzaId;

            
           
        }

        public PizzaIngredient()
        {
        }
    }
}
