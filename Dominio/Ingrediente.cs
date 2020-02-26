using System;
using Pizzeria.DTO;

//Aquí se crea el dominio del Ingrediente
namespace Pizzeria.Dominio
{
    //creo la clase Ingrediente para un nuevo Ingrediente
    public class Ingrediente
    {
        //con el método Ingrediente Create, creamos el ingrediente
        public static Ingrediente Create(IngredienteRegistration ingredienteRegistration)
        {
            var ingrediente = new Ingrediente()
            {
         //generamos un id unico con el Guid.NewGuid
                Id = Guid.NewGuid(),
         //se registra el nombre del ingrediente      
                Name = ingredienteRegistration.Name
         
            };
         // retornamos los datos del ingrediente     
            return ingrediente;
        }
        //propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        
    }
}