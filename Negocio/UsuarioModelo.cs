using System;
using System.Collections.Generic;
using System.Text;
using _4_TipoDeDato;
using _3_Persistencia;


namespace Negocio
{
    public class UsuarioModelo
    {
        private int id;
        private string nombre;
        private string estado;
        private string password;
        private string rolseleccionado;
        

        public UsuarioModelo()
        {

        }

        public UsuarioModelo(string nombre, string estado, string password, string rolseleccionado)
        {
            this.nombre = nombre;
            this.estado = estado;
            this.password = password;
            this.rolseleccionado = rolseleccionado;
        }

        public int RegsitrarUsuario(DTUsuario usu)
        {
            int idusuario = 0;

            /*PersistenciaUsuario p = new PersistenciaUsuario();
            Int32 idUsuGen = p.RegistrarUsuario(usu);
            return idUsuGen;*/
            return idusuario;
        }

        public List<DTUsuario> ListarUsuarios()
        {
            List<DTUsuario> list = new List<DTUsuario>();
            PersistenciaUsuario persistencia = new PersistenciaUsuario();
            list = persistencia.ListarUsuarios();
            return list;
        }

        /// <summary>
        /// retorna el id del usuario
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pasword"></param>
        /// <param name="usuarioRol"></param>
        /// <returns></returns>
        public int ObtenerUsuario(string nombreUsuario, string pasword, string usuarioRol)
        {

            int usuarioId = -1;
            PersistenciaUsuario usuarioPersistencia = new PersistenciaUsuario();            
            usuarioId = usuarioPersistencia.ObtenerUsuario(nombreUsuario, pasword, usuarioRol);
            return usuarioId;
            
        }

        public int Agregar()
        {
            int usuarioId = -1;
            PersistenciaUsuario usuarioPersistencia = new PersistenciaUsuario();
            usuarioId = usuarioPersistencia.AgregarUsuario(this.nombre, this.estado, this.password, this.rolseleccionado);
            return usuarioId;

            //this.nombre
        }
    }
    
}
