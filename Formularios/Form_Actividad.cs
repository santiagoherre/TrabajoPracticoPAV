using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.Actividades
{
    public partial class Form_Actividad : Form
    {
        public Form_Actividad()
        {
            InitializeComponent();
            cargarTabla();
            cargarCombos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lblId.Text);

                bool resultado = AD_Actividad.validarExistente(id);
                if (resultado)
                {
                    DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea modificar esta Actividad? Esta acción no tiene vuelta atras", "Confrmación", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        Actividad act = new Actividad();
                        act.Id = int.Parse(lblId.Text);
                        act.Descripcion = txtDescripcion.Text;
                        act.FechaInicio = DateTime.Parse(txtInicio.Text);
                        act.FechaFin = DateTime.Parse(txtFin.Text);
                        act.IdTipoActividad = int.Parse(cmbTipoActividad.SelectedValue.ToString());
                        act.IdArea = int.Parse(cmbArea.SelectedValue.ToString());
                        act.Patente = cmbPatentes.SelectedValue.ToString();
                        act.IdGrupo = int.Parse(cmbGrupo.SelectedValue.ToString());
                        bool res = AD_Actividad.modificarElemento(act);
                        if (res)
                        {
                            MessageBox.Show("Se ha modificado con éxito");
                        }
                        cargarTabla();
                        limpiarCampos();
                        lblId.Text = "-1";
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentra la actividad deseada");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void limpiarCampos()
        {
            txtDescripcion.Text = "";
            txtInicio.Text = "";
            txtFin.Text = "";
            cmbTipoActividad.SelectedIndex = -1;
            cmbArea.SelectedIndex = -1;
            cmbPatentes.SelectedIndex = -1;
            cmbGrupo.SelectedIndex = -1;
        }


        private void cargarTabla()
        {
            grillaActividades.DataSource = AD_Actividad.ObtenerActividades();
        }

        private void cargarCombos()
        {
            cmbArea.DataSource = AD_Actividad.ObtenerCombo("Areas");
            cmbArea.DisplayMember = "descripcion";
            cmbArea.ValueMember = "id";
            cmbArea.SelectedIndex = -1;

            cmbGrupo.DataSource = AD_Actividad.ObtenerCombo("Grupos");
            cmbGrupo.DisplayMember = "nombre";
            cmbGrupo.ValueMember = "id";
            cmbGrupo.SelectedIndex = -1;

            cmbTipoActividad.DataSource = AD_Actividad.ObtenerCombo("TiposActividades");
            cmbTipoActividad.DisplayMember = "nombre";
            cmbTipoActividad.ValueMember = "id";
            cmbTipoActividad.SelectedIndex = -1;

            cmbPatentes.DataSource = AD_Actividad.ObtenerCombo("Vehiculos");
            cmbPatentes.DisplayMember = "patente";
            cmbPatentes.ValueMember = "patente";
            cmbPatentes.SelectedIndex = -1;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = txtDescripcion.Text;
                DateTime fechaInicio = DateTime.Parse(txtInicio.Text);
                DateTime fechaFin = DateTime.Parse(txtFin.Text);
                int idTipoActividad = int.Parse(cmbTipoActividad.SelectedValue.ToString());
                int idArea = int.Parse(cmbArea.SelectedValue.ToString());
                string patente = cmbPatentes.SelectedValue.ToString();
                int idGrupo = int.Parse(cmbGrupo.SelectedValue.ToString());

                Actividad act = new Actividad(descripcion, fechaInicio, fechaFin, idTipoActividad, idArea, patente, idGrupo);
                bool res = AD_Actividad.insertarActividad(act);
                if (res)
                {
                    MessageBox.Show("Se ha insertado con éxito");
                }

                cargarTabla();
                limpiarCampos();
                lblId.Text = "-1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la insercion" + ex.Message);
            }
        }

        private void GrillaActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {

            }
            else
            {
                DataGridViewRow selectedRow = grillaActividades.Rows[index];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                Actividad act = AD_Actividad.buscarActividad(id);
                txtDescripcion.Text = act.Descripcion;
                DateTime fecha = act.FechaInicio;
                string dia = fecha.Day.ToString();
                string mes = fecha.Month.ToString();
                string año = fecha.Year.ToString();

                if (dia.Length == 1)
                {
                    dia = "0" + dia;
                }
                if (mes.Length == 1)
                {
                    mes = "0" + mes;
                }
                txtInicio.Text = dia +"/"+ mes + "/" + año;
                DateTime fechaFin = act.FechaFin;
                string diaFin = fechaFin.Day.ToString();
                string mesFin = fechaFin.Month.ToString();
                string añoFin = fechaFin.Year.ToString();

                if (diaFin.Length == 1)
                {
                    diaFin = "0" + diaFin;
                }
                if (mesFin.Length == 1)
                {
                    mesFin = "0" + mesFin;
                }
                txtFin.Text = diaFin + "/" + mesFin + "/" + añoFin;

                cmbTipoActividad.SelectedValue = act.IdTipoActividad;
                cmbArea.SelectedValue = act.IdArea.ToString();
                cmbGrupo.SelectedValue = act.IdGrupo.ToString();
                cmbPatentes.SelectedValue = act.Patente;
                lblId.Text = act.Id.ToString();
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar esta actividad? Esta acción no tiene vuelta atras", "Confrmación", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Actividad act = new Actividad();
                act.Id = int.Parse(lblId.Text);
                act.Descripcion = txtDescripcion.Text;
                act.FechaInicio = DateTime.Parse(txtInicio.Text);
                act.FechaFin = DateTime.Parse(txtFin.Text);
                act.FechaFin = DateTime.Parse(txtFin.Text);
                act.FechaFin = DateTime.Parse(txtFin.Text);
                act.IdTipoActividad = int.Parse(cmbTipoActividad.SelectedValue.ToString());
                act.IdArea = int.Parse(cmbArea.SelectedValue.ToString());
                act.Patente = cmbPatentes.SelectedValue.ToString();
                act.IdGrupo = int.Parse(cmbGrupo.SelectedValue.ToString());
                bool res = AD_Actividad.eliminarActividad(act);
                if (res)
                {
                    MessageBox.Show("Se eliminó con éxito");
                }
                cargarTabla();
                limpiarCampos();
                lblId.Text = "-1";
            }
        }
    }
}
