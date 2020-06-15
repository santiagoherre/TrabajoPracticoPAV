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
    public partial class CantidadDormitorios : Form
    {
        public CantidadDormitorios()
        {
            InitializeComponent();
        }

        private void CantidadDormitorios_Load(object sender, EventArgs e)
        {

            this.rpvCantDormitorios.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = AD_Carpa.obtenerDormitoriosPorTipo();
            ReportDataSource ds = new ReportDataSource("DormitoriosXTipo", table);
            rpvCantDormitorios.LocalReport.DataSources.Clear();
            rpvCantDormitorios.LocalReport.DataSources.Add(ds);
            rpvCantDormitorios.LocalReport.Refresh();
        }
    }
}
