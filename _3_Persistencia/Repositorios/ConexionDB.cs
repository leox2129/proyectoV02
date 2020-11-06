using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
//daba error, estaba en rojo, 
//ahora esta bien
/// <summary>
/// entendiste el arreglo?
/// se entendio yo no lo habia compilado ni limpiado
/// exacto 
/// si esta en rojo esta mal y es como referencia y 
/// aca nos escrimos 
/// genero un .dll eso es porque cree un proyecto de clases de libreria.
/// </summary>


namespace _3_Persistencia
{
    public class ConexionDB
    {    
        public static MySqlConnection GetConexion()
        {
            //string cadenaConexion = "Database=prueba; Data Source=localhost; Port=3306; User Id=usuario26; Password=usuario26";
            string cadenaConexion = "Database=base02; Data Source=localhost; Port=3306; User Id=usuario1; Password=usuario1";
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                Console.WriteLine("something is ");
            }catch (MySqlException ex){
                string mensaje = ex.ToString();
                Console.WriteLine("something is "+ex.ToString());
                
            }
            finally
            {
                Console.WriteLine("\n");
            }
            return conexion;        
        } 
    }
}
