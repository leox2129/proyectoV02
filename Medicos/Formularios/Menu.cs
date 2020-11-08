using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4_TipoDeDato;




///llamada a presentacion 



namespace Medicos.Formularios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            InitDgvDiadnostico();
        }

        private void InitDgvDiadnostico()
        {
            /*
            DiagnosticoModelo diagnostico = new DiagnosticoModelo();
            List<DTDiagnosticoMostrar> listaDiagnostico = new List<DTDiagnosticoMostrar>();*/
        }



        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            /*
            HacerConsulta ap = new HacerConsulta();
            ap.Show();*/

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            /*

            C ap = new HacerConsulta();
            ap.Show();*/

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMaximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximisar.Visible = false;
            btnRestau.Visible = true;

        }

        private void btnRestau_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestau.Visible = false;
            btnMaximisar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPatologia_Click(object sender, EventArgs e)
        {
            /*
            AgregarPatologiaNuevo forpato = new AgregarPatologiaNuevo();
            forpato.Show();*/
         }

        private void btnSintopato_Click(object sender, EventArgs e)
        {
            /*
            SintomaPatologia sintopato = new SintomaPatologia();
            sintopato.Show();*/

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }



        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListarDignostico_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListarDignostico_Click_1(object sender, EventArgs e)
        {
            ListarDiagnostico listarDiagnostico = new ListarDiagnostico();
            listarDiagnostico.Show();
        }
    }
}







































































































































































