using System;
using Pizzeria.DTO;

namespace Pizzeria.Dominio
{

    public class Comment
    {
        private int puntuacion;
        private string text;

        public Comment(int puntuacion, string text)
        {
            this.puntuacion = puntuacion;
            this.text = text;
        }
    }
}