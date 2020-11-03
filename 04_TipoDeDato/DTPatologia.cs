using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace _4_TipoDeDato
{
    class DTPatologia
    {
        private long id;
        private long gravedad;
        private string nombre;

        public DTPatologia(long id,long gravedad)
        {
            this.id = id;
            this.gravedad = gravedad;
        }

        public DTPatologia(long id, long gravedad, string nombre)
        {
            this.id = id;
            this.gravedad = gravedad;
            this.nombre = nombre;
        }
        public long Id { get => id; set => id = value; }
        public long Gravedad { get => gravedad; set => gravedad = value; }       
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
