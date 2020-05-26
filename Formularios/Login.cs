using Juventus.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario y password");
            }
            else
            {
                string nombreDeUsuario = txtUser.Text;
                string password = txtPassword.Text;
                bool resultado = false;
                try
                {
                    resultado = AD_Usuarios.ValidarUsuario(nombreDeUsuario, password);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario(nombreDeUsuario, password);
                        Principal ventana = new Principal(usu,this);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar usuario " + ex);
                }

            }
        }

        internal void LimpiarDatos()
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
