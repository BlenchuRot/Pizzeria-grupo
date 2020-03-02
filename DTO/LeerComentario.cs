using System;
using System.ComponentModel.DataAnnotations;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class LeerCommentDTO{
       public Guid Id {get; set;}
       public string UserName {get; set;}
       public DateTime CreationDate {get; set;}
       public string Text {get; set;}
       public int Puntuacion {get; set;}

       public static LeerCommentDTO Create (Comment comment){
           return new LeerCommentDTO() {
               Id = comment.Id,
               UserName = comment.User.Name,
               CreationDate = comment.CreationDate,
               Text = comment.Text,
               Puntuacion = comment.Puntuacion
           };
       }

    }
}
    