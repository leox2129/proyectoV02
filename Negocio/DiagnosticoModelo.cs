using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _4_TipoDeDato;



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
        public DTDiagnosticoMostrar CalcularPatologia(List<DTSintoma> list)
        {
            DTDiagnosticoMostrar diagnotico = new DTDiagnosticoMostrar();
            PatologiaModelo modelo = new PatologiaModelo();
            List<DTPatologia> listaPatologias =  modelo.ListarPatologias();
            double coefActual = 0;
            long idPatologia = -1;
            DTDiagnostico diagnostico = new DTDiagnostico();
            string nombrePatologia = "sin diagonostico";

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
                    coefCal = coefActual;
                    idPatologia = patologia.Id;
                    nombrePatologia = patologia.Nombre;                    
                    //patologia.Nombre 
                }
                //hacer el insert a la base de datos

                int idDiagnostico = -1;
                diagnostico.Iddiagnostico = idDiagnostico;
                diagnostico.Nombrepatologia = "dd";
            }
            return diagnotico;
        }//end calcular Patologia
    }
}
