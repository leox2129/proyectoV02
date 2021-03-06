﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

///llamada a presentacion 



namespace Presentacion.Formularios
{
    public partial class Menu : Form
    {


        public Menu()
        {
            InitializeComponent();
          
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            AgregarSintomaPatologia ap = new AgregarSintomaPatologia();
            ap.Show();

            //UsuarioView usuarioView= new UsuarioView();
            //List<DataUsuario> lista = usuarioView.listaUsuarios();
            //dgv.DataSource = lista;
            /*foreach(DataUsuario usr in lista)
            {
                int n = dgv.Rows.Add(); //retorna el indice 
                dgv.Rows[n].Cells[0].Value = (string) usr.Nombre;
                dgv.Rows[n].Cells[1].Value = (string) usr.Apellido;                

            }*/

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            HacerConsulta ap = new HacerConsulta();
            ap.Show();

        }

        private void btnChat_Click(object sender, EventArgs e)
        {

            HacerConsulta ap = new HacerConsulta();
            ap.Show();

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
            AgregarPatologiaNuevo forpato = new AgregarPatologiaNuevo();
            forpato.Show();
         }

        private void btnSintopato_Click(object sender, EventArgs e)
        {
            SintomaPatologia sintopato = new SintomaPatologia();
            sintopato.Show();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario usuarios= new AgregarUsuario();
            usuarios.Show();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}







































































































































































