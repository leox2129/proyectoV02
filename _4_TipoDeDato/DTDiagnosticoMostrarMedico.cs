using System;
using System.Collections.Generic;
using System.Text;

namespace _4_TipoDeDato
{
    public class DTDiagnosticoMostrarMedico
    {
        int iddiagnostico;
        string estado;
        int gravedad;
        string nombrePatologia;
        string nombrePaciente;

        public DTDiagnosticoMostrarMedico(int iddiagnostico, string estado, int gravedad, string nombrePatologia, string nombrePaciente)
        {
            this.Iddiagnostico = iddiagnostico;
            this.Estado = estado;
            this.Gravedad = gravedad;
            this.NombrePatologia = nombrePatologia;
            this.NombrePaciente = nombrePaciente;
        }

        public int Iddiagnostico { get => iddiagnostico; set => iddiagnostico = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Gravedad { get => gravedad; set => gravedad = value; }
        public string NombrePatologia { get => nombrePatologia; set => nombrePatologia = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
    }
}
