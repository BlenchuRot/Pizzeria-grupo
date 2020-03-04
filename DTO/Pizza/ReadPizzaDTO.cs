using System;
using Pizzeria.Dominio;
using System.Collections.Generic;

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

    }
}
