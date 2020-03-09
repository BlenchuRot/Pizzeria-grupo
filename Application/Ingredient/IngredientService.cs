
using Pizzeria.Dominio;
using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Pizzeria.Application
{
    public class IngredientService : IIngredientService
    {
        private readonly PizzeriaContext _context;

       

        public IngredientService(PizzeriaContext context)
        {
            _context = context;
           
           
        }
        public ICollection<ReadIngredientDTO> FindAll()
        {
            return _context.Ingredient.Select(ReadIngredientDTO.Create).ToList();
        }
        public Ingredient FindById(Guid id) {
            var ingredient = _context.Ingredient.Find(id);
            return ingredient;
        }


    }  

}