using Microsoft.AspNetCore.Mvc;




namespace Pizzeria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private string IIngredient { get; set;}
    }
}
