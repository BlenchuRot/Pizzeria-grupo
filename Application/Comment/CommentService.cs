using Pizzeria.Dominio;
using Pizzeria.DTO;
using Pizzeria.Infraestructure;

namespace Pizzeria.Application
{
    public class CommentService 
    {
        private readonly PizzeriaContext _context;
        private readonly IPizzaService _pizzaService;
        private readonly IUserService _userService;

        public CommentService(PizzeriaContext context, IPizzaService pizzaService, IUserService userService)
        {
            _context = context;
            _pizzaService = pizzaService;
            _userService = userService;
        }

        public ReadCommentDTO Create(CreateCommentDTO dto)
        {
            var comment = new Comment(dto.Puntuacion, dto.Text, _userService.FindById(dto.UserId));//Creamos el nuevo comentario con la puntuacion, texto y usuario
            _context.Comment.Add(comment);
            _pizzaService.AddComment(comment, dto.PizzaId);
            _context.SaveChanges(); //guarda los cambios
            _context.Dispose();
            // todo: 
            return ReadCommentDTO.Create(comment);
        }

        public CreateCommentDTO Register(CreateCommentDTO commentRegistration)
        {
            throw new System.NotImplementedException();
        }
    }
}