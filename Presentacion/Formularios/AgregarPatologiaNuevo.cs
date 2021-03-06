﻿using System;
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

        private void btnAgregarSintoma_Click(object sender, EventArgs e)
        {
            //llar al formulario para agregar los sintomas a una patologiaP
            /*long varlong = 120;
            int varint = (int)varlong;*/
            int indice = -1;
            long idPatologia = -1;
            try
            {
                indice = dgvPatologia.CurrentRow.Index;                
            }
            catch
            {
                MessageBox.Show("Seleccione un Patologia a editar");
            }            
            if (indice > -1)
            {
                DataGridViewRow fila = dgvPatologia.CurrentRow;

                idPatologia = (long) fila.Cells[0].Value;
                string nombrePatologia = (string) fila.Cells[2].Value;
                SintomaPatologia formSintoma = new SintomaPatologia(idPatologia, nombrePatologia);
                //Agregarsin nuevo = new AgregarPatologiaNuevo(idSintoma);
                formSintoma.Show();
            }
                //DataProducto prod = new DataProducto();
                
        }
    }
}

