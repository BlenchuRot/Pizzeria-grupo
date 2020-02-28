using System;
using System.ComponentModel.DataAnnotations;
using Pizzeria.DTO;

//Aquí se crea el dominio del Ingrediente
namespace Pizzeria.Dominio
{
   
    public class Ingredient
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Precio{get; set;}
    
    }
}