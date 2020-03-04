using System;
using System.ComponentModel.DataAnnotations;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class ReadCommentDTO
    {
        public Guid Id { get; set; }

        // TODO: cambiar por LeerUserDTO
        public string UserName { get; set; }
        public DateTime CreationDate { get; set; }
        public string Text { get; set; }
        public int Puntuacion { get; set; }

        public static ReadCommentDTO Create(Comment comment)
        {
            return new ReadCommentDTO()
            {
                Id = comment.Id,
                UserName = comment.User.Name,
                CreationDate = comment.CreationDate,
                Text = comment.Text,
                Puntuacion = comment.Puntuacion
            };
        }

    }
}
