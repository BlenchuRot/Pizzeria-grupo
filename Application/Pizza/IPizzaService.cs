using System;
using System.Collections.Generic;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IPizzaService
    {
        ReadPizzaDTO Create(CreatePizzaDTO pizzaRegistered);
        void AddComment(Comment comment, Guid pizzaId);
        ICollection<ListPizzaDTO> FindAll { get; }

        ReadPizzaDTO FindById(Guid id);
        ReadPizzaDTO GetById(Guid id);
        
    }
}

