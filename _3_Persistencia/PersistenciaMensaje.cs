using System;
using System.Collections.Generic;
using System.Text;
using _4_TipoDeDato;
using MySql.Data.MySqlClient;

namespace _3_Persistencia
{
    public class PersistenciaMensaje
    {
        public List<DataChat> GetMensajes(int diag)
        {

            List<DataChat> list = new List<DataChat>();
            MySqlDataReader reader = null;
            MySqlConnection conexion = null;
            try
            {

                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql;
                sql = @"select  usu.nombre, men.mensaje 
                        from mensaje as men
                        inner join usuarios as usu
                        on  usu.idUsuarios = men.idUsuario
                        where men.idDiagnostico=?diag";                        
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                //comando.Parameters.AddWithValue("@diag", diag);
                comando.Parameters.Add("?diag", MySqlDbType.Int32).Value = diag;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string nombre = (reader[0] != DBNull.Value) ? reader.GetString(0) : "";
                        string mensaje = (reader[1] != DBNull.Value) ? reader.GetString(1) : "";
                        DataChat dataMensaje = new DataChat(nombre, mensaje);
                        list.Add(dataMensaje);
                    }
                }

            }
            catch (MySqlException ex)
            {
                string mensaje = ex.ToString();
                Console.WriteLine("hola" + mensaje);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }
            }
            return list;
        }
    }
}
