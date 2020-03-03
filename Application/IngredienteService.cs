using System;
using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;
namespace Pizzeria.Application
{
    public class IngredientService : Ingredient
    {
        private readonly PizzeriaContext _context;

        public IngredientService(PizzeriaContext context)
        {
            _context = context;

        }
        public void Create(CreateIngredientDTO createIngredientDTO)
        {
            var ingredient = new Ingredient();
            _context.Ingredient.Add(ingredient);
            _context.SaveChanges();
            _context.Dispose();

        }
        public Ingredient GetById(Guid id)
        {
            return _context.Ingredient.Find(id);
        }

    }
}