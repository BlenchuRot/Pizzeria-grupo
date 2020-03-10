using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class ListPizzaDTO
    {
        
        public Guid Id { get; set; }
        public string Name { get; set; }

         public static ListPizzaDTO Create (Pizza pizza)
         {
             return new ListPizzaDTO()
             {
                 Id = pizza.Id,
                 Name = pizza.Name
             };
         }
    }
       
     

    
}   