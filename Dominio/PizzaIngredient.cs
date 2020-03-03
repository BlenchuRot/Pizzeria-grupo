using System;

namespace Pizzeria.Dominio
{
    // TODO: configurar relaciones y pk
    //creo la clase Pizzeria para un nueva Pizzeria
    public class PizzaIngredient
    {
        public Ingredient Ingredient { get; set; }
        public Pizza Pizza { get; set; }
        public Guid PizzaId { get; set; }
        public Guid IngredientId { get; set; }
    }
}