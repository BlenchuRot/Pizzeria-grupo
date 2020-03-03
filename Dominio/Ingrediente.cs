using System;
using Pizzeria.DTO;

//Aquí se crea el dominio del Ingrediente
namespace Pizzeria.Dominio
{
   
    public class Ingredient
    {
      
        //con el método Ingrediente Create, creamos el ingrediente
        public static Ingredient Create(IngredienteRegistration ingredientRegistration)
        {
            var ingredient = new Ingredient()
            {
                //generamos un id unico con el Guid.NewGuid
                Id = Guid.NewGuid(),
                //se registra el nombre del ingrediente      
                Name = ingredientRegistration.Name,

                Price = ingredientRegistration.Price

            };
            // retornamos los datos del ingrediente     
            return ingredient;
        }
        //propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

       
    }
}