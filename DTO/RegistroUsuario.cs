using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DTO
{
    //se le pide al usuario su nombre,email y password, para el registro de usuario
    public class UserRegistration
    {
        //se pide el nombre, con el campo [required], 
        //no se valida hasta que está completo ese campo    
        [Required]
        public string Name { get; set; }
        /*se pide el email con el campo [required], no valida
          hasta que está completo ese campo con el [emailAddress],
          se comprueba que el formato sea de email, si no se manda 
          un mensage de 400 error automático*/
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        /*se pide un password con el campo [required], no valida
          hasta que ese campo esté completo y con el campo [MinLength],
          se le pide que para validar tiene que tener un mínimo de 6 caracteres */
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}