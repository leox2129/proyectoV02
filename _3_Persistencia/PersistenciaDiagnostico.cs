using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using _4_TipoDeDato;

namespace _3_Persistencia
{
    public class PersistenciaDiagnostico
    {

        public int AgregarDiagnostico(int idpatologia, int idUsuario,int gravedad)
        {
            // 'pendiente'
            string estadoDiagnostico = "pendiente"; 
            MySqlConnection conexion = null;
            int iddiagnostico = -1;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = @"insert into diagnosticos 
                            (idPaciente, estado, gravedad, idPatologia) values 
                            (@idPaciente, @estado, @gravedad,@idPatologia)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idPaciente", idUsuario);
                comando.Parameters.AddWithValue("@estado", estadoDiagnostico);
                comando.Parameters.AddWithValue("@gravedad",gravedad );
                comando.Parameters.AddWithValue("@idPatologia", idpatologia);
                comando.ExecuteNonQuery();
                //obtiene el ultimo id ingresado
                long idDiagnosticoLong = comando.LastInsertedId;
                if (iddiagnostico <= int.MaxValue) 
                {
                    iddiagnostico = (int)idDiagnosticoLong;                    
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
            }
            return iddiagnostico;
        }//end agregar patologia



        public List<DTDiagnostico> ListarDiagnostico()
        {
            List<DTDiagnostico> list = new List<DTDiagnostico>();
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
                        string iddiagnostico = (reader[0] != DBNull.Value) ? reader.GetString(0) : "0"; ;
                        string idpatologia = (reader[1] != DBNull.Value) ? reader.GetString(1) : "0"; ;
                        string idpaciente = (reader[2] != DBNull.Value) ? reader.GetString(2) : "0";
                        string iddoctor = (reader[3] != DBNull.Value) ? reader.GetString(3) : "0";
                        string nombrepatologia = (reader[4] != DBNull.Value) ? reader.GetString(4) : "";
                        string chat = (reader[5] != DBNull.Value) ? reader.GetString(5) : "";
                        string nombrepaciente = (reader[6] != DBNull.Value) ? reader.GetString(6) : "";
                        string nombredoctor = (reader[7] != DBNull.Value) ? reader.GetString(7) : "";

                        int iddiagnosticoInt  = int.Parse(iddiagnostico);
                        int idpatologiaInt = int.Parse(idpatologia);
                        int idpacienteInt = int.Parse(idpaciente);
                        int iddoctorInt = int.Parse(iddoctor);
                        string nombrepatologiaVarchar = nombrepatologia;
                        string chatVarchar = chat;
                        string nombrepacienteVarchar = nombrepaciente;
                        string nombredoctorVarchar = nombredoctor;





                        // DTDiagnosticoMostrar diagnosticoMostrar = new DTDiagnostico(idLong, gravedadInt, nombre);
                        //list.Add(iddiagnostico);
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
    }
}
