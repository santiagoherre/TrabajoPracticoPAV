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

namespace Juventus.Formularios_Reportes
{
    public partial class EstadisticaDormitoriosCarpas : Form
    {
        public EstadisticaDormitoriosCarpas()
        {
            InitializeComponent();
        }

        private void EstadisticaDormitoriosCarpas_Load(object sender, EventArgs e)
        {

            this.rpvCantTiposCarpas.RefreshReport();
        }

        private void rpvCantTiposCarpas_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = AD_Carpa.obtenerEstadisticaTiposCarpas();
            ReportDataSource ds = new ReportDataSource("CantTiposCarpas", table);
            rpvCantTiposCarpas.LocalReport.DataSources.Clear();
            rpvCantTiposCarpas.LocalReport.DataSources.Add(ds);
            rpvCantTiposCarpas.LocalReport.Refresh();
        }
    }
}
