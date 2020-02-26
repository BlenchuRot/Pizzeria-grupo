using System;
using System.Collections.Generic;
using Pizzeria.DTO;

//Aquí se crea el dominio de la Pizzeria
namespace Pizzeria.Dominio
{
    //creo la clase Pizzeria para un nueva Pizzeria
    public class Pizza
    {
        //con el método Pizzeria Create, creamos la Pizzeria
        public static Pizza Create(PizzeriaRegistration PizzeriaRegistration)
        {
            var Pizza = new Pizza()
            {
         //generamos un id unico con el Guid.NewGuid
                Id = Guid.NewGuid(),
         //se registra el nombre de Pizzeria      
                Name = PizzaRegistration.Name,
         //se registra el email de la Pizzeria       
                Ingrediente = PizzaRegistration.Ingrediente,
         //se registra el password de la Pizzeria       
                Comentario = PizzaRegistration.Comentario
            };
         // retornamos los datos de la Pizzeria     
            return Pizza;
        }
        //propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<PizzaIngrediente> PizzaIngredientes { get; set; }
        public string Comentario { get; set; }
        

    }
}