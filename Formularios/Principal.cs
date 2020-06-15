using Juventus.AcercaDeNosotros;
using Juventus.Actividades;
using Juventus.ElementosCocina;
using Juventus.ElementosElectricos;
using Juventus.Formularios;
using Juventus.Formularios_Reportes;
using Juventus.Formularios_Reportes.Carpas;
using Juventus.Personas;
using Juventus.Usuarios;
using Juventus.Varios;
using Juventus.Vehiculo;
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
    public partial class Principal : Form
    {
        Login login;
        Usuario usu;

        public Principal(Usuario usu, Login log)
        {
            InitializeComponent();

            this.login = log;
            this.usu = usu;
        }

        private void ElementosDeCocinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ElemCocina ventana = new Form_ElemCocina();
            ventana.Show();
        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void equiposDeElectricidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Electricidad form_Elctricidad = new Form_Electricidad();
            form_Elctricidad.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Usuarios ventana = new Form_Usuarios();
            ventana.Show();
        }

        private void MotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Motor ventana = new ABM_Motor();
            ventana.Show();
        }

        private void carpasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carpas ventana = new Carpas();
            ventana.Show();
        }

        private void carpasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Carpas ventana = new Carpas();
            ventana.Show();
        }
        private void vehículosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Vehiculos ventana = new Frm_Vehiculos();
            ventana.Show();
        }

        private void salirClick(object sender, EventArgs e)
        {
            login.Close();
        }

        private void cerrarSesionClick(object sender, EventArgs e)
        {
            login.Show();
            login.LimpiarDatos();
            this.Close();
        }

        private void acercaDeNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaNos form = new AcercaNos();
            form.Show();
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tipos tipos = new Form_Tipos();
            tipos.Show();
        }

        private void ActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Actividad ventana = new Form_Actividad();
            ventana.Show();

        }

        private void agregarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPersona ventana = new AgregarPersona();
            ventana.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscripciones ventana = new Inscripciones();
            ventana.Show();
        }

        private void listarCarpasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoCarpas ventana = new ListadoCarpas();
            ventana.ShowDialog();
        }

        private void estadisticaTiposCarpasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaDormitoriosCarpas ventana = new EstadisticaDormitoriosCarpas();
            ventana.ShowDialog();
        }

        private void estdisticasDormitoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CantidadDormitorios ventana = new CantidadDormitorios();
            ventana.ShowDialog();
        }

        private void listarDormitoriosPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listadodormitorios ventana = new Listadodormitorios();
            ventana.ShowDialog();
        }
    }
}
