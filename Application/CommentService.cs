using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;
using Pizzeria.Infraestructure;



namespace Pizzeria.Application
{
    public class CommentService : ICommentService
    {
        private readonly PizzeriaContext _context;
        private readonly IPizzaService _pizzaService;
        private readonly IUserService _userService;

        public CommentService (PizzeriaContext context, IPizzaService pizzaService, IUserService userService){
            _context = context;
            _pizzaService = pizzaService;
            _userService = userService;
        }

        public void Create(CreateCommentDTO dto)
        {
           var Comment = new Comment ()
           {
               Puntuacion = dto.puntuacion,
               Text = dto.text,
               User = _userService.FindById(dto.UserId),
               Id = Guid.NewGuid(),
               CreationDate = DateTime.Now
           };

        }
    }
}