using System;
using System.Collections.Generic;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class ReadPizzaDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<ReadIngredientDTO> Ingredients { get; set; }
        public ICollection<ReadCommentDTO> Comments { get; set; }

        public static ReadPizzaDTO Create(Pizza pizza){
            
            return new ReadPizzaDTO()
            {
              Id = pizza.Id,
              Name = pizza.Name,
              Price= pizza.Price
            };
    
        }
        
    }
}