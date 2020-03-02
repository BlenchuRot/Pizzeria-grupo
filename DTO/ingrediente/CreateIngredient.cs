using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DTO
{
        public class CreateIngredientDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price{get; set;}

    }
}