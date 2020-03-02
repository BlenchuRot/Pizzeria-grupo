using System;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DTO
{
    //Se pide Usuario, IdPizza, texto y puntuacion para el registro del comentario.
    public class CrearCommentDTO
    {
       public Guid UserId {get; set;}
       public Guid PizzaId {get; set;}
       public string Text {get; set;}
       public int Puntuacion {get; set;}
    }
}