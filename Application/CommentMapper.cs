using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application {
    public class CommentMapper {

        //con el método Comentario Create, creamos el Comentario.
        private PizzaService _pizzaService;
        public Comment ToComment(CreateCommentDTO dto){
             return new Comment
             (
                dto.Puntuacion,
                dto.Text,
                _pizzaService.GetById(dto.PizzaId)
             );

        }
        public LeerCommentDTO ToLeerCommentDTO(Comment comment ){
             return new LeerCommentDTO ()
             {

            };

        }

    }
}