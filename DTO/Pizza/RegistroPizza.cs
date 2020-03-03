using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{

    public class PizzaRegistration
    {
        private double _calculatePrice;

        //se pide el Id, con el campo [required], 
        //no se valida hasta que está completo ese campo    
        [Required]
        public long Id { get; set; }
        /*se pide el nombre con el campo [required], no valida
          hasta que está completo ese campo. */

        [Required]
        public string Name { get; set; }

        [Required]
        public ICollection<Ingredient> Ingredients { get; set; }

        [Required]
        public double Price
        {
            get { return this.CalculatePrice1; }
        }

        public double CalculatePrice { get => CalculatePrice1; set => CalculatePrice1 = value; }
        public double CalculatePrice1 { get => _calculatePrice; set => _calculatePrice = value; }
    }
}