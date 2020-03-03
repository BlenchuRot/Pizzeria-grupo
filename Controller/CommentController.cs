using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.Application;

namespace Pizzeria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        //Se crea un registro
      private readonly ILogger <CommentController> _logger;
      private readonly ICommentService _commentService;
      public CommentController (ILogger<CommentController>logger){
          _logger = logger;
          _commentService = commentService;
      }
        
      

    }
}
