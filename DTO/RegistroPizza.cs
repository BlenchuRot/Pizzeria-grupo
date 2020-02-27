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
        /*se pide el nombre con el campo [required], no valida
          hasta que está completo ese campo. */

        [Required]
        public string Name { get; set; }
<<<<<<< HEAD

=======
       
>>>>>>> ea3e4810b775d3bb24a1e73e97d47832b1514a56
    }
}