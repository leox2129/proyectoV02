using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            AgregarProducto ap = new AgregarProducto();
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
    }
}







































































































































































