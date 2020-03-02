using Pizzeria.DTO;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IIngredienteService
    {
        IngredientRegistered Register(IngredientRegistration ingredientRegistration);
    }
}