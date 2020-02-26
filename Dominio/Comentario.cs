using System;
using Pizzeria.DTO;

//Aquí se crea el dominio del Ingrediente
namespace Pizzeria.Dominio
{
    //creo la clase Ingrediente para un nuevo Ingrediente
    public class Comentario
    {
        //con el método Ingrediente Create, creamos el ingrediente
        public static Comentario Create(ComentarioRegistration comentarioRegistration)
        {
            var comentario = new Comentario()
            {
         //generamos un id unico con el Guid.NewGuid
                Id = Guid.NewGuid(),
         //se registra el nombre del ingrediente      
                Pizza = comentarioRegistration.Pizza,

                User = comentarioRegistration.User
         
            };
         // retornamos los datos del ingrediente     
            return comentario;
        }
        //propiedades
        public Guid Id { get; set; }
        public string Pizza { get; set; }
        public string User { get; set; }
    }
}