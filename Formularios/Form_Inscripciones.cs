using Juventus.Actividades;
using Juventus.DAO;
using Juventus.Negocio;
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
            int id = (int)cmbTipoActividad.SelectedValue;
            txtIdActividad.Text = id.ToString();
            try
            {                
                grdActividades.DataSource = AD_Actividad.obtenerActividadesPorTipo(id);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar las actividades...");
            }
        }

        private void grdActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) { }
            else
            {
                DataGridViewRow selectedRow = grdActividades.Rows[index];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                txtIdActividadElegida.Text = id.ToString();
            }
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {          
            Inscripcion insc = new Inscripcion();
            insc.Fecha = DateTime.Now;
            insc.Dni = int.Parse(txtNroDoc.Text);
            insc.IdTipoDocumento = (int)cmbTipoDocumento.SelectedValue;
            insc.IdTipoActividad = int.Parse(txtIdActividadElegida.Text);

            try
            {
                bool existe = AD_Inscripciones.validarExistencia(insc);
                if (existe)
                {
                    try
                    {
                        bool resultado = AD_Inscripciones.insertarInscripcion(insc);
                        if (resultado)
                        {
                            MessageBox.Show("Inscripcion realizada con exito");
                            limpiarCampos();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al inscribirse");
                    }
                }
                else
                {
                    MessageBox.Show("Ya se encuentra inscripto para esta actividad");
                }
            }
            catch (Exception) 
            { 
                MessageBox.Show("Error al inscribirse");
            }           
        }

        private void limpiarCampos()
        {
            cmbTipoDocumento.SelectedIndex = -1;
            cmbTipoActividad.SelectedIndex = -1;
            txtApellidoPersona.Text = "";
            txtNombrePersona.Text = "";
            txtNroDoc.Text = "";
            txtIdActividadElegida.Text = "";
            txtIdActividad.Text = "";
        }
    }
}
