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

namespace Juventus.Formularios
{
    public partial class ListadoCarpas : Form
    {
        public ListadoCarpas()
        {
            InitializeComponent();
        }

        private void ListadoCarpas_Load(object sender, EventArgs e)
        {

            this.rpvListadoCarpas.RefreshReport();
        }

        private void rpvListadoCarpas_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = AD_Carpa.listadoCarpas();
            ReportDataSource ds = new ReportDataSource("ListadoCarpas", table);
            rpvListadoCarpas.LocalReport.DataSources.Clear();
            rpvListadoCarpas.LocalReport.DataSources.Add(ds);
            rpvListadoCarpas.LocalReport.Refresh();
        }
    }
}
