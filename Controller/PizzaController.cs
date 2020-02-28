using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.DTO;
using Pizzeria.Application;

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
        public IActionResult Post([FromBody] PizzaRegistration pizzaRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Generar un .log que nos devuelva "Hola".
            _logger.LogCritical("Hola");

            PizzaRegistered pizzaRegistered = _pizzaService.Register(pizzaRegistration);
            //return Created;
            return StatusCode(201, pizzaRegistered);
        }
    }
}

