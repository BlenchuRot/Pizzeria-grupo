using System;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class ReadPizzaDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        // TODO: coleccion de ReadIngredientDTO
        public Ingredient ReadIngredientDTO { get; set; }
        // TODO: coleccion de ReadCommentDTO
        public Comment ReadCommentDTO { get; set; }


    }
}
