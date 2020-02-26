using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;

namespace Pizzeria.Application
{
    class ComentarioService : IComentarioService
    {
        private readonly ComentarioContext _context;
        public ComentarioService(ComentarioContext context)
        {
            _context = context;
        }

        public ComentarioRegistered Register(ComentarioRegistration comentarioRegistration)
        {
            var comentario = comentario.Create(comentarioRegistration); //se crea nuevo Comentario.Registration
            _context.comentario.Add(comentario);  //se descarga
            _context.SaveChanges(); //se guardan los cambios
            _context.Dispose();
            return comentarioRegistered.Create(comentario); //devuelve el usuario creado
        }
    }
}