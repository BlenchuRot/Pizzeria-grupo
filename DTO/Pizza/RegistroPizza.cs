using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pizzeria.Dominio;

namespace Pizzeria.DTO
{
    //se le pide al usuario su nombre,email y password, para el registro de usuario
    public class PizzaRegistration
    {
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

        public double Price
        {
            get { return this._calculatePrice(); }
        }
    }
}