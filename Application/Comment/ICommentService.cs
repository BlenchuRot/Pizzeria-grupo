using Pizzeria.DTO;


namespace Pizzeria.Application
{
    public interface ICommentService
    {
        ReadCommentDTO Create(CreateCommentDTO createCommentDTO);

        void Read(CreateCommentDTO CommentDetailDTO);
        CreateCommentDTO Register(CreateCommentDTO commentRegistration);     

    }
} 


