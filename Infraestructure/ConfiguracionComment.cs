using System;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Dominio;

namespace Pizzeria.Infraestructure
{
    //creamos una clase para configurar un usuario
    public class CommentConfiguration
    {

        public void Apply(ModelBuilder modelbuilder)
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