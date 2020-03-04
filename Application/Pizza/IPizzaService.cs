using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IPizzaService
    {
        CreatePizzaDTO Create(CreatePizzaDTO pizzaRegistered);
        void AddComment(Comment comment, Guid pizzaId);

        Pizza GetById(Guid id);

    }
}

