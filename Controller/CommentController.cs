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
        public IActionResult Post([FromBody] CreateCommentDTO commentRegistered)

        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CreateCommentDTO createCommentDTO = _commentService.Register(commentRegistration);
            return StatusCode(201, commentRegistration);

        }

    }

}
