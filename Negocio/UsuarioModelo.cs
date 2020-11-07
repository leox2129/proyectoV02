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

        public UsuarioModelo()
        {

        }
        public int RegsitrarUsuario(DTUsuario usu)
        {
            int idusuario = 0;

            /*PersistenciaUsuario p = new PersistenciaUsuario();
            Int32 idUsuGen = p.RegistrarUsuario(usu);
            return idUsuGen;*/
            return idusuario;
        }

        public object ListarUsuarios()
        {
            throw new NotImplementedException();
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
    }
    
}
