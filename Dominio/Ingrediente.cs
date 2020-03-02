using System;
using System.ComponentModel.DataAnnotations;
using Pizzeria.DTO;

//Aquí se crea el dominio del Ingrediente
namespace Pizzeria.Dominio
{
   
    public class Ingredient
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double price{get;set;}


    }
}