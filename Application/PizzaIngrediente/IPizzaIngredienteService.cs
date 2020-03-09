using System;
using System.Collections.Generic;
using Pizzeria.Dominio;

namespace Pizzeria.Application
{
    public interface IPizzaIngredientService
    {
        void AddIngredients(Pizza pizza, ICollection<Guid> ingredients);
      
    }
}