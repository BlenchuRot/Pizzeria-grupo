using System;



namespace Pizzeria.Dominio
{

    //Se crea la clase Comentario
    public class Comment
    //Definimos sus atributos
    { public Guid Id {get; set;}
      public DateTime CreationDate {get; set;}
      public int Puntuacion {get; set;}
      public string Text {get; set;}
      public User User {get; set;}
      
       public Comment(int puntuacion, string text,  User user){
         Puntuacion = puntuacion;
         Text = text;
         User = user;
         this.Id = Guid.NewGuid();
         CreationDate = DateTime.Now;
       }
    }
}