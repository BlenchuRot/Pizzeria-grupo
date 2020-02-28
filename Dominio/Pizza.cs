using System;
using System.Collections.Generic;
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

        public ICollection<PizzaIngredient> Ingredients { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public double Price
        {
            get { return this._calculatePrice(); }
        }

        internal static object Create(PizzaRegistration pizzaRegistration)
        {
            throw new NotImplementedException();
        }

        public double CalculatePrice() { 
           

            
            return 0.0; }
        //TODO
    }
}