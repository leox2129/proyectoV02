using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _4_TipoDeDato;


namespace Negocio
{
    public class DiagnosticoModelo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list">la lista de sintomas que tiene el paciente</param>
        public void CalcularPatologia(List<DTSintoma> list)
        {
            PatologiaModelo modelo = new PatologiaModelo();
            List<DTPatologia> listaPatologias =  modelo.ListarPatologias();
            double coefActual = 0;
            long idPatologia = -1;
            DTDiagnostico diagnostico = new DTDiagnostico();
            
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
                        coefCal += datasintoma.Coef;                        
                    }
                }
                if (coefCal > coefActual)
                {
                    idPatologia = patologia.Id;
                }

            }
        }//end calcular Patologia
    }
}
