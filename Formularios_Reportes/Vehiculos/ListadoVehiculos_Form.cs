using Juventus.Vehiculo;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.Formularios_Reportes.Vehiculos
{
    public partial class ListadoVehiculos_Form : Form
    {
        public ListadoVehiculos_Form()
        {
            InitializeComponent();
        }

        private void ListadoVehiculos_Form_Load(object sender, EventArgs e)
        {

            this.reportviewerListadoVehiculos.RefreshReport();
        }

        private void reportviewerListadoVehiculos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Vehiculo.ObtenerElementos();

            ReportDataSource ds = new ReportDataSource("VehiculosDS", tabla);

            reportviewerListadoVehiculos.LocalReport.DataSources.Clear();
            reportviewerListadoVehiculos.LocalReport.DataSources.Add(ds);
            reportviewerListadoVehiculos.LocalReport.Refresh();
        }
    }
}
