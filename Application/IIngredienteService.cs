using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IIngredientService
    {
        void Create (CreateIngredientDTO createIngredientDTO);
        void Read(IngredientDetailsDTO ingredientDetailsDTO);
      
    }

}