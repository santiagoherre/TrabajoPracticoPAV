using Juventus.Actividades;
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

namespace Juventus.Formularios_Reportes.Actividades
{
    public partial class FormListadoActividades : Form
    {
        private int tipo = 0;
        public FormListadoActividades()
        {
            InitializeComponent();
        }

        private void FormListadoActividades_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Actividad.obtenerActividadesPorTipo();

            ReportDataSource ds = new ReportDataSource("ListadoXTipoAct", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
