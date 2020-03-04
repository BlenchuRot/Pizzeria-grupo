using System;
using System.Collections.Generic;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class CreatePizzaDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Guid> Ingredients { get; set; }

        internal static CreatePizzaDTO Create(Pizza pizza)
        {
            throw new NotImplementedException();
        }
    }
}
