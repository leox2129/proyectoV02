using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class AgregarSintoma : Form
    {
        public AgregarSintoma()
        {
            InitializeComponent();
        }

        private void btnAgregarSintoma_Click(object sender, EventArgs e)
        {
            //gi obterner el texto
            string nombrePatolologia = txtNombre.Text.Trim();
            bool error = false;
            string errores = "";
            if (string.IsNullOrEmpty(nombrePatolologia))
            {
                error = true;
                errores = "el nombre esta vacío\n";
                MessageBox.Show(errores);
            }
            else
            {                
                try{
                    //agregar sintoma
                }
                catch (Exception)
                {
                    MessageBox.Show(errores);

                }
            }
        }
    }
}

