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

        public AgregarUsuario()
        {
            InitializeComponent();
            InitDataGrid();

        }
        private void InitDataGrid()
        {
            UsuarioModelo mostrar = new UsuarioModelo();
            dgvUsuario.DataSource = mostrar.ListarUsuarios();
            //dgvPatologia.DataSource = modelo.ListaPatologia();            
        }


        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //agregar palo
            
            string nombre = txtNombre.Text.Trim();
            string rol = txtRol.Text.Trim();
            string estado = txtEstado.Text.Trim();
            string password = txtPassword.Text.Trim();
            string errores = "";
            bool error = false;

            if (string.IsNullOrEmpty(nombre))
            {
                errores = "el nombre esta vacío\n";
            }
            if (string.IsNullOrEmpty(nombre))
            {
                errores += "No se selecciono gravedad\n";
                //errores = errores + "No se selecciono\n";                
            }
            try
            {
                //rol = (rol);
            }
            catch (Exception)
            {

                errores += "La gravedad no es un entero\n";
                error = true;
            }

            if (error)
            {
                MessageBox.Show(errores);
            }
            else
            {
                try
                {
                    //agregar sintoma
                  //  UsuarioModelo sintoma = new UsuarioModelo(nombre, rol);
                   // long idusuario = idusuario.Agregar();
                    txtNombre.Text = "";
                    this.InitDataGrid();

                }
                catch (Exception)
                {
                    MessageBox.Show(errores);
                }
            }

        }
    }
}
