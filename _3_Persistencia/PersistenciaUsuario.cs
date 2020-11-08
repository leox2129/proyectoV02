using System;
using MySql.Data.MySqlClient;
using _4_TipoDeDato;
using System.Collections.Generic;

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

        public List<DTUsuario> ListarUsuarios()
        {
            List<DTUsuario> list = new List<DTUsuario>();           
            MySqlConnection conexion = null;
            MySqlDataReader reader = null;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                //nombre
                string sql = @"select idUsuarios, rol, nombre, estado 
                                from usuarios 
                                where estado='activo'";
                /*string sql = @"select idUsuarios, nombre, password,  
                            from usuarios where nombre=@nombre and password=@password";*/
                MySqlCommand comando = new MySqlCommand(sql, conexion);                
                //comando.Parameters.AddWithValue("@password", usuarioPasword);
                reader = comando.ExecuteReader();
                //si hay por lo menos una fila entra
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string idUsuario = (reader[0] != DBNull.Value) ? reader.GetString(0) : "";
                        string rol = (reader[1] != DBNull.Value) ? reader.GetString(1) : "";
                        string nombre = (reader[2] != DBNull.Value) ? reader.GetString(2) : "";                                             
                        string estado = (reader[3] != DBNull.Value) ? reader.GetString(3) : "";
                        int idUsuarioInt = int.Parse(idUsuario);
                        DTUsuario data = new DTUsuario(nombre, idUsuarioInt,estado,rol);
                        list.Add(data);             
                    }
                }
            }
            catch (MySqlException ex)
            {
                string mensaje = ex.ToString();
                Console.WriteLine("Error: " + mensaje);                
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
                    conexion.Dispose();
                }

            }
            return list;
        }//ListarUsuarios end


        /// <summary>
        /// login 
        /// </summary>
        /// <param name="usu"></param>
        /// <returns></returns>
        public int ObtenerUsuario(string usuarioNombre, string usuarioPasword, string usuarioRol)
        {
            int uARetornar = -2;
            MySqlConnection conexion = null;
            MySqlDataReader reader = null;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                //nombre
                string sql = @"select idUsuarios, password, rol
                                from usuarios 
                                where nombre=@nombre  
                                and estado='activo'";               
                /*string sql = @"select idUsuarios, nombre, password,  
                            from usuarios where nombre=@nombre and password=@password";*/
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", usuarioNombre);
                //comando.Parameters.AddWithValue("@password", usuarioPasword);
                reader = comando.ExecuteReader();
                //si hay por lo menos una fila entra
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {                                                
                        int id = reader.GetInt32(0); 
                        //string nombre = (reader[1] != DBNull.Value) ? reader.GetString(1) : "";
                        string password = (reader[1] != DBNull.Value) ? reader.GetString(1) : "";
                        string rol = (reader[2] != DBNull.Value) ? reader.GetString(2) : "";
                        if ((rol==usuarioRol || rol=="admin") && password == usuarioPasword)
                        {
                            uARetornar = id;
                        }                        
                        //string password = (reader[2] != DBNull.Value) ? reader.GetString(2) : "";
                        //string rol = (reader[3] != DBNull.Value) ? reader.GetString(2) : "";
                        //if (usuarioRol==)
                        
                    }
                }                
            }
            catch (MySqlException ex)
            {
                string mensaje = ex.ToString();
                Console.WriteLine("Error: " + mensaje);
                uARetornar=-1;
            }
            finally
            {
                /**/if (conexion != null)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
                if (reader != null)
                {
                    reader.Close();
                    conexion.Dispose();
                }

            }
            return uARetornar;
        }//end 
    }//end class
}//end namespace
