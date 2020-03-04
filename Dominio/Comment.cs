using System;



namespace Pizzeria.Dominio
{

    //Se crea la clase Comentario
    public class Comment
    //Definimos sus atributos
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int Shore { get; set; }
        public string Text { get; set; }
        public User ReadUserDTO { get; set; }

        public Comment(int shore, string text, User readUserDTO)
        {
            Shore = shore;
            Text = text;
            ReadUserDTO = readUserDTO;
            this.Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }
    }
}