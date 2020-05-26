using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.ElementosElectricos
{
    public partial class Form_Electricidad : Form
    {
        public Form_Electricidad()
        {
            InitializeComponent();
        }
        private void Form_Electricidad_Load(object sender, EventArgs e)
        {
            CargarTipoElemento();
            CargarTablaElementos();
        }

        private void CargarTablaElementos()
        {
            try
            {
                dataElectricidad.DataSource = AD_Electricidad.ObtenerElementos();
            }
            catch (Exception )
            {
                MessageBox.Show("Error al insertar valor");
            }
        }

        private void CargarTipoElemento()
        {
            try
            {
                cmbTipo.DataSource = AD_Electricidad.ObtenerTipos();
                cmbTipo.DisplayMember = "nombre";
                cmbTipo.ValueMember = "id";
                cmbTipo.SelectedIndex = -1;
            }
            catch (Exception )
            {
                MessageBox.Show("Error al cargar tipos de elementos de electricidad");
            }
        }

        private void btnGuardarElemento_Click(object sender, EventArgs e)
        {
            try
            {
                ElementoElectrico ee = ObtenerDatosElemento();
                AD_Electricidad.AgregarElementoElectrico(ee);
                CargarTablaElementos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar elemento");
            }
        }

        private ElementoElectrico ObtenerDatosElemento()
        {
            try
            {
                ElementoElectrico ee = new ElementoElectrico();
                ee.Nombre = txtNombre.Text;
                ee.Tipo = (int)cmbTipo.SelectedValue;
                return ee;
            }
            catch (Exception )
            {
                MessageBox.Show("Error al obtener datos");
                throw;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ElementoElectrico ee = ObtenerDatosElemento();
                ee.Id = Int32.Parse(lblId.Text);
                AD_Electricidad.ActualizarElementoElectrico(ee);
                CargarTablaElementos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos");
            }
        }

        private void clickCelda(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index < 0) { }
                else
                {
                    DataGridViewRow selectedRow = dataElectricidad.Rows[index];
                    string id = selectedRow.Cells[0].Value.ToString();
                    lblId.Text = id;
                    ElementoElectrico ee = AD_Electricidad.buscarElemElectrico(id);
                    txtNombre.Text = ee.Nombre;
                    cmbTipo.SelectedValue = ee.Tipo;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar elemento");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ElementoElectrico ee = ObtenerDatosElemento();
                ee.Id = Int32.Parse(lblId.Text);
                AD_Electricidad.EliminarElementoElectrico(ee);
                CargarTablaElementos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar registro");
            }
        }
    }
}
