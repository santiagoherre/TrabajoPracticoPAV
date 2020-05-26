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
    public partial class Carpas : Form
    {
        public Carpas()
        {
            InitializeComponent();
        }

        private void Carpas_Load(object sender, EventArgs e)
        {
            cargarComboTipoCarpa();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            cargarGrilla();
            limpiarCampos();
        }

        private void cargarComboTipoCarpa()
        {
            try
            {
                cmbTipoCarpa.DataSource = AD_Carpa.obtenerTiposCarpas();
                cmbTipoCarpa.DisplayMember = "nombre";
                cmbTipoCarpa.ValueMember = "id";
                cmbTipoCarpa.SelectedIndex = -1;

            }
            catch (Exception) { MessageBox.Show("Error al cargar los tipos de carpas"); }
        }

        private void limpiarCampos()
        {
            txtCaños.Text = "";
            txtDormitorios.Text = "";
        }

        private Carpa obtenerDatosCarpa()
        {
            Carpa carpa = new Carpa();
            
            carpa.IdTipoCarpa = (int)cmbTipoCarpa.SelectedValue;
            carpa.CantCaños = Int32.Parse(txtCaños.Text);
            carpa.CantDormitorios = Int32.Parse(txtDormitorios.Text);
            return carpa;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Carpa carpa = obtenerDatosCarpa();
            bool resultado = AD_Carpa.persistenciaCarpas(carpa);
            if (resultado)
            {
                MessageBox.Show("Carpa agregada con éxito");
                limpiarCampos();
                cargarComboTipoCarpa();
                cargarGrilla();
            }

            else
            {
                MessageBox.Show("Error al guardar la carpa");
            }
            lblid.Visible = false;
            txtId.Visible = false;
        }

        private void cargarGrilla()
        {
            try
            {
                grdCarpas.DataSource = AD_Carpa.obtenerListadoCarpas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener carpas para cargar grillas");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Carpa c = obtenerDatosCarpa();
            c.Id = Int32.Parse(txtId.Text);
            bool resultado = AD_Carpa.modificarCarpa(c);
            if (resultado)
            {
                MessageBox.Show("Carpa modificada con exito");
                limpiarCampos();
                cargarGrilla();
                
            }
            else
            {
                MessageBox.Show("Error al modificar la carpa");
            }
            limpiarCampos();
            lblid.Visible = false;
            txtId.Visible = false;
        }

        private void grdCarpas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdCarpas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Visible = true;
            txtId.Visible = true;
            int index = e.RowIndex;
            if (index < 0)
            {

            }
            else
            {
                DataGridViewRow selectedRow = grdCarpas.Rows[index];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                Carpa carpa = AD_Carpa.buscarCarpa(id);
                txtCaños.Text = carpa.CantCaños.ToString();
                txtDormitorios.Text = carpa.CantDormitorios.ToString();
                cmbTipoCarpa.SelectedValue = carpa.IdTipoCarpa;
                txtId.Text = carpa.Id.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar esta carpa? Esta acción no tiene vuelta atras", "Confrmación", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Carpa carpa = new Carpa();
                carpa.Id = int.Parse(txtId.Text);
                carpa.IdTipoCarpa = (int)cmbTipoCarpa.SelectedValue;
                carpa.CantCaños = Int32.Parse(txtCaños.Text);
                carpa.CantDormitorios = Int32.Parse(txtDormitorios.Text);
                bool resultado = AD_Carpa.eliminarCarpa(carpa);
                cargarGrilla();
            }

            limpiarCampos();
            lblid.Visible = false;
            txtId.Visible = false;
        }
    }
}
