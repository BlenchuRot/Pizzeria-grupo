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

