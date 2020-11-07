using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using _4_TipoDeDato;
using Negocio;
using Usuarios;

namespace Usuarios.Formularios
{
    public partial class SintomaPatologia : Form
    {
        
        private int v = 0;
        private int y = 20;      
        const int altura = 25;
        //lista sintomas de la enfermedad
        private List<DTSintoma> list;
        //lista de todos los sintomas.
        private List<DTSintoma> listasintomas;
        private int indice = -1;
        private long idPatologia;
        private string nombrePatologia;

        public SintomaPatologia()
        {
            InitializeComponent();
            Initcombox();
        }

        public SintomaPatologia(long idPatologia)
        {
            InitializeComponent();
            Initcombox();
            this.idPatologia = idPatologia;
        }

        public SintomaPatologia(long idPatologia, string nombrePatologia) 
        {
            InitializeComponent();
            this.idPatologia = idPatologia;
            this.nombrePatologia = nombrePatologia;
            Initcombox();            
            lblpatologia.Text = nombrePatologia;
        }

        private void Initcombox()
        {
            
          
            SintomaModelo sintomaModelo = new SintomaModelo();
          
            this.listasintomas = sintomaModelo.ListarSintomas();

            //esta carga los sintomasPatologia de la base de datos
            this.list = sintomaModelo.ListarSintomasPatologia(this.idPatologia);

            //this.list = new List<DTSintoma>();



            

            cmbsintomas.DataSource = this.listasintomas;
            cmbsintomas.ValueMember = "id";
            cmbsintomas.DisplayMember = "sintoma";
            //listo los sintomas;
            //listo los sintomas;
            ListarSintomas();

        }

        //eliminar por nombre
        private void EliminarSintomas()
        {
            this.grsintomas.Controls.Clear();
        }
    

        private void ListarSintomas()
        {
            this.y = 20;
            foreach (var item in this.list)
            {

                Label lbl1 = new Label();
                lbl1.Width = 46;
                lbl1.Height = 17;
                lbl1.Location = new Point(40, y);
                lbl1.Text = item.Id.ToString();
                lbl1.Name = item.Id.ToString();
                
                Label lbl2 = new Label();
                lbl2.Width = 46;
                lbl2.Height = 17;
                lbl2.Location = new Point(143, y);
                lbl2.Text = item.Sintoma.ToString();
                lbl2.Name = item.Sintoma.ToString();
                
                

                Button btn = new Button();
                btn.Location = new Point(460, y);
                btn.Text = "Eliminar"+item.Id.ToString();
                btn.Name = "Eliminar" + item.Id.ToString();
                btn.Tag = this.v;
                btn.Click += new EventHandler((sender1, e1) => btn_Click(sender1, e1, item.Id));
                //btn.Click += new EventHandler((sender1, e1) => Txt_TextChanged(sender1, e1, txt1.Text, item.Id));

                //txt.TextChanged += Txt_TextChanged;
                this.grsintomas.Controls.Add(lbl1);
                this.grsintomas.Controls.Add(lbl2);                
                this.grsintomas.Controls.Add(btn);
                //cuadro de ponderacion
                //aumentar la y
                this.y += altura;
                this.v++;
            }
        }

        private void btn_Click(object sender1, EventArgs e1, long id)
        {
            bool encontrado = false;
            int cantidad = this.list.Count;
            int iter = 0;
            int posicion = iter;
            while (!encontrado)
            {
                if (this.list[iter].Id == id)
                {
                    encontrado = true;                    
                    posicion = iter;
                }
                iter++;
            }
            this.list.RemoveAt(posicion);
            //borrar items
            EliminarSintomas();
            ListarSintomas();
        }

        
        //agregar
        private void button1_Click(object sender, EventArgs e)
        {
            int indice = cmbsintomas.SelectedIndex;
            if (this.indice != -1)
            {
                /*while (!encontrado || this.listasintomas.Count<iter)
                {
                    if (this.listasintomas[iter].Id == this.indice)
                    {
                        encontrado = true;
                        posicion = iter;
                    }
                    iter++;
                }*/
                long id = this.listasintomas[indice].Id;
                DTSintoma sintomaData = this.listasintomas[indice];
                string sintoma = this.listasintomas[indice].Sintoma;
                //MessageBox.Show("id:" + id + " el sintoma es: " + sintoma);
                List<DTSintoma> listaAux = this.list.Where(a => a.Id == id).ToList();
                if (listaAux.Count==0)
                {
                    this.list.Add(sintomaData);
                    EliminarSintomas();
                    ListarSintomas();
                }
                
                
            }


            //List<>
        }

        private void cmbsintomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indice = cmbsintomas.SelectedIndex;          
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDiagnosticar_Click(object sender, EventArgs e)
        {
            DiagnosticoModelo diagnosticoModelo = new DiagnosticoModelo();
            //retornar el dignostico
            DTDiagnosticoMostrar diagnostico = diagnosticoModelo.CalcularPatologia(this.list, Variables.Globales.idUsuario);
            MessageBox.Show("su diagnotico es" + diagnostico.NombrePatologia);
            DialogResult resultado = MessageBox.Show("quiere chatear\r\n agregar", "salir", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                //actualizar quiere chat
                Chat formChar = new Chat(Variables.Globales.idUsuario, diagnostico.IdDiagonostico);
                //diagnostico.IdDiagonostico;
                //Variables.Globales.idUsuario
                //diagnosticoModelo;
                //abrir un chat.
            }




        }

        /*private void btnGuardar_Click(object sender, EventArgs e)
        {
            //calcular diagonostico
            PatologiaModelo modelo = new PatologiaModelo();
            modelo.AgregarSintomaPalogia(this.list, this.idPatologia);
        }*/
    }
}
