using Juventus.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.Varios
{
    public partial class Form_Tipos : Form
    {
        private string tabla;

        public Form_Tipos()
        {
            InitializeComponent();
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbTipo.SelectedIndex + 1)
            {
                case 1:
                    tabla = "TiposActividades";
                    break;
                case 2:
                    tabla = "TiposCarpas";
                    break;
                case 3:
                    tabla = "TiposDocumentos";
                    break;
                case 4:
                    tabla = "TiposElemCocina";
                    break;
                case 5:
                    tabla = "TiposElemElectricidad";
                    break;
                case 6:
                    tabla = "TiposMotores";
                    break;
                case 7:
                    tabla = "TiposSangres";
                    break;
            }
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dataTipos.DataSource = AD_Tipos.ObtenerElementos(tabla);
                dataTipos.Columns[0].Width = 40;
                dataTipos.Columns[0].ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos");
            }
        }


        // NO IMPLEMENTADO
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dataTipos.AllowUserToAddRows = true;
        }


        // NO IMPLEMENTADO
        private void dataTipos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dataTipos.SelectedRows[0].Cells[1].Value.ToString();
            if (dataTipos.Columns.Count == 2)
            {
                string descripcion = dataTipos.SelectedRows[0].Cells[2].Value.ToString();
                AD_Tipos.AgregarTipo(nombre, descripcion, tabla);
            }
            AD_Tipos.AgregarTipo(nombre, tabla);
            CargarDatos();
            dataTipos.AllowUserToAddRows = false;
        }
    }
}
