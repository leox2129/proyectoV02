using System;
using System.Collections.Generic;
using System.Text;

namespace _4_TipoDeDato
{
    public class DTChat
    {
        private string nombre;
        private string mensaje;

        public DTChat(string nombre, string mensaje)
        {
            this.Nombre = nombre;
            this.Mensaje = mensaje;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }

    public class DataChat
    {
    }
}


