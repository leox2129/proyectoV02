using System;
using System.Collections.Generic;
using System.Text;
using _3_Persistencia;
using _4_TipoDeDato;

namespace Negocio
{
    public class PatologiaModelo
    {
        //private long id;
        private int gravedad;
        private string nombre;

        public PatologiaModelo()
        {

        }

        public PatologiaModelo(string nombrePatologia, int gravedadPatologiaInt)
        {
            this.nombre = nombrePatologia;
            this.gravedad = gravedadPatologiaInt;
        }

        //public long Id { get => id; set => id = value; }
        public int Gravedad { get => gravedad; set => gravedad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public List<DTPatologia> ListarPatologias()
        {

            List<DTPatologia> list = new List<DTPatologia>();
            PersistenciaSintoma persistencia = new PersistenciaSintoma();
            list = persistencia.ListarPatologia();
            return list;
        }

        public long Agregar()
        {
            long idPatologia = 0;
            PersistenciaPatologia pato = new PersistenciaPatologia();
            idPatologia = pato.AgregarPatologia(this.nombre, this.gravedad);
            return idPatologia;
            
        }
    }
}
