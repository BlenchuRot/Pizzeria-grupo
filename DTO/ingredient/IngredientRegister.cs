using System;
using Pizzeria.Dominio;
//se comprueba que todo está bien y se devuelve la información que quiero que se vea al dominio
namespace Pizzeria.DTO
{
    public class IngredientRegisterDTO
    {
        public static IngredientRegisterDTO Create(Ingredient ingredient)
        {
            var ingredientRegisterDTO = new IngredientRegisterDTO()
            {
                Id = ingredient.Id,

                Name = ingredient.Name,

                Price = ingredient.Price,

            };
            return ingredientRegisterDTO;
        }
        //propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        private double Price { get; set; }

    }
}