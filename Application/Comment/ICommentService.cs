using System;
using Pizzeria.Dominio;
using Pizzeria.DTO;


namespace Pizzeria.Application
{
    public interface ICommentService
    {   
         ReadCommentDTO Create(CreateCommentDTO createCommentDTO);
    }
    
}

