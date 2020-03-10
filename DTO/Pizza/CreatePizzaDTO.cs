using System;
using System.Collections.Generic;

namespace Pizzeria.DTO
{

    public class CreatePizzaDTO
    {
        public string Name { get; set; }
        public ICollection<Guid> Ingredients { get; set; }

          
    }
    }

