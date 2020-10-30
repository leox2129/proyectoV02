using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4_TipoDeDato;


namespace Presentacion.Formularios
{
    public partial class NivelSintomas : Form
    {
        private int v = 0;
        private int y = 20;
        const int altura = 25;
        List<DTSintoma> list;
        List<DTSintoma> listasintoma;
        private int indice = -1;


        public NivelSintomas()
        {
            InitializeComponent();
            Initcombox();
        }
        private void Initcombox()
        {
            DTSintoma ds1 = new DTSintoma(1 , "Tos", 40.0);
            DTSintoma ds2 = new DTSintoma(2, "Gripe", 30.0);
            DTSintoma ds3 = new DTSintoma(3, "Malestar", 35.0);
            this.listasintoma = new List<DTSintoma>();
            this.listasintoma.Add(ds1);
            this.listasintoma.Add(ds2);
            this.listasintoma.Add(ds3);
            this.list = new List<DTSintoma>();
            this.list.Add(ds1);
            this.list.Add(ds2);
            cmbsintomas.DataSource = this.listasintoma;
            cmbsintomas.ValueMember = "id";
            cmbsintomas.DisplayMember = "sintoma";
            ListarSintomas();

        }
        private void btn_Click(object sender1, EventArgs e1, string text, long id)
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
        private void Txt_TextChanged(object sender, EventArgs e, string coef, long id)
        {
            //            
            //this.list.Find(x => x.Id == id);
            bool encontrado = false;
            int cantidad = this.list.Count;
            int iter = 0;
            while (!encontrado)
            {
                if (this.list[iter].Id == id)
                {
                    encontrado = true;
                    this.list[iter].Coef = double.Parse(coef);
                }
                iter++;
            }
            //this.list[indice].Coef = coef;

        }
        private void EliminarSintomas()
        {
            
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
                lbl2.Tag = this.v;
                TextBox txt1 = new TextBox();
                txt1.Width = 100;
                txt1.Height = 22;
                txt1.Location = new Point(300, y);
                txt1.Text = item.Coef.ToString();
                txt1.Name = item.Coef.ToString();
                txt1.Tag = this.v;
                txt1.TextChanged += new EventHandler((sender1, e1) => Txt_TextChanged(sender1, e1, txt1.Text, item.Id));

                Button btn = new Button();
                btn.Location = new Point(460, y);
                btn.Text = "Eliminar" + item.Id.ToString();
                btn.Name = "Eliminar" + item.Id.ToString();
                btn.Tag = this.v;
                btn.Click += new EventHandler((sender1, e1) => btn_Click(sender1, e1, txt1.Text, item.Id));
                //btn.Click += new EventHandler((sender1, e1) => Txt_TextChanged(sender1, e1, txt1.Text, item.Id));

                //txt.TextChanged += Txt_TextChanged;
                this.grsintomas.Controls.Add(lbl1);
                this.grsintomas.Controls.Add(lbl2);
                this.grsintomas.Controls.Add(txt1);
                this.grsintomas.Controls.Add(btn);
                //cuadro de ponderacion
                //aumentar la y
                this.y += altura;
                this.v++;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.list.Clear();
            EliminarSintomas();
        }

        private void cmbSintomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indice = cmbsintomas.SelectedIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indice = cmbsintomas.SelectedIndex;
            if (this.indice != -1)
            {
                long id = this.listasintoma[indice].Id;
                DTSintoma sintomaData = this.listasintoma[indice];
                string sintoma = this.listasintoma[indice].Sintoma;
                MessageBox.Show("id:" + id + " el sintoma es: " + sintoma);
                this.list.Add(sintomaData);
                EliminarSintomas();
                ListarSintomas();
            }
        }
        private void cmbsintomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indice = cmbsintomas.SelectedIndex;
        }

        
    }


}
