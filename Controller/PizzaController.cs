using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.Application;
using Pizzeria.DTO;

namespace Pizzeria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly ILogger<PizzaController> _logger;
        private readonly IPizzaService _pizzaService;
        public PizzaController(ILogger<PizzaController> logger, IPizzaService pizzaService)
        {
            _logger = logger;
            _pizzaService = pizzaService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreatePizzaDTO pizzaRegistered)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Generar un .log que nos devuelva "Hola".
            _logger.LogCritical("Hola");

            CreatePizzaDTO createPizzaDTO = _pizzaService.Create(pizzaRegistered);
            //return Created;
            return StatusCode(201, pizzaRegistered);
        }
    }
}

