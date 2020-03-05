using System;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{
    //Se pide Id, Nombre de usuario, fecha, texto y puntuacion para el registro del comentario.
    public class ReadCommentDTO
    {
        public Guid Id { get; set; }

        public ReadUserDTO User { get; set; }
        public DateTime CreationDate { get; set; }
        public string Text { get; set; }
        public int Score { get; set; }

        public static ReadCommentDTO Create(Comment comment)
        {
            return new ReadCommentDTO()
            {
                Id = comment.Id,
                User = ReadUserDTO.Create(comment.User),
                CreationDate = comment.CreationDate,
                Text = comment.Text,
                Score = comment.Score
            };
        }

    }
}
