using _4_TipoDeDato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Medicos.Variables;


namespace Medicos.Formularios
{
    public partial class Chat : Form
    {
        System.Timers.Timer t;
        private int cantidadMensajes = 0;
        private int idUsuario;
        private int idDiagnostico;//diag
        public Chat(int idUsuario = 1, int idDiagnostico = 1)
        {
            this.idUsuario = Variables.Globales.idUsuario;
            this.idDiagnostico = idDiagnostico;
            InitializeComponent();
            InitChat();
            ActualizarListaChat();
        }
        private void InitChat()
        {

            //
            List<DataChat> list = null;
            Mensaje chat = new Mensaje();
            list = chat.ObtenerMensajes(this.idDiagnostico);

            //llenar listbox.
            //lstChat.Items.Add("inicio");
            t = new System.Timers.Timer();
            t.AutoReset = true;
            // Start the timer
            t.Enabled = true;

            t.Interval = 1000;//1s
            t.Elapsed += On_TimeEvent;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //paro timer 
            //llamo al metodo
            //incio el timer
            //t.Stop
            //t.Enabled = true;
            t.Enabled = false;
            string mensaje = txtMensaje.Text;
            if (!string.IsNullOrEmpty(mensaje))
            {
                Mensaje chat = new Mensaje();
                //id patologia, idUsuarioE, mensaje   

                Mensaje.Agregar(idDiagnostico, this.idUsuario, mensaje);
                ActualizarListaChat();
                //lstChat.Items.Add(text);
                //lstChat.SelectedIndex = lstChat.Items.Count - 1;
            }
        }


        private void listChat_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        /*private void Chat_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;//1s
            t.Elapsed += On_TimeEvent;
        }*/
        private void ActualizarListaChat()
        {

            List<DataChat> list = null;
            Mensaje chat = new Mensaje();
            list = chat.ObtenerMensajes(this.idDiagnostico);
            if (list.Count > this.cantidadMensajes)
            {
                int total = list.Count;
                for (int i = this.cantidadMensajes; i < total; i++)
                {
                    string text = list[i].Nombre + ": " + list[i].Mensaje;
                    lstChat.Items.Add(text);
                    lstChat.SelectedIndex = lstChat.Items.Count - 1;
                }
                this.cantidadMensajes = list.Count;
            }
            t.Enabled = true;
            //list.Count = l


            /*foreach (DataChat item in list)
            {
                string text = item.Nombre + ": " + item.Mensaje;
                lstChat.Items.Add(text);
                lstChat.SelectedIndex = lstChat.Items.Count - 1;
            }*/
        }





        private void On_TimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {

            ActualizarListaChat();
        }
    }

}

