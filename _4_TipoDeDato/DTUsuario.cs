using System;

namespace _4_TipoDeDato
{
    public class DTUsuario
    {
        public string Nombre;
        public string Password;
        private int id;
        private string Rol;


        public DTUsuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }

        public DTUsuario(int id, string nombre, string password,string rol )
        {
            this.id = id;
            Nombre = nombre;
            Password = password;
            Rol = rol;
            
        }


    }

 }
