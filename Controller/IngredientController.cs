using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.Application;
using System;
using Pizzeria.Dominio;

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
        [HttpGet]
        public IActionResult Post([FromBody] IIngredientService ReadIngredientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Generar un .log que nos devuelva "Hola".
            _logger.LogCritical("Hola");

            ReadIngredientDTO readIngredientDTO = _ingredientService.ReadAll();
            //return Created;
            return StatusCode(201, readIngredientDTO);

           
        }
    }
}

