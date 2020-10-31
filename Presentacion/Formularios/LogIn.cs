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
using Negocio;
using Presentacion.Variables;


namespace Presentacion.Formularios
{
    public partial class LogIn : Form
    {
        //GestionUsuario UG = null; 

        public LogIn()
        {
            InitializeComponent();
            //UG = new GestionUsuario();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
     
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {            
            string errores ="";
            bool error = false;
            string usuarioNombre = txtMombreUsu.Text.Trim();
            string usuarioPasword = txtPassUsuario.Text.Trim();

            if (string.IsNullOrEmpty(usuarioNombre))
            {
                error = true;
                errores = "el nombre usuario esta vacio\n";
            }
            if (string.IsNullOrEmpty(usuarioPasword)){
                error = true;
                //errores = errores + "el nombre usuario esta vacio\n";
                errores += "el nombre password esta vacio\n";
            }

            if (error)
            {
                MessageBox.Show(errores);
            }
            else
            {
                Usuario usuario = new Usuario();
                int idUsuario = usuario.ObtenerUsuario(usuarioNombre, usuarioPasword, Variables.Globales.nombrePrograma);
                if (idUsuario >= 1) 
                {
                    Variables.Globales.idUsuario = idUsuario;
                    Menu ap = new Menu();
                    ap.Show();
                } 
                else 
                {
                    MessageBox.Show(errores);
                }               
            }



            /*if (!string.IsNullOrEmpty(txtMombreUsu.Text))
            {
                
                if (!string.IsNullOrEmpty(txtPassUsuario.Text))
                {
                    //codigo ingresar usuario
                    DTUsuario usu = new DTUsuario(txtMombreUsu.Text, txtPassUsuario.Text);

                    DTUsuario usuObtenido = UG.ObtenerUsuario(usu);

                    if (usuObtenido is null)
                    {
                        MessageBox.Show("Usuario no registrado, Verifique credenciales");
                    }
                    else
                    {
                        //Oculto la pantalla de login
                        this.Hide();

                        //Llamo al otro Form que quiero ver despues de login
                        Menu ap = new Menu();
                        ap.Show();
                    }
                }
                else 
                {
                    MessageBox.Show("Contraseña no puede ser nula");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nombre de Usuario no puede ser nulo");
            }*/
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            /*
            if (!string.IsNullOrEmpty(txtMombreUsu.Text))
            {
                if (!string.IsNullOrEmpty(txtPassUsuario.Text))
                {
                    //codigo registrar usuario
                    DTUsuario usu = new DTUsuario(txtMombreUsu.Text, txtPassUsuario.Text);
                    Int32 idUsuRegistrado = UG.RegsitrarUsuario(usu);
                    if(idUsuRegistrado > 0)
                    {
                        MessageBox.Show("Usuario Registrado: " + idUsuRegistrado.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar registrar el usuario");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Contraseña no puede ser nula");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nombre de Usuario no puede ser nulo");
            }*/
        }
    }
}
