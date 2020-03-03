using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IPizzaService
    {
        PizzaRegistered Register(PizzaRegistration pizzaRegistration);
        void AddPizza(Pizza pizza, Guid pizzaId);
        void AddComment(Comment comment, Guid pizzaId);

    }
}

