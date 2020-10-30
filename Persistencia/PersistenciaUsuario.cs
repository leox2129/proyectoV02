using System;
using MySql.Data.MySqlClient;
using _4_TipoDeDato;



namespace _3_Persistencia
{
    public class PersistenciaUsuario
    {
        public Int32 RegistrarUsuario(DTUsuario usu)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = @"insert into usuarios ( nombre,password) values
                                (@nombre, @password)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", usu.Nombre);
                comando.Parameters.AddWithValue("@password", usu.Password);
                comando.ExecuteNonQuery();
                //obtiene el ultimo id ingresado
                return Int32.Parse(comando.LastInsertedId.ToString());
            }
            catch (MySqlException ex)
            {
                string mensaje = ex.ToString();
                Console.WriteLine("Error: " + mensaje);
                return -1;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
                
            }
        }


        /// <summary>
        /// login
        /// </summary>
        /// <param name="usu"></param>
        /// <returns></returns>
        public DTUsuario ObtenerUsuario(DTUsuario usu)
        {
            DTUsuario uARetornar = null;

            MySqlConnection conexion = null;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = "select idusuario, nombre, password from usuarios where nombre = @nombre and password = @password ";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", usu.Nombre);
                comando.Parameters.AddWithValue("@password", usu.Password);
                MySqlDataReader reader = comando.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Int32 id = reader.GetInt32(0);
                        string nombre = (reader[1] != DBNull.Value) ? reader.GetString(1) : "";
                        string password = (reader[2] != DBNull.Value) ? reader.GetString(2) : "";
                        uARetornar = new DTUsuario(id, nombre, password);
                    }
                }
                    return uARetornar;
            }
            catch (MySqlException ex)
            {
                string mensaje = ex.ToString();
                Console.WriteLine("Error: " + mensaje);
                return uARetornar;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }

            }
        }
    }
}
