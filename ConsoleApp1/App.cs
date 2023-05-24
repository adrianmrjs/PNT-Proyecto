using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class App
    {
        private String nombreApp;
        private ArrayList listaPersonas;
        private ArrayList listaAdministradores;

        public App(string nombre)
        {
            this.nombreApp = nombre;
        }

        public string Nombre
        {
            get { return nombreApp; }
            set { nombreApp = value; }
        }
    }
}
