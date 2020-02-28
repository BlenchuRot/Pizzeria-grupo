using System;
using Pizzeria.DTO;


//Aquí se crea el dominio de la Pizzeria
namespace Pizzeria.Dominio
{
    //creo la clase Pizza
    public class Pizza
    {
     
      
        //propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }

         public string Ingredients { get; set; }

          public string Comments { get; set; } 

          public double Price {
              get { return this._calculatePrice();}
          }

          public double CalculatePrice(){ return 0.0;}

        internal static object Create(PizzaRegistration pizzaRegistration)
        {
            throw new NotImplementedException();
        }
        //TODO
    }
}