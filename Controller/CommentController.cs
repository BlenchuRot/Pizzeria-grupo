using Microsoft.AspNetCore.Mvc;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        public readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
          public IActionResult Post([FromBody] ReadCommentDTO readComment)

        {  
            if (!ModelState.IsValid)
            {
               return BadRequest(ModelState);
            }

            ReadCommentDTO readCommentDTO = _commentService.ReadAll();
            return StatusCode(201, readCommentDTO);

        }

    }

}
