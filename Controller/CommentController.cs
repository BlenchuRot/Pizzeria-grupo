using Microsoft.AspNetCore.Mvc;
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    [ApiController]
    [Route("[controller]")]
<<<<<<< HEAD
    public class CommentController : ControllerBase
=======
    public class CommentController: ControllerBase
>>>>>>> 9226e9703bfc45b5ae40869d7e4e4abf125ee1e3
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

<<<<<<< HEAD
            CreateCommentDTO createCommentDTO = _commentService.Register(commentRegistered);
            return StatusCode(201, commentRegistered);
=======
            CreateCommentDTO createCommentDTO = _commentService.Register(commentRegistration);
            return StatusCode(201, commentRegistration);
>>>>>>> 9226e9703bfc45b5ae40869d7e4e4abf125ee1e3

        }

    }

}
