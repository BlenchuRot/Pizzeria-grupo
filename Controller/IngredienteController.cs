using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.Application;
using Pizzeria.DTO;

namespace Pizzeria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredienteController : ControllerBase
    {
        private readonly ILogger<IngredienteController> _logger;
        private readonly IIngredienteService _ingredienteService;
        public IngredienteController(ILogger<IngredienteController> logger, IIngredienteService IngredienteService)
        {
            _logger = logger;
            _ingredienteService = ingredienteService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] IngredienteRegistration ingredienteRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Generar un .log que nos devuelva "Hola".
            _logger.LogCritical("Hola");

            IngredienteRegistered ingredienteRegistered = _ingredienteService.Register(ingredienteRegistration);
            //return Created;
           return StatusCode(201, ingredienteRegistered);
        }
    }
}
