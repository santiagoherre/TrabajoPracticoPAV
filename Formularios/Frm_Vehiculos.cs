using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.Vehiculo
{
    public partial class Frm_Vehiculos : Form
    {
        public Frm_Vehiculos()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Vehiculo auto = new Vehiculo();
            if (txtPatente.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Patente");
            }
            else
            {
                auto.Patente = txtPatente.Text;
            }
            if (txtKilometraje.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Kilometraje, aunque sea 0");
            }
            else
            {
                auto.Kilometraje = int.Parse(txtKilometraje.Text);

            }
            if (txtFechaDeCompra.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la fecha de comopra");
            }
            else
            {
                auto.FechaDeCompra = txtFechaDeCompra.Text;
            }
            bool res = false;
            try
            {
                res = AD_Vehiculo.AgregarVehiculoABD(auto);
                if (res)
                {
                    MessageBox.Show("Agregado con exito");

                    grillaVehiculos.DataSource = AD_Vehiculo.ObtenerElementos();
                    limpiarCampos();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el vehículo");
            }


        }

        private void cargarTabla()
        {
            grillaVehiculos.DataSource = AD_Vehiculo.ObtenerElementos();
        }

        private void Frm_Vehiculos_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            DataTable tablaVehiculo = new DataTable();
            try
            {

                tablaVehiculo = AD_Vehiculo.ObtenerElementos();
                grillaVehiculos.DataSource = tablaVehiculo;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del tipo: " + ex.Message);
                throw;
            }
        }
        private void limpiarCampos()
        {
            txtPatente.Text = "";
            txtKilometraje.Text = "";
            txtFechaDeCompra.Text = "";

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            bool resultado = AD_Vehiculo.validarExistente(txtPatente.Text);
            if (resultado)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea modificar este vehículo? Esta acción no tiene vuelta atras", "Confrmación", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.Patente = txtPatente.Text;
                    vehiculo.Kilometraje = int.Parse(txtKilometraje.Text);
                    vehiculo.FechaDeCompra = txtFechaDeCompra.Text;
                    bool res = AD_Vehiculo.modificarVehiculo(vehiculo);

                    if (res)
                    {
                        MessageBox.Show("Se ha insertado con éxito");
                    }
                    cargarTabla();
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar el vehiculo");
            }
            txtPatente.Enabled = true;
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar este vehiculo? Esta acción no tiene vuelta atras", "Confrmación", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Patente = txtPatente.Text;
                vehiculo.Kilometraje = int.Parse(txtKilometraje.Text);
                vehiculo.FechaDeCompra = txtFechaDeCompra.Text;
                bool res = AD_Vehiculo.eliminarVehiculo(vehiculo);
                cargarTabla();
                limpiarCampos();
            }


        }

        private void GrillaVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPatente.Enabled = false;
            int index = e.RowIndex;
            if (index < 0) { }
            else
            {
                DataGridViewRow selectedRow = grillaVehiculos.Rows[index];
                string patente = selectedRow.Cells[0].Value.ToString();
                Vehiculo vehiculo = AD_Vehiculo.buscarVehiculo(patente);
                txtPatente.Text = vehiculo.Patente;
                txtKilometraje.Text = vehiculo.Kilometraje.ToString();
                DateTime fecha = DateTime.Parse(vehiculo.FechaDeCompra);
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

                txtFechaDeCompra.Text = dia + mes + año;
                              
            }

        }
    }

}

