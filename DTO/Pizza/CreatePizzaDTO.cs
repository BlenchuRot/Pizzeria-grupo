using System;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class CreatePizzaDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<PizzaIngredientDTO> PizzaIngredients { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
        public double Price { get; set; }


        // TODO: ingredientes coleccion de Guid

    }
}
