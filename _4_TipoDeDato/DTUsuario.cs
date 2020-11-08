using System;

namespace _4_TipoDeDato
{
    public class DTUsuario
    {
        private string nombre;
        private string password;
        private int id;
        private string estado;
        private string rol;

        public DTUsuario(string nombre,string password, int id, string estado, string rol)
        {
            this.nombre = nombre;           
            this.id = id;
            this.estado = estado;
            this.rol = rol;
        }
        public DTUsuario(string nombre, int id, string estado, string rol)
        {
            this.nombre = nombre;
            this.id = id;
            this.estado = estado;
            this.rol = rol;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Password { get => password; set => password = value; }
    }

 }
