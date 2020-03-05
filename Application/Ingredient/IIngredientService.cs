﻿using Pizzeria.DTO;
using System.Collections.Generic;


namespace Pizzeria.Application
{
    public interface IIngredientService
    {
        ICollection<ReadIngredientDTO> ReadAll();

    }
}