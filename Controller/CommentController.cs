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
<<<<<<< HEAD
          public IActionResult Post([FromBody] CreateCommentDTO readComment)
=======
          public IActionResult Post([FromBody] CreateCommentDTO createComment)
>>>>>>> b312b2a437cfdfa3b9ac8cd10fa31054ac416455

        {  
            if (!ModelState.IsValid)
            {
               return BadRequest(ModelState);
            }

<<<<<<< HEAD
            CreateCommentDTO readCommentDTO = _commentService.Create();
=======
            ReadCommentDTO readCommentDTO = _commentService.Create(createComment);
>>>>>>> b312b2a437cfdfa3b9ac8cd10fa31054ac416455
            return StatusCode(201, readCommentDTO);

        }

    }

}
