using System;
using System.Collections.Generic;
using System.Text;
using _4_TipoDeDato;

namespace Negocio
{
    public class Usuario
    {        
        public int RegsitrarUsuario(DTUsuario usu)
        {
            int idusuario = 0;

            /*PersistenciaUsuario p = new PersistenciaUsuario();
            Int32 idUsuGen = p.RegistrarUsuario(usu);
            return idUsuGen;*/
            return idusuario;
        }

        public DTUsuario ObtenerUsuario(DTUsuario usu)
        {
            DTUsuario dataUsuario = new DTUsuario();
            //PersistenciaUsuario p = new PersistenciaUsuario();
            return dataUsuario;
            //return p.ObtenerUsuario(usu);
        }
    }
    
}
