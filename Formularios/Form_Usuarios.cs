using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.Usuarios
{
    public partial class Form_Usuarios : Form
    {
        public Form_Usuarios()
        {
            InitializeComponent();
            CargarGrilla();
            lblId.Text = "-1";

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnAltaUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreDeUsuario.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario");
            }
            else
            {
                if (txtPassword.Text.Equals(txtRepetirPassword.Text) == true)
                {
                    try
                    {
                        bool resultado = AD_Usuarios.InsertarUsuario(txtNombreDeUsuario.Text, txtPassword.Text);
                        if (resultado)
                        {
                            MessageBox.Show("Usuario dado de alta con éxito");
                            LimpiarCampos();
                            CargarGrilla();
                            txtNombreDeUsuario.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error al insertar nuevo usuario");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al insertar nuevo usuario");
                        txtNombreDeUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Los passwords no coinciden");
                }
            }
        }

        private void CargarGrilla()
        {
            try
            {
                grillaUsuarios.DataSource = AD_Usuarios.ObtenerListadoUsuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de usuarios");
            }

        }

        private void LimpiarCampos()
        {
            txtNombreDeUsuario.Text = "";
            txtPassword.Text = "";
            txtRepetirPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar este Usuario? Esta acción no tiene vuelta atras", "Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Usuario usu = new Usuario();
                usu.NombreDeUsuario = txtNombreDeUsuario.Text;
                usu.Password = txtPassword.Text;

                bool res = AD_Usuarios.EliminarUsuario(usu.NombreDeUsuario , usu.Password);
                CargarGrilla();
                LimpiarCampos();
            }

            CargarGrilla();

        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea modificar este Usuario? Esta acción no tiene vuelta atras", "Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                int id = int.Parse(lblId.Text);
                bool resultado = AD_Usuarios.validarPorId(id);
                if (resultado)
                { 
                    Usuario usu = new Usuario();
                    usu.NombreDeUsuario = txtNombreDeUsuario.Text;
                    usu.Password = txtPassword.Text;
                    usu.Id = id;

                bool res = AD_Usuarios.ModificarUsuario(usu.NombreDeUsuario, usu.Password);
                CargarGrilla();
                LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("El usuario que se desea modificar no se encuentra en la base de datos");
                }
            }
            CargarGrilla();
        }


        private void GrillaUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {

            }
            else
            {
                DataGridViewRow selectedRow = grillaUsuarios.Rows[index];
                int id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                Usuario usu = AD_Usuarios.buscarUsuario(id);
                txtNombreDeUsuario.Text = usu.NombreDeUsuario;
                txtPassword.Text = usu.Password;
                lblId.Text = id.ToString();
                lblId.Visible = true;
            }
        }
    }
}
