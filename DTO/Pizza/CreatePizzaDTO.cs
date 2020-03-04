using System;
using System.Collections.Generic;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class CreatePizzaDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<ReadPizzaIngredientDTO> PizzaIngredients { get; set; }
        public ICollection<ReadCommentDTO> Comments { get; set; }
        public double Price { get; set; }


        // TODO: ingredientes coleccion de Guid

    }
}
