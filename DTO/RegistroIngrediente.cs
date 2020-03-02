using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DTO
{
    //se le pide al usuario su nombre,email y password, para el registro de usuario
    public class IngredienteRegistration
    {
        //se pide el Id, con el campo [required], 
        //no se valida hasta que está completo ese campo    
        [Required]
        public string Id { get; set; }
        /*se pide el Nombre con el campo [required], no valida
          hasta que está completo ese campo.
        */
        [Required]
        public string Name { get; set; }

         [Required]
        public double Price { get; set; }
       
        }
}