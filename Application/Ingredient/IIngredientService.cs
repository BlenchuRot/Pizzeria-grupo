using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IIngredientService
    {
        void Create(CreateIngredientDTO createIngredientDTO);
        void Read(IngredientRegisterDTO ingredientDetailDTO);
        IngredientRegisterDTO Register(IngredientRegisterDTO ingredientRegisterDTO);

    }

}