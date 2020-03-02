using System.ComponentModel.DataAnnotations;
using System;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{
  
    public class IngredientRegistered{
        public static IngredientRegistered Create(Ingredient ingredient)
        {
            var IngredientRegistered = new IngredientRegistered()
            {
                Id = ingredient.Id,

                Name = ingredient.Name,

            };
            return ingredientRegistered;
        }
        public string Id { get; set; }
        
        public string Name { get; set; }
    }    
       
        
    public class ReadIngredientDTO
    {
      public string Id{get;set;}
      public string Name {get; set;}
    }
        public class CreateIngredientDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}