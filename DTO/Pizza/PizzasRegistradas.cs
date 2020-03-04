using System;
using Pizzeria.Dominio;
//se comprueba que todo está bien y se devuelve la información que quiero que se vea al dominio
namespace Pizzeria.DTO
{
    public class PizzaRegistered
    {
        public static PizzaRegistered Create(Pizza pizza)
        {
            var pizzaRegistered = new PizzaRegistered()
            {
                Id = pizza.Id,

                Name = pizza.Name,

                Price = pizza.Price,

            };
            return pizzaRegistered;
        }
        //propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        private double Price { get; set; }

    }
}