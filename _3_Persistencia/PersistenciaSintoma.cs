using System;
using System.Collections.Generic;
using System.Text;
using _4_TipoDeDato;
using MySql.Data.MySqlClient;

namespace _3_Persistencia
{
    public class PersistenciaSintoma
    {
        public long AgregarSintoma(string nombreSintoma)
        {            
            MySqlConnection conexion = null;
            long idsintoma = 0;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = "insert into sintomas (nombre) values (@nombre)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", nombreSintoma);
                comando.ExecuteNonQuery();
                //obtiene el ultimo id ingresado
                idsintoma = comando.LastInsertedId;
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
            }
            return idsintoma;
        }

        public void AgregarSintomaPatologia(List<DTSintoma> list, long idPatologia)
        {
            MySqlConnection conexion = null;
            long idsintoma = 0;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = "delete from sintomapatologia where idpatologia=@idpat";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idpat", idPatologia);
                comando.ExecuteNonQuery();
                sql = @"insert into sintomapatologia
                           (idsintomas, idpatologia, coeficiente) VALUES(@idsintoma, @idsintoma, @idsintoma)";
                foreach (DTSintoma item in list)
                {
                    comando.Parameters.AddWithValue("@idpat", idPatologia);


                }




                string sql = "insert into sintomas (nombre) values (@nombre)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", nombreSintoma);
                comando.ExecuteNonQuery();
                //obtiene el ultimo id ingresado
                //idsintoma = comando.LastInsertedId;
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
            }            
        }
        /*
        public void EditarProducto(ProductoEntidad entidad)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();

                string sql = "UPDATE productos SET codigo=@codigo, descripcion=@descripcion, " +
                    "precio= @precio, fecha= @fecha WHERE id_productos= @id";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@codigo", entidad.Codigo);
                comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
                comando.Parameters.AddWithValue("@precio", entidad.Precio);
                comando.Parameters.AddWithValue("@fecha", entidad.Fecha);
                comando.Parameters.AddWithValue("@id", entidad.Id_productos);
                comando.ExecuteNonQuery();
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
                }
            }
        }*/

        public List<DTSintoma> ListarSintomas()
        {
            List<DTSintoma> list = new List<DTSintoma>();
            MySqlConnection conexion = null;
            MySqlDataReader reader = null;
            try
            {
                
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql;                
                sql = @"select idsintomas as id, nombre as nombre 
                        from sintomas
                        order by idsintomas asc";                               
                MySqlCommand comando = new MySqlCommand(sql, conexion);                
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        //string s = reader.GetNameGet["id"];
                        string id = (reader[0] != DBNull.Value) ? reader.GetString(0) : "0"; ;
                        string sintoma = (reader[1] != DBNull.Value) ? reader.GetString(1) : "";
                        long idLong = long.Parse(id);
                        DTSintoma sintomadata = new DTSintoma(idLong, sintoma);                                                                      
                        list.Add(sintomadata);
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
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return list;
        }
    }//end class
}//end namespace
