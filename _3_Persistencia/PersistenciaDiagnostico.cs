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



        public List<DTDiagnosticoMostrarMedico> ListarDiagnostico()
        {
            
            List<DTDiagnosticoMostrarMedico> list = new List<DTDiagnosticoMostrarMedico>();
            MySqlConnection conexion = null;
            MySqlDataReader reader = null;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql;
                sql = @"select diag.iddiagnosticos, diag.estado, diag.gravedad,
                        pat.nombre, usu.nombre
                        from diagnosticos as diag
                        inner join patologia as pat
                        on pat.idPatologia = diag.idPatologia
                        inner join usuarios as usu
                        on diag.idPaciente = usu.idUsuarios
                        where diag.quierechat=1 and  
                        estado='pendiente'
                        order by pat.gravedad desc";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

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
        }//end listar Diagnostico

        public void ActualizartDiagnosticoEstado(int idDiago)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = @"update diagnosticos SET estado='atendido' WHERE iddiagnosticos=@idDiago";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idDiago", idDiago);
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
                    conexion.Dispose();
                }
            }        
        }

        public void ActualizartDiagnostico(int idDiagonostico)
        {
            
            MySqlConnection conexion = null;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = @"update diagnosticos set quierechat=1
                               where iddiagnosticos = @iddialog";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@iddialog", idDiagonostico);                
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
            //
        }

        public List<DTDiagnosticoMostrarMedico> ListarDiagnosticoMedico()
        {
            {
                List<DTDiagnosticoMostrarMedico> list = new List<DTDiagnosticoMostrarMedico>();
                MySqlConnection conexion = null;
                MySqlDataReader reader = null;
                try
                {

                    conexion = ConexionDB.GetConexion();
                    conexion.Open();
                    string sql;
                    sql = @"select diag.iddiagnosticos, diag.estado, diag.gravedad,
                            pat.nombre, usu.nombre
                            from diagnosticos as diag
                            inner join patologia as pat
                            on pat.idPatologia = diag.idPatologia
                            inner join usuarios as usu
                            on diag.idPaciente = usu.idUsuarios
                            where diag.quierechat=1 and 
                            diag.estado='pendiente'
                            order by pat.gravedad desc";
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string idDiagnosticoStr = (reader[0] != DBNull.Value) ? reader.GetString(0) : "0";
                            string estado = (reader[1] != DBNull.Value) ? reader.GetString(1) : "0";
                            string gravedadStr = (reader[2] != DBNull.Value) ? reader.GetString(2) : "0";
                            string nombrePatologia = (reader[3] != DBNull.Value) ? reader.GetString(3) : "0";
                            string nombrePaciente = (reader[4] != DBNull.Value) ? reader.GetString(4) : "";
                            int idDiagnosticoInt = int.Parse(idDiagnosticoStr);
                            int graveddadInt = int.Parse(gravedadStr);
                            DTDiagnosticoMostrarMedico dataMedico = new DTDiagnosticoMostrarMedico(idDiagnosticoInt ,estado,graveddadInt,nombrePatologia,nombrePaciente);
                            list.Add(dataMedico);
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






    }//end class
}//end namespace
