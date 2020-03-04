using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IPizzaService
    {
        PizzaRegistered Create(PizzaRegistered pizzaRegistered);
        void AddComment(Comment comment, Guid pizzaId);

        Pizza GetById(Guid id);

    }
}

