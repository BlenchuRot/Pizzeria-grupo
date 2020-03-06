using Pizzeria.Dominio;
using Pizzeria.DTO;
using System;
using System.Collections.Generic;


namespace Pizzeria.Application
{
    public interface IIngredientService
    {
        ICollection<ReadIngredientDTO> FindAll();
        Ingredient FindById (Guid id);

    }
}