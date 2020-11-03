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
using _4_TipoDeDato;

namespace Presentacion.Formularios
{
    public partial class AgregarPatologiaNuevo : Form
    {
        public AgregarPatologiaNuevo()
        {
            InitializeComponent();
            InitDataGrid();            
        }

        private void InitDataGrid()
        {
            PatologiaModelo modelo = new PatologiaModelo();
            dgvPatologia.DataSource = modelo.ListarPatologias();
            //dgvPatologia.DataSource = modelo.ListaPatologia();            
        }
            
        private void btnAgregarPatologia_Click(object sender, EventArgs e)
        {

            //agregar palo
            string gravedadPatologia = txtGravedad.Text.Trim();
            int gravedadPatologiaInt = 0;
            string nombrePatologia = txtNombre.Text.Trim();            
            string errores = "";
            bool error = false;

            if (string.IsNullOrEmpty(nombrePatologia))
            {                
                errores = "el nombre esta vacío\n";                
            }
            if (string.IsNullOrEmpty(nombrePatologia))
            {
                errores += "No se selecciono gravedad\n";
                //errores = errores + "No se selecciono\n";                
            }
            try
            {
                gravedadPatologiaInt = int.Parse(gravedadPatologia);
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
                try{
                    //agregar sintoma
                    PatologiaModelo sintoma = new PatologiaModelo(nombrePatologia, gravedadPatologiaInt);
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

        private void dgvSintomas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarPatologiaNuevo_Load(object sender, EventArgs e)
        {

        }
    }
}

