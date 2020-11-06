using System;
using System.Collections.Generic;
using System.Text;

namespace _4_TipoDeDato
{
    public class DTDiagnostico
    {
        private int iddiagnostico;
        private int idpatologia;
        private int quierechat;
        private int idpaciente;
        private int iddoctor;
        
        private string nombrepatologia;
        private string chat;
        private string nombrepaciente;
        private string nombredoctor;

        public int Iddiagnostico { get => iddiagnostico; set => iddiagnostico = value; }
        public int Idpatologia { get => idpatologia; set => idpatologia = value; }
        public int Quierechat { get => quierechat; set => quierechat = value; }
        public int Idpaciente { get => idpaciente; set => idpaciente = value; }
        public int Iddoctor { get => iddoctor; set => iddoctor = value; }
        public string Nombrepatologia { get => nombrepatologia; set => nombrepatologia = value; }
        public string Chat { get => chat; set => chat = value; }
        public string Nombrepaciente { get => nombrepaciente; set => nombrepaciente = value; }
        public string Nombredoctor { get => nombredoctor; set => nombredoctor = value; }
    }


}

