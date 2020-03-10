using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.Application;
using Pizzeria.Dominio;
using Pizzeria.DTO;
using System;

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

            _pizzaService.Create(pizzaRegistered);
            //return Created;
            return StatusCode(201);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var pizza = _pizzaService.GetById(id);
            if (pizza == null)
            {
                return NotFound();
            }
            return StatusCode(200, _pizzaService.GetById(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pizzaService.FindAll());
        }
    }
}

