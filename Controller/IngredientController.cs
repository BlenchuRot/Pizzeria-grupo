using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.Application;
using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;
<<<<<<< HEAD
        public IngredientController(IIngredientService ingredientService)
=======



        public IngredientController(ILogger<IngredientController> logger, IIngredientService ingredientService)
>>>>>>> be10550a5e64f1179615617a1b3cab745f2f054e
        {
            _ingredientService = ingredientService;
        }
        [HttpGet] 
        public IActionResult Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
<<<<<<< HEAD
            
            return StatusCode(200, _ingredientService.ReadAll());
=======
            //Generar un .log que nos devuelva "Hola".
            _logger.LogCritical("Hola");

            ReadIngredientDTO readIngredientDTO = _ingredientService.ReadAll();
            //return Created;
            return StatusCode(201, readIngredientDTO);
>>>>>>> be10550a5e64f1179615617a1b3cab745f2f054e

           
        }
    }
}

