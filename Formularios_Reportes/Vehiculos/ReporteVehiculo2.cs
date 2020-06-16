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
    public partial class ReporteVehiculo2 : Form
    {
        public ReporteVehiculo2()
        {
            InitializeComponent();
        }

        private void ReporteVehiculo2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Vehiculo.ObtenerVehiculosXTipoActividad();

            ReportDataSource ds = new ReportDataSource("Vehiculos2DS", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();

        }
    }
}
