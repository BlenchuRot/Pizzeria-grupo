using System;
using Pizzeria.DTO;

//Aquí se crea el dominio del Comentario
namespace Pizzeria.Dominio
{
<<<<<<< HEAD
    //creo la clase Ingrediente para un nuevo Ingrediente
    public class Comment
    {
        //con el método Ingrediente Create, creamos el ingrediente

=======
    //Se crea la clase Comentario
    public class Comment
    //Definimos sus atributos
    { public Guid Id {get; set;}
      public DateTime CreationDate {get; set;}
      public int Puntuacion {get; set;}
      public string Text {get; set;}
      public Pizza Pizza {get; set;}
      public User User {get; set;}
      
       public Comment(int puntuacion, string text, Pizza pizza, User user){
         Puntuacion = puntuacion;
         Text = text;
         Pizza = pizza;
         User = user;
         this.Id = Guid.NewGuid();
         CreationDate = DateTime.Now;
       }
    

      
>>>>>>> 4f82d3931cbf2853ff33cd01e7df03448e3f591d
    }
}