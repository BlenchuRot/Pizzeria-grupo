using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.Application;
using Pizzeria.DTO;

namespace Pizzeria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComentarioController : ControllerBase
    {
        private readonly ILogger<ComentarioController> _logger;
        private readonly IComentarioService _comentarioService;
        public ComentarioController(ILogger<ComentarioController> logger, IComentarioService ComentarioService)
        {
            _logger = logger;
            _comentarioService = comentarioService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] ComentarioRegistration comentarioRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Generar un .log que nos devuelva "Hola".
            _logger.LogCritical("Hola");

            ComentarioRegistered comentarioRegistered = _comentarioService.Register(comentarioRegistration);
            //return Created;
           return StatusCode(201, comentarioRegistered);
        }
    }
}
