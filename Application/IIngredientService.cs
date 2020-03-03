using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IIngredientService
    {
        void Create(CreateIngredientDTO createIngredientDTO);
        void Read(IngredientDetailDTO ingredientDetailDTO);
        IngredientRegistered Register(IngredientRegistration ingredientRegistration);

    }

}