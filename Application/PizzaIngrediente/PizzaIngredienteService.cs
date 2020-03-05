using System;
using System.Collections.Generic;
using Pizzeria.Dominio;
using Pizzeria.Infraestructure;

namespace Pizzeria.Application
{
    public class PizzaIngredientService : IPizzaIngredientService
    {
        private readonly PizzeriaContext _context;

        private readonly IIngredientService _ingredientService;

        public PizzaIngredientService(PizzeriaContext context, IIngredientService ingredientService)
        {
            _context = context;
            _ingredientService = ingredientService;
            
        }
        public void AddIngredients(Pizza pizza, ICollection<Guid> ingredients)
        {
            foreach (Guid ingredientId in ingredients)
            {
                 var ingredient = _ingredientService.ReadAll();
                 var pizzaIngredient = new PizzaIngredient()
                {
                    Pizza = pizza,
                    PizzaId = pizza.Id,
                    IngredientId = ingredientId
                };
                pizza.PizzaIngredients.Add(pizzaIngredient);
            }
        }

       
    }
}