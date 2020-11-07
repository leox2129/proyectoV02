using System;
using System.Collections.Generic;
using System.Text;

namespace _4_TipoDeDato
{
    public class DTDiagnosticoMostrar
    {
        private long id;
        private string nombre;
   
    public DTDiagnosticoMostrar(long id,string nombre)
    {
        this.Id = id;
        this.nombre = nombre;
    }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
