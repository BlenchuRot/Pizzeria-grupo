using Pizzeria.DTO;


namespace Pizzeria.Application
{
    public interface ICommentService
    {
        ReadCommentDTO Create(CreateCommentDTO createCommentDTO);

        void Read(CreateCommentDTO commentDetailDTO);
        CreateCommentDTO Register(CreateCommentDTO commentRegistration);

    }
} 


