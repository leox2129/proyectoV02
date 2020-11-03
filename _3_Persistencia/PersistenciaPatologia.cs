using System;
using System.Collections.Generic;
using System.Text;
using _4_TipoDeDato;
using MySql.Data.MySqlClient;



namespace _3_Persistencia
{
    public class PersistenciaPatologia
    {

        public long AgregarPatologia(string nombre, int gravedad)
        {
            MySqlConnection conexion = null;
            long idsintoma = 0;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = "insert into patologia (nombre,gravedad) values (@nombre,@gravedad)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@gravedad", gravedad);
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
        }//end agregar patologia

        

    public List<DTPatologia> ListarPatologia()
    {
            List<DTPatologia> list = new List<DTPatologia>();
            MySqlConnection conexion = null;
            MySqlDataReader reader = null;
            try
            {

                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql;
                sql = @"select idpatologia,gravedad,nombre
                        from patologia
                        order by idpatologia asc";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        //string s = reader.GetNameGet["id"];
                        string id = (reader[0] != DBNull.Value) ? reader.GetString(0) : "0"; ;
                        string gravedad = (reader[1] != DBNull.Value) ? reader.GetString(1) : "0"; ;
                        string nombre = (reader[2] != DBNull.Value) ? reader.GetString(2) : "";
                        long idLong = long.Parse(id);
                        int gravedadInt = int.Parse(gravedad);




                        DTPatologia sintomadata = new DTPatologia(idLong, gravedadInt, nombre);
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

        
    
