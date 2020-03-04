
using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using System.Collections.Generic;
using System.Linq;
namespace Pizzeria.Application
{
    public class IngredientService : IIngredientService
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
        public ICollection<ReadIngredientDTO> ReadAll()
        {
            return _context.Ingredient.Select(ReadIngredientDTO.Create).ToList();
        }
    }
}