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


namespace Usuarios.Formularios
{
    public partial class Chat : Form
    {
        System.Timers.Timer t;
        private int cantidadMensajes = 0;
        private int idUsuario;
        private int idPatologia;
        public Chat(int idUsuario = 1, int idPatologia = 1)
        {
            this.idUsuario = idUsuario;
            this.idPatologia = idPatologia;
            InitializeComponent();
            InitChat();
            ActualizarListaChat();
        }
        private void InitChat()
        {
            t = new System.Timers.Timer();
            /*
            List<DTChat> list = null;
            Mensaje chat = new Mensaje();
            list = chat.ObtenerMensajes(this.idPatologia);
            string mensaje = "vacio";
            //llenar listbox.
            lstChat.Items.Add("inicio");
            t = new System.Timers.Timer();
            t.AutoReset = true;
            // Start the timer
            t.Enabled = true;

            t.Interval = 1000;//1s
            t.Elapsed += On_TimeEvent;*/
        }
        public Chat()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
            string mensaje = txtMensaje.Text;
            if (!string.IsNullOrEmpty(mensaje))
            {
                
                //Mensaje chat = new Mensaje();
                //id patologia, idUsuarioE, mensaje   

                //Mensaje.Agregar(idPatologia, idUsuario, mensaje);
                ///ActualizarListaChat();
                //lstChat.Items.Add(text);
                //lstChat.SelectedIndex = lstChat.Items.Count - 1;
            }
        }
        private void ActualizarListaChat()
        {

            List<DTChat> list = null;
            /*Mensaje chat = new Mensaje();
            list = chat.ObtenerMensajes(idPatologia);
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
            }*/
            t.Enabled = true;

        }
        private void On_TimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            string hola = "hola";
            ActualizarListaChat();
        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }
    }
}
