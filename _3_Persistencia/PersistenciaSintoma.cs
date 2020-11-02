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

        /*public List<DTSintoma> ListarSintomas(string consulta = null)
        {
            List<ProductoEntidad> list = new List<ProductoEntidad>();
            MySqlConnection conexion = null;
            try
            {
                MySqlDataReader reader = null;
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql;
                if (consulta == null)
                {
                    sql = "SELECT id_productos, codigo,descripcion,precio,fecha FROM productos";
                }
                else
                {
                    sql = "SELECT id_productos, codigo,descripcion,precio,fecha FROM productos " +
                        "WHERE codigo LIKE @consulta OR descripcion LIKE @consulta";

                }

                string searchTerm = string.Format("%{0}%", consulta);


                //Command.Parameters.Add(new SqlParameter("@name", searchTerm));

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@consulta", searchTerm);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string id = reader.GetString(0);
                        /*string codigo = (reader[1] != DBNull.Value) ? reader.GetString(1) : ""; ;
                        if (reader[1] != DBNull.Value)
                        {
                            string codigo = reader.GetString(1)
                        }
                        else
                        {
                            codigo = "";
                        }*/

                        /*string codigo = (reader[1] != DBNull.Value) ? reader.GetString(1) : ""; ;
                        string descripcion = (reader[2] != DBNull.Value) ? reader.GetString(2) : "";
                        string precio = (reader[3] != DBNull.Value) ? reader.GetString(3) : "0";
                        string fecha = (reader[4] != DBNull.Value) ? reader.GetString(4) : "1/1/2000 0:00:00";
                        ProductoEntidad prod = new ProductoEntidad
                        {
                            Id_productos = long.Parse(id),
                            Codigo = codigo,
                            Descripcion = descripcion,
                            Precio = float.Parse(precio)
                        };
                        DateTime fechaD = DateTime.ParseExact(fecha, "d/M/yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                        prod.Fecha = fechaD;
                        list.Add(prod);
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
            }
            return list;
        }*/
    }//end class
}//end namespace
