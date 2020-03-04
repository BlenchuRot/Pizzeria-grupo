using System;

//Aquí se crea el dominio del Ingrediente
namespace Pizzeria.Dominio
{
    public class Ingredient
    {
        //propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}