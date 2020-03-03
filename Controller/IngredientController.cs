using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.DTO;
using Pizzeria.Application;



namespace Pizzeria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly ILogger<IngredientController> _logger;
        private readonly IIngredientService _ingredientService;
        public IngredientController(ILogger<IngredientController> logger, IIngredientService ingredientService)
        {
            _logger = logger;
            _ingredientService = ingredientService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] ingredientRegistered ingredientRegistered)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Generar un .log que nos devuelva "Hola".
            _logger.LogCritical("Hola");

            IngredientRegistered ingredientRegistered = _ingredientService.Register(ingredientRegistered);
            //return Created;
            return StatusCode(201, ingredientRegistered);

            //TODO: mirar fallo
        }
    }
}
