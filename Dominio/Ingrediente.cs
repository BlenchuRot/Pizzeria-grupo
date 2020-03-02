using System;

//Aquí se crea el dominio del Ingrediente
namespace Pizzeria.Dominio
{
   
    public class Ingredient
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price{get;set;}

        public Ingredient(string name, double price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }
    }
}