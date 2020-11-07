using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace _4_TipoDeDato
{
    public class DTPatologia
    {
            private long id;
            private int gravedad;
            private string nombre;

        public DTPatologia(long id,int gravedad)
        {
            this.id = id;               
            this.Gravedad = gravedad;
        }

        public DTPatologia(long id, int gravedad, string nombre)
        {
            this.id = id;
            this.Gravedad = gravedad;
            this.nombre = nombre;
        }
        public long Id { get => id; set => id = value; }
       
        public string Nombre { get => nombre; set => nombre = value; }
        public int Gravedad { get => gravedad; set => gravedad = value; }
    }
}
