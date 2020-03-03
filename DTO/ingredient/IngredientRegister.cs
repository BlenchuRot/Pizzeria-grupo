using System;
using Pizzeria.Dominio;
//se comprueba que todo está bien y se devuelve la información que quiero que se vea al dominio
namespace Pizzeria.DTO
{
    public class IngredientRegistered
    {
        public static IngredientRegistered Create(Ingredient ingredient)
        {
            //devuelvo la información del usuario sin el password, 
            //para que no se vea esa informacion
            var ingredientRegistered = new IngredientRegistered()
            {
                Id = ingredient.Id,

                Name = ingredient.Name,

                Price = ingredient.Price,

            };
            return ingredientRegistered;
        }
        //propiedades
        public Guid Id { get; set; }

        public string Name { get; set; }

        private double Price { get; set; }


        internal static IngredientRegistered Create(Object id)

        {
            throw new NotImplementedException();
        }
    }
}