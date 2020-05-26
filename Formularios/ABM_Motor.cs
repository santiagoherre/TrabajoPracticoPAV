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
    public partial class ABM_Motor : Form
    {
        public ABM_Motor()
        {
            InitializeComponent();
        }

        private void ModificarMotor_Load(object sender, EventArgs e)
        {
          
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            LimpiarCampos();
            CargarGrilla();
            CargarTiposMotor();
          
        

           
        }

        private void CargarGrilla()
        {
            try
            {
                dgMotores.DataSource = AD_Motor.ObtenerTabla("Motores");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar la grilla");;
            }
            
        }
        private Motor ObtenerDatos()
        { 
            Motor mot = new Motor();
            try
            {               
                mot.FabricanteMotor = txtFabricante.Text.Trim();
                mot.ModeloMotor = txtModelo.Text.Trim();
                mot.IdtipoDeMotor = (int)cmbTipoMotor.SelectedValue;           
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener datos de los motores");
            }
                return mot;
        }


        private void CargarCampos(Motor mot)
        {
            txtFabricante.Text = mot.FabricanteMotor;
            txtModelo.Text = mot.ModeloMotor;
            cmbTipoMotor.SelectedValue = mot.IdtipoDeMotor;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Motor mot = ObtenerDatos();
                bool resultado = AD_Motor.ActualizarMotor(mot);
                if (resultado)
                {
                    MessageBox.Show("Motor actualizada con exito!");
                    CargarGrilla();
                    CargarTiposMotor();
                    LimpiarCampos();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar el motor");;
            }
            
        }
        private void LimpiarCampos()
        {
            txtModelo.Text = "";
            txtFabricante.Text = "";
            cmbTipoMotor.Text = "";
        }
        private void CargarTiposMotor()
        {
            try
            {
                cmbTipoMotor.DataSource = AD_Motor.ObtenerTabla("TiposMotores");
                cmbTipoMotor.DisplayMember = "nombre";
                cmbTipoMotor.ValueMember = "id";
                cmbTipoMotor.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgMotores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            int index = e.RowIndex;
            if (index < 0) { }
            else
            {
                DataGridViewRow selectedRow = dgMotores.Rows[index];
                string id = selectedRow.Cells[0].Value.ToString();
                lblid.Text = id;
                Motor motor = AD_Motor.ObtenerMotor(id);
                txtFabricante.Text = motor.FabricanteMotor;
                txtModelo.Text = motor.ModeloMotor;

                LimpiarCampos();
                CargarCampos(motor);
            }                     
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                Motor mot = ObtenerDatos();
                try
                {
                    bool resultado = AD_Motor.BajaMotor(mot);
                    if (resultado)
                    {
                        MessageBox.Show("El motor fue eliminado con exito.");
                        LimpiarCampos();
                        CargarTiposMotor();
                        CargarGrilla();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar el motor seleccionado");
                }
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Motor mot = ObtenerDatos();
            try
            {
                bool resultado = AD_Motor.AgregarMotor(mot);
                if (resultado)
                {
                    MessageBox.Show("El motor fue agregado con exito");
                    LimpiarCampos();
                    CargarTiposMotor();
                    CargarGrilla();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el motor");
            }  
           
        }
    }
}
