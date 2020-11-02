using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;
using _3_Persistencia;


namespace Negocio
{
    public class SintomaModelo
    {
        private string nombreSintoma;

        public SintomaModelo(string nombreSintoma)
        {            
            if (nombreSintoma.Length <= 45)
            {
                this.nombreSintoma = nombreSintoma;
            }else
            {
                this.nombreSintoma = nombreSintoma.Substring(0, 45);
            }                        
        }

        public long Agregar()
        {
            long idsintoma = 0;
            PersistenciaSintoma persistencia = new PersistenciaSintoma();
            idsintoma = persistencia.AgregarSintoma(this.nombreSintoma);
            return idsintoma;
        }
    }
}
