using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DTO
{
    //se le pide al usuario su nombre,email y password, para el registro de usuario
    public class ComnetarioRegistration
    {
        //se pide el Id, con el campo [required], 
        //no se valida hasta que está completo ese campo    
        [Required]
        public long Id { get; set; }
        /*se pide la pizza con el campo [required], no valida
          hasta que está completo ese campo. */
        
        [Required]
        public string Pizza { get; set; }
        
        /*se pide el email con el campo [required], no valida
          hasta que está completo ese campo con el [EmailAddress],
          se comprueba que el formato sea de email, si no se manda 
          un mensage de 400 error automático*/
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}