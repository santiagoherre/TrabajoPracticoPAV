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

namespace Juventus.Formularios_Reportes.Carpas
{
    public partial class Listadodormitorios : Form
    {
        public Listadodormitorios()
        {
            InitializeComponent();
        }

        private void Listadodormitorios_Load(object sender, EventArgs e)
        {

            this.rpvDormitorios.RefreshReport();
        }

        private void rpvDormitorios_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = AD_Carpa.obtenerListadiDormitorios();
            ReportDataSource ds = new ReportDataSource("ListadoCarpas", table);
            rpvDormitorios.LocalReport.DataSources.Clear();
            rpvDormitorios.LocalReport.DataSources.Add(ds);
            rpvDormitorios.LocalReport.Refresh();
        }
    }
}
