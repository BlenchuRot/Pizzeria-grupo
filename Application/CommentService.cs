using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;
using Pizzeria.Infraestructure;

namespace Pizzeria.Application
{
    public class CommentService : ICommentService
    {
        private readonly PizzeriaContext _context;
        
        public CommentService (PizzeriaContext context){
            _context = context;
        }

        public void Create(CreateCommentDTO createCommentDTO)
        {
           
        }
    }
}