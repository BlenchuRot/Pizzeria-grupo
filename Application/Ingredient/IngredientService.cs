
using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;
namespace Pizzeria.Application
{
    public class IngredientService 
    {
        private readonly PizzeriaContext _context;
        private readonly IPizzaService _pizzaService;
        private readonly IUserService _userService;

        public IngredientService(PizzeriaContext context, IPizzaService pizzaService, IUserService userService)
        {
            _context = context;
            _pizzaService = pizzaService;
            _userService = userService;

        }
        public ReadIngredientDTO Create(ReadIngredientDTO dto)
        {
            var ingredient = new Ingredient();
            _context.Ingredient.Add(ingredient);
            _context.SaveChanges();
            _context.Dispose();
            // todo:
            return ReadIngredientDTO.Create(ingredient);

        }

    }
}