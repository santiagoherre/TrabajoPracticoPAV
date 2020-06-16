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

namespace Juventus
{
    public partial class ReporteVehiculos1 : Form
    {
        public ReporteVehiculos1()
        {
            InitializeComponent();
        }

        private void ReporteVehiculos1_Load(object sender, EventArgs e)
        {

            this.rvVehiculo2.RefreshReport();
        }

        private void rvVehiculo2_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Vehiculo.ObtenerActividadesXvehiculos();

            ReportDataSource ds = new ReportDataSource("Vehiculos1DS", tabla);

            rvVehiculo2.LocalReport.DataSources.Clear();
            rvVehiculo2.LocalReport.DataSources.Add(ds);
            rvVehiculo2.LocalReport.Refresh();
        }
    }
}
