using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;
namespace Pizzeria.Application
{
    class IngredientService : IIngredientService
    {
         private readonly PizzeriaContext _context;
            public IngredientService(PizzeriaContext context)
            {
                _context = context;

            }
        public IngredientRegistered Register (IngredientRegistration ingredientRegistration){
            var ingredient = IngredientRegistration.Create(ingredientRegistration);
            _context.Ingredient.Add(ingredient);
            _context.SaveChanges();
            _context.Dispose();
            return IngredientRegistered.Create(ingredient);

        }

    }
}