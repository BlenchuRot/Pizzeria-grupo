using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;
using System.Collections.Generic;

namespace Pizzeria.Application
{
    public interface IPizzaService
    {
        ReadPizzaDTO Create(CreatePizzaDTO pizzaRegistered);
        void AddComment(Comment comment, Guid pizzaId);
        ICollection<ListPizzaDTO> FindAll ();
        ReadPizzaDTO GetById(Guid id);
        ReadPizzaDTO FindById(Guid id);
        
    }
}

