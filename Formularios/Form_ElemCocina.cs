using Juventus.DOMINIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.ElementosCocina
{
    public partial class Form_ElemCocina : Form
    {
        public Form_ElemCocina()
        {
            InitializeComponent();
        }

        private void Form_ElemCocina_Load(object sender, EventArgs e)
        {
            cargarCombos();
            cargarTabla();
            txtid.Text = "-1";
        }

        private void cargarCombos()
        {
            cmbTipoElemCocina.DataSource = AD_ElemCocina.ObtenerTipoElemCocina();
            cmbTipoElemCocina.DisplayMember = "nombre";
            cmbTipoElemCocina.ValueMember = "id";
            cmbTipoElemCocina.SelectedIndex = -1;

        }

        private void cargarTabla()
        {
            grillaElemCocina.DataSource = AD_ElemCocina.ObtenerElementosCocina();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                int idTipoElemento = 0;
                Int32.TryParse(cmbTipoElemCocina.SelectedValue.ToString(), out idTipoElemento);
                ElemCocina elem = new ElemCocina(nombre, descripcion, idTipoElemento);
                bool res = AD_ElemCocina.insertarElementosCocina(elem);
                if (res)
                {
                    MessageBox.Show("Se ha insertado con éxito");
                }

                cargarTabla();
                LimpiarCampos();
                txtid.Text = "-1";
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error en la insercion");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);

            bool resultado = AD_ElemCocina.validarExistente(id);
            if (resultado)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea modificar este Elemento de cocina? Esta acción no tiene vuelta atras", "Confrmación",MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    ElemCocina elem = new ElemCocina();
                    elem.Id = int.Parse(txtid.Text);
                    elem.Nombre = txtNombre.Text;
                    elem.Descripcion = txtDescripcion.Text;
                    elem.IdTipoElemento = int.Parse(cmbTipoElemCocina.SelectedValue.ToString());
                    bool res = AD_ElemCocina.modificarElemento(elem);
                    if (res)
                    {
                        MessageBox.Show("Se ha insertado con éxito");
                    }
                    cargarTabla();
                    LimpiarCampos();
                    txtid.Text = "-1";
                }
            }
            else
            {
                MessageBox.Show("El usuario que se desea modificar no se encuentra en la base de datos");
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbActividad.SelectedIndex = -1;
            cmbTipoElemCocina.SelectedIndex = -1;
            txtid.Text= "-1";
            txtNombre.Focus();
        }


        private void CargarCampos(ElemCocina elem)
        {
            txtNombre.Text = elem.Nombre;
            txtDescripcion.Text = elem.Descripcion;
            cmbTipoElemCocina.SelectedValue = elem.IdTipoElemento;
        }


        private void GrillaElemCocina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                
            }
            else
            {
                DataGridViewRow selectedRow = grillaElemCocina.Rows[index];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                ElemCocina elem = AD_ElemCocina.buscarElemCocina(id);
                txtNombre.Text = elem.Nombre;
                txtDescripcion.Text = elem.Descripcion;
                cmbTipoElemCocina.SelectedValue = elem.IdTipoElemento;
                txtid.Text = elem.Id.ToString();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar este Elemento de cocina? Esta acción no tiene vuelta atras", "Confrmación", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                ElemCocina elem = new ElemCocina();
                elem.Id = int.Parse(txtid.Text);
                elem.Nombre = txtNombre.Text;
                elem.Descripcion = txtDescripcion.Text;
                elem.IdTipoElemento = int.Parse(cmbTipoElemCocina.SelectedValue.ToString());
                bool res = AD_ElemCocina.eliminarElemento(elem);
                cargarTabla();
                LimpiarCampos();
                txtid.Text = "-1";
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void grillaElemCocina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
