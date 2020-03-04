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
        public ICollection<PizzaIngredient> PizzaIngredients { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public double Price
        {
            get { return this._calculatePrice(); }
        }
        public static Pizza Create(PizzaRegistered pizzaRegistered)
        {
            var pizza = new Pizza()
            {
                //generamos un id unico con el Guid.NewGuid
                Id = Guid.NewGuid(),
                //se registra el nombre de la pizza      
                Name = pizzaRegistered.Name,

                // TODO: Fallo PizzaIngredients
                //se registran los ingredientes de la pizza 
                PizzaIngredients = pizzaRegistered.PizzaIngredients,

            };
            // retornamos los datos de la pizza    
            return pizza;
        }

        private double _calculatePrice()
        {
            return PizzaIngredients.Select(pi => pi.Ingredient.Price).Sum();
        }
    }
}