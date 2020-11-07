using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _4_TipoDeDato;
using _3_Persistencia;


namespace Negocio
{
    public class DiagnosticoModelo
    {
        public DiagnosticoModelo()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list">la lista de sintomas que tiene el paciente</param>
        public DTDiagnosticoMostrar CalcularPatologia(List<DTSintoma> list, int idUsuario)
        {
            DTDiagnosticoMostrar diagnostico = new DTDiagnosticoMostrar();
            PatologiaModelo modelo = new PatologiaModelo();
            List<DTPatologia> listaPatologias =  modelo.ListarPatologias();
            double coefActual = 0;
            long idPatologia = -1;
            //DTDiagnostico diagnostico = new DTDiagnostico();
            string nombrePatologia = "sin diagonostico";
            int gravedaDiagonostivo=-1;
            foreach (DTPatologia patologia in listaPatologias)
            {
                SintomaModelo sintomaModelo = new SintomaModelo();
                //List<DT>                
                double coefCal = 0;
                List<DTSintoma> sintomasPat = sintomaModelo.ListarSintomasPatologia(patologia.Id);
                foreach (var item in list)
                {
                    
                    List<DTSintoma> listaAux = sintomasPat.Where(a => a.Id == item.Id).ToList();
                    //el sintoma forma parte de la patologia que estoy calculando
                    if (listaAux.Count > 0)
                    {
                        //obtener el data sintoma DTSintoma de la enfermedad 
                        DTSintoma datasintoma = listaAux[0];
                         //datasintoma = new DTSintoma();
                        coefCal += datasintoma.Coef;                        
                    }
                }
                if (coefCal >= coefActual)
                {
                    coefActual = coefCal;
                    //coefCal = coefActual;
                    idPatologia = patologia.Id;
                    nombrePatologia = patologia.Nombre;
                    gravedaDiagonostivo = patologia.Gravedad;
                    //patologia.Nombre 
                }
                //hacer el insert a la base de datos                
                //diagnostico.Nombrepatologia = "dd";
            }
            int idDiagnostico = -1;
            
            PersistenciaDiagnostico diagnosticoPersistencia = new PersistenciaDiagnostico();
            int idPatologiaInt = 0;
            if (idPatologia <= int.MaxValue)
            {
                idPatologiaInt = (int)idPatologia;
            }


            diagnostico.IdPatologia = idPatologiaInt;
            diagnostico.IdUsuario = idUsuario;
            diagnostico.Gravedad = gravedaDiagonostivo;
            idDiagnostico = diagnosticoPersistencia.AgregarDiagnostico(diagnostico.IdPatologia, diagnostico.IdUsuario, diagnostico.Gravedad);
            diagnostico.IdDiagonostico = idDiagnostico;                        
            return diagnostico;
        }//end calcular Patologia
    }
}
