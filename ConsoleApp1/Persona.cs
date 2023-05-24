using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        private int id;
        private String nombre;
        private String apellido;
        private String correo;
        private String contrasenia;

        public Persona(int id, string nombre, string correo, string contrasenia)
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
            this.contrasenia = contrasenia;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Contraseña
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
    }
}
