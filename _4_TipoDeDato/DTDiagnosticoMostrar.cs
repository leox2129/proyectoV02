using System;
using System.Collections.Generic;
using System.Text;

namespace _4_TipoDeDato
{
    public class DTDiagnosticoMostrar
    {
        private int idDiagonostico;//obtner todos los datos
        private string nombrePatologia;
        private int idPatologia;
        private int idUsuario;
        private bool quiereChat;
        private string estado;

        public DTDiagnosticoMostrar(int idDiagonostico, string nombrePatologia, int idPatologia, int idUsuario, bool quiereChat, string estado)
        {
            this.idDiagonostico = idDiagonostico;
            this.nombrePatologia = nombrePatologia;
            IdPatologia = idPatologia;
            IdUsuario = idUsuario;
            QuiereChat = quiereChat;
            Estado = estado;
        }

        public DTDiagnosticoMostrar(int idDiagonostico, string nombrePatologia, int idPatologia) 
        {
            this.idDiagonostico = idDiagonostico;
            this.nombrePatologia = nombrePatologia;
            IdPatologia = idPatologia;
            IdUsuario = -1;
            QuiereChat = false;
            Estado = "pendiente";
        }

        public DTDiagnosticoMostrar()
        {
            this.idDiagonostico = -1;
            this.nombrePatologia = "no calculado";
            IdPatologia = -1;
            IdUsuario = -1;
            QuiereChat = false;
            Estado = "pendiente";
        }

        public int IdDiagonostico { get => idDiagonostico; set => idDiagonostico = value; }
        public string NombrePatologia { get => nombrePatologia; set => nombrePatologia = value; }
        public int IdPatologia { get => idPatologia; set => idPatologia = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public bool QuiereChat { get => quiereChat; set => quiereChat = value; }
        public string Estado { get => estado; set => estado = value; }

        public static implicit operator DTDiagnosticoMostrar(DTDiagnostico v)
        {
            throw new NotImplementedException();
        }
    }
}
