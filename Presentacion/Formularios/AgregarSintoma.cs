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

namespace Presentacion.Formularios
{
    public partial class AgregarSintoma : Form
    {
        public AgregarSintoma()
        {
            InitializeComponent();
            InitDataGrid();
        }

        private void InitDataGrid()
        {
            SintomaModelo modelo = new SintomaModelo();
            dgvSintomas.DataSource = modelo.ListarSintomas();            
        }
            
        private void btnAgregarSintoma_Click(object sender, EventArgs e)
        {
            //gi obterner el texto
            string nombreSintoma = txtNombre.Text.Trim();            
            string errores = "";
            if (string.IsNullOrEmpty(nombreSintoma))
            {                
                errores = "el nombre esta vacío\n";
                MessageBox.Show(errores);
            }
            else
            {                
                try{
                    //agregar sintoma
                    SintomaModelo sintoma = new SintomaModelo(nombreSintoma);
                    long idsintoma = sintoma.Agregar();
                    txtNombre.Text = "";
                    this.InitDataGrid();

                }
                catch (Exception)
                {
                    MessageBox.Show(errores);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

