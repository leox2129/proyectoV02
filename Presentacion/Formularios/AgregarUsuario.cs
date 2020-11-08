using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Windows.Forms;
using _4_TipoDeDato;

namespace Presentacion.Formularios
{
    public partial class AgregarUsuario : Form
    {
        string rolseleccionado;
        public AgregarUsuario()
        {
            InitializeComponent();
            InitDataGrid();
            
        }
        private void InitDataGrid()
        {
            //this.rolseleccionado = "paciente";
            cmbRol.SelectedIndex = 1;
            //this.rolseleccionado = (string)cmbRol.Items[indice];
            UsuarioModelo mostrar = new UsuarioModelo();
            dgvUsuario.DataSource = mostrar.ListarUsuarios();
            

            //dgvPatologia.DataSource = modelo.ListaPatologia();            


            //cmbRol.DataSource = ;
            //cmbRol.ValueMember = "id";
            //cmbRol.DisplayMember = "sintoma";
        }




        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            
            //agregar palo

            string nombre = txtNombre.Text.Trim();
            //string rol = txtRol.Text.Trim();
            string estado = txtEstado.Text.Trim();
            string password = txtPassword.Text.Trim();
            string errores = "";
            bool error = false;

            if (string.IsNullOrEmpty(nombre))
            {
                errores = "el nombre esta vacío\n";
            }
            if (string.IsNullOrEmpty(estado))
            {
                errores += "No se escribio estado\n";
                //errores = errores + "No se selecciono\n";                
            }
            try
            {

                //this.rolsel/eccionado;
                UsuarioModelo modelo = new UsuarioModelo(nombre, estado, password, this.rolseleccionado);
                int idUsuario = modelo.Agregar();
            }

            catch (Exception)
            {

            }

            if (error)
            {
                MessageBox.Show(errores);
            }
            else
            {
                try
                {
                   
                }
                catch (Exception)
                {
                    MessageBox.Show(errores);
                }
            }

        }
        int indice = -1;


        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aca hay error
            this.indice = cmbRol.SelectedIndex;
            this.rolseleccionado = (string)cmbRol.Items[indice];
            //string rol =  

            //string gestino = (string)cmbRol.Items[0];
            //string gestino = (string)cmbRol.Items[0];


        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
