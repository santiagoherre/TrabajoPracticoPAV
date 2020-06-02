using Juventus.Actividades;
using Juventus.Varios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.Formularios
{
    public partial class Inscripciones : Form
    {
        public Inscripciones()
        {
            InitializeComponent();
        }

        private void Inscripciones_Load(object sender, EventArgs e)
        {
            cargarFecha();
            CargarComboTiposDocumentos();
            cargarComboTipoActividades();
        }

        private void cargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void CargarComboTiposDocumentos()
        {
            try
            {
                cmbTipoDocumento.DataSource = Personas_AD.ObtenerTiposDeDocumentos();
                cmbTipoDocumento.DisplayMember = "nombre";
                cmbTipoDocumento.ValueMember = "id";
                cmbTipoDocumento.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo tipo de documentos");
            }
        }

        private void cargarComboTipoActividades()
        {
            cmbTipoActividad.DataSource = AD_Actividad.ObtenerCombo("TiposActividades");
            cmbTipoActividad.DisplayMember = "nombre";
            cmbTipoActividad.ValueMember = "id";
            cmbTipoActividad.SelectedIndex = -1;
        }

        private void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = Personas_AD.obtenerPersonaPorDocumento(int.Parse(txtNroDoc.Text), (int)cmbTipoDocumento.SelectedValue);
                if (tablaResultado.Rows.Count > 0)
                {
                    txtNombrePersona.Text = tablaResultado.Rows[0][9].ToString();
                    txtApellidoPersona.Text = tablaResultado.Rows[0][10].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Persona no encontrada");
                    txtNroDoc.Focus();
                    txtNombrePersona.Text = "";
                    txtApellidoPersona.Text = "";
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscarActividades_Click(object sender, EventArgs e)
        {
            
        }
    }
}
