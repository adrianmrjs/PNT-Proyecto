using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Contenido
    {
        private string titulo;
        private string director;
        private Genero genero;

        public Contenido(string titulo, string director,  Genero genero)
        {
            this.titulo = titulo;
            this.director = director;
            this.genero = genero;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }


    }
}
