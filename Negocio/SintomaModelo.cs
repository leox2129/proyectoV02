using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;
using _3_Persistencia;
using _4_TipoDeDato;

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

        public SintomaModelo()
        {
        }

        public List<DTSintoma> ListarSintomas()
        {
            List<DTSintoma> list= new List<DTSintoma>();
            PersistenciaSintoma persistencia = new PersistenciaSintoma();
            list = persistencia.ListarSintomas();
            return list;
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
