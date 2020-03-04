using Pizzeria.DTO;


namespace Pizzeria.Application
{
    public interface ICommentService
    {
        ReadCommentDTO Create(CreateCommentDTO createCommentDTO);
<<<<<<< HEAD
        CreateCommentDTO Register(CreateCommentDTO commentRegistration);
=======

        void Read(CreateCommentDTO CommentDetailDTO);
        CreateCommentDTO Register(CreateCommentDTO commentRegistration);     
>>>>>>> c8a251bfc568a159c84769a079127e8e92d22287

    }
} 


