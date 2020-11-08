using System;
using System.Collections.Generic;
using System.Text;
using _3_Persistencia;
using _4_TipoDeDato;

namespace Negocio
{
    public class Mensaje
    {
        public List<DataChat> ObtenerMensajes(int id)
        {
            List<DataChat> lista = new List<DataChat>();
            PersistenciaMensaje persistenciaMenaje = new PersistenciaMensaje();
            lista = persistenciaMenaje.GetMensajes(id);            
            return lista;
        }

        public static void Agregar(int idDiagnostico, int idUsuario, string mensaje)
        {
            PersistenciaMensaje persistenciaMenaje = new PersistenciaMensaje();
            persistenciaMenaje.Agregar(idDiagnostico, idUsuario, mensaje);
            
        }
    }
}
