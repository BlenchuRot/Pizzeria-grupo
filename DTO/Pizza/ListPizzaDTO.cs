using System;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class ListPizzaDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
