using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;
namespace Pizzeria.Application
{

    public class PizzaMapper
    {
        public static Pizza Create(PizzaRegistration pizzaRegistration)
        {
            var pizza = new Pizza()
            {
                //generamos un id unico con el Guid.NewGuid
                Id = Guid.NewGuid(),
                //se registra el nombre de usuario       
                Name = pizzaRegistration.Name
            };
            // retornamos los datos del usuario    
            return pizza;
        }

        //con el método Comentario Create, creamos el Comentario.
        public static Pizza ToPizza(CreatePizzaDTO dto)
        {
            return new Pizza()
            {

            };
        }
        public static ReadPizzaDTO ToReadPizzaDTO(Pizza pizza)
        {
            return new ReadPizzaDTO()
            {

            };

        }

    }
}