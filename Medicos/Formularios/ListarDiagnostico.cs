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

namespace Medicos.Formularios
{
    public partial class ListarDiagnostico : Form
    {
        
        public ListarDiagnostico()
        {
            InitializeComponent();
            InitDataGrid();
        }

        
        

        private void InitDataGrid()
        {

            DiagnosticoModelo modelo = new DiagnosticoModelo();
            dgvDianostico.DataSource = modelo.ListarDiagnosticosMedico();           

        }
            
        private void btnAgregarSintoma_Click(object sender, EventArgs e)
        {
            int indice = -1;
            long idPatologia = -1;
            try
            {
                indice = dgvDianostico.CurrentRow.Index;
            }
            catch
            {
                MessageBox.Show("Seleccione un Patologia a editar");
            }
            if (indice > -1)
            {
                DataGridViewRow fila = dgvDianostico.CurrentRow;

                idPatologia = (long)fila.Cells[0].Value;
                string nombrePatologia = (string)fila.Cells[2].Value;
                //instanciar el chat
                /*SintomaPatologia formSintoma = new SintomaPatologia(idPatologia, nombrePatologia);
                //Agregarsin nuevo = new AgregarPatologiaNuevo(idSintoma);
                formSintoma.Show();*/
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSintomas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

