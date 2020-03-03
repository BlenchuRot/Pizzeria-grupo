using System;
using System.ComponentModel.DataAnnotations;


namespace Pizzeria.DTO
{
    public class CreateIngredientDTO
    {
         [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }

    }
}