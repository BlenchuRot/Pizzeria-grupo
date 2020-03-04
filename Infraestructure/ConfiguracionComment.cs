using System;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Dominio;
using Pizzeria.DTO;

namespace Pizzeria.Infraestructure
{
    //creamos una clase para configurar un usuario
    public class CommentConfiguration
    {

        public static void Apply(ModelBuilder modelbuilder)
        {
            modelbuilder
            .Entity<Comment>(comment =>
            {
                comment.HasKey(comment => comment.Id);

                comment
                   .HasOne<User>(c => c.User)
                   .WithMany();
            });
        
    }
}
}