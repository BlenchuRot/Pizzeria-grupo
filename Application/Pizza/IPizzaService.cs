using System;
using System.Collections.Generic;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IPizzaService
    {
      

        void Create(CreatePizzaDTO pizzaRegistered);

       void AddComment(Comment comment, Guid pizzaId);

        ReadPizzaDTO GetById(Guid id);
        ReadPizzaDTO FindById(Guid id);
     
    }
}

