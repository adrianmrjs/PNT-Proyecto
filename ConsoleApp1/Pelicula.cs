using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pelicula : Contenido
    {
        private double duracion;

        public double Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public Pelicula(string titulo, string director, Genero genero, double duracion)
            : base(titulo, director, genero)
        {
            this.duracion = duracion;
        }
    }
}
