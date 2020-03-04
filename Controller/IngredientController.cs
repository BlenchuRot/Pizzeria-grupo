using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.Application;
using Pizzeria.DTO;
namespace Pizzeria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController: ControllerBase
    {
        private readonly ILogger<IngredientController> _logger;
        private readonly IIngredientService _ingredientService;
        public IngredientController(ILogger<IngredientController> logger, IIngredientService ingredientService)
        {
            _logger = logger;
            _ingredientService = ingredientService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] IIngredientService createIngredientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Generar un .log que nos devuelva "Hola".
            _logger.LogCritical("Hola");

            CreateIngredientDTO ingredientRegistration = _ingredientService.Create(createIngredientDTO);
            //return Created;
            return StatusCode(201, createIngredientDTO);

            //TODO: mirar fallo
        }
    }
}
