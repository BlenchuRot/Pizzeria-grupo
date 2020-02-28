using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Application {
    public class CommentMapper {

        //con el método Comentario Create, creamos el Comentario.
        public  Comment ToComment(CrearCommentDTO dto){
             return new Comment(dto.Puntuacion,
                                dto.Text);
        }
        public static LeerCommentDTO ToLeerCommentDTO(Comment comment ){
             return new LeerCommentDTO() {

            };

        }

    }
}