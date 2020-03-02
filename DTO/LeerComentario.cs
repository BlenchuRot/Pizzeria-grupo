using System;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class LeerCommentDTO{
       public Guid Id {get; set;}
       public string UserName {get; set;}
       public DateTime CreationDate {get; set;}
       public string Text {get; set;}
       public int Puntuacion {get; set;}
    }
}
    