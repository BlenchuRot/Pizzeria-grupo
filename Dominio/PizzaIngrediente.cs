using System;
using Pizzeria.DTO;

//Aquí se crea el dominio de la Pizzeria
namespace Pizzeria.Dominio
{
    //creo la clase Pizzeria para un nueva Pizzeria
    public class PizzaIngrediente
    {
        //con el método Pizzeria Create, creamos la Pizzeria
        public static PizzaIngrediente Create(PizzaIngredienteRegistration PizzaIngredienteRegistration)
        {
            var PizzaIngrediente = new PizzaIngrediente()
            {
         //generamos un id unico con el Guid.NewGuid
                PizzaId = Guid.NewGuid(),

                IngredienteId = Guid.NewGuid(),
         //se registra el nombre de Pizzeria      
                Pizza = PizzaIngredienteRegistration.Pizza,
         //se registra el email de la Pizzeria       
                Ingrediente = PizzaIngredienteRegistration.Ingrediente,
        
            };
         // retornamos los datos de la Pizzeria     
            return PizzaIngrediente;
        }
        //propiedades
        public Guid PizzaId { get; set; }

        public Guid IngredienteId { get; set; }
        public string Pizza { get; set; }
        public string Ingrediente { get; set; }
        

    }
}