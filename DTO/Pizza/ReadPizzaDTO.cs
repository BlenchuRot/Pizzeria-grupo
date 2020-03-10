using System;
using System.Collections.Generic;

namespace Pizzeria.DTO
{
   
    public class ReadPizzaDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<ReadIngredientDTO> Ingredients { get; set; }
        public ICollection<ReadCommentDTO> Comments { get; set; }

    }
}
