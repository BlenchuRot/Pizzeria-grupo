using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DTO
{
    //se le pide al usuario su nombre,email y password, para el registro de usuario
    public class PizzaRegistration
    {
        //se pide el Id, con el campo [required], 
        //no se valida hasta que está completo ese campo    
        [Required]
        public long Id { get; set; }
        /*se pide el email con el campo [required], no valida
          hasta que está completo ese campo. */
       
        [Required]
        public string Name { get; set; }
       
    }
}