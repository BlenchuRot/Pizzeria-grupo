using System;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DTO
{
    //Se pide Usuario, IdPizza, texto y puntuacion para el registro del comentario.
    public class CreateCommentDTO
    {  
       [Required]
       public Guid UserId {get; set;}
       [Required]
       public Guid PizzaId {get; set;}
       [Required]
       public string Text {get; set;}
       [Required]
       public int Puntuacion {get; set;}
       
    }
}