using System;
using System.Collections.Generic;
using Pizzeria.DTO;
using System.Linq;


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

        public static Pizza Create(PizzaRegistration pizzaRegistration)
        {
            throw new NotImplementedException();
        }

        private double _calculatePrice()
        {



            return 0.0;
        }
        //TODO
    }
}