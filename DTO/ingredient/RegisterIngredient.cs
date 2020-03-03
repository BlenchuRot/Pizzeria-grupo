using System.ComponentModel.DataAnnotations;


namespace Pizzeria.DTO
{

    public class IngredientRegistration
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
        public string Price { get; set; }

    }
}
