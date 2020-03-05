using Microsoft.AspNetCore.Mvc;
using Pizzeria.Application;


namespace Pizzeria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;
        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return StatusCode(200, _ingredientService.ReadAll());
        }
    }
}