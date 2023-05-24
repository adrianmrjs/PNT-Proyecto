using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Serie : Contenido
    {
        private int cantCapitulos;
        private int cantTemp;

        public int CantCapitulos
        {
            get { return cantCapitulos; }
            set { cantCapitulos = value; }
        }

        public int CantTemp
        {
            get { return cantTemp; }
            set { cantTemp = value; }
        }

        public Serie(string titulo, string director, Genero genero, int cantCapitulos, int cantTemp)
            : base(titulo, director, genero)
        {
            this.cantCapitulos = cantCapitulos;
        }
    }

}
