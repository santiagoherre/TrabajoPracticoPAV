using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.Actividades
{
    public partial class Form_Actividad : Form
    {
        public Form_Actividad()
        {
            InitializeComponent();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void cargarTabla()
        {
            grillaActividades.DataSource = AD_Actividad.ObtenerActividades();

        }
    }
}
