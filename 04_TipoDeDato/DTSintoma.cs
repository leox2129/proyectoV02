using System;
using System.Collections.Generic;
using System.Text;

namespace _4_TipoDeDato
{
    public class DTSintoma
    {
        private long id;
        private string sintoma;
        private double coef;
        private double peligro;

        public DTSintoma(long id, string sintoma)
        {
            this.id = id;
            this.sintoma = sintoma;
        }

        public DTSintoma(long id, string sintoma, double coef)
        {
            this.id = id;
            this.sintoma = sintoma;
            this.coef = coef;
        }
        public void hola()
        {
            DTSintoma sin = new DTSintoma(111,"hola");

        }
        public long Id { get => id; set => id = value; }
        public string Sintoma { get => sintoma; set => sintoma = value; }
        public double Coef { get => coef; set => coef = value; }
        public double Peligro { get => peligro; private set => peligro = value; }
    }

    
}
