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

        public DTSintoma()
        {
        }

        public DTSintoma(long id, string sintoma)
        {
            this.id = id;
            this.sintoma = sintoma;
            this.coef = 0;
            this.peligro = 0;
        }

        public DTSintoma(long id, string sintoma, double coef)
        {
            this.id = id;
            this.Sintoma = sintoma;
            this.coef = coef;
            this.peligro = 0;
        }
        
        public long Id { get => id; set => id = value; }        
        public double Coef { get => coef; set => coef = value; }
        public double Peligro { get => peligro; private set => peligro = value; }
        public string Sintoma { get => sintoma; set => sintoma = value; }
    }

    
}
