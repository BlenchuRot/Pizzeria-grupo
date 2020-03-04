using System;
using System.ComponentModel.DataAnnotations;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class ReadIngredientDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public static ReadIngredientDTO Create(Ingredient ingredient)
        {
            return new ReadIngredientDTO()
            {
                Id = ingredient.Id,
                Name = ingredient.Name,
                Price = ingredient.Price,

            };
        }

    }
}
