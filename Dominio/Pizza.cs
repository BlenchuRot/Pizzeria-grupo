using System;
using Pizzeria.DTO;


//Aquí se crea el dominio de la Pizzeria
namespace Pizzeria.Dominio
{
    //creo la clase Pizzeria para un nueva Pizzeria
    public class Pizza
    {
          //con el método User Create, creamos el nuevo usuario
        public static Pizza Create(PizzaRegistration pizzaRegistration)
        {
            var pizza = new Pizza()
            {
         //generamos un id unico con el Guid.NewGuid
                Id = Guid.NewGuid(),
         //se registra el nombre de usuario       
                Name = PizzaRegistration.Name    
            };
         // retornamos los datos del usuario    
            return pizza;
        }
        //propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }
      
    
        

    }
}