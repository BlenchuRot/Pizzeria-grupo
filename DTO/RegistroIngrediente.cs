using System.ComponentModel.DataAnnotations;
using System;
namespace Pizzeria.DTO
{
  
    public class CreateIngredientDTO{
        public string Id { get; set; }
        
        public string Name { get; set; }
    }    
       
        
    public class ReadIngredientDTO{
      public string Id{get;set;}
      public string Name {get; set;}

    }
}