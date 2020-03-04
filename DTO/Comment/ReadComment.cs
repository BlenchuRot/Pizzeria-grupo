using System;
using System.ComponentModel.DataAnnotations;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class ReadCommentDTO
    {
        public Guid Id { get; set; }

        public User ReadUserDTO { get; set; }
        public DateTime CreationDate { get; set; }
        public string Text { get; set; }
        public int Shore { get; set; }

        public static ReadCommentDTO Create(Comment comment)
        {
            return new ReadCommentDTO()
            {
                Id = comment.Id,
                ReadUserDTO = comment.ReadUserDTO,
                CreationDate = comment.CreationDate,
                Text = comment.Text,
                Shore = comment.Shore
            };
        }

    }
}
