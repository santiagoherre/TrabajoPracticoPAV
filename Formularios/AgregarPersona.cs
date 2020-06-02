
using Juventus.Varios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.Personas
{
    public partial class AgregarPersona : Form
    {
        public AgregarPersona()
        {
            InitializeComponent();
        }

        private void AgregarPersona_Load(object sender, EventArgs e)
        {
            LimpiarCampos();


            btnModificarPersona.Enabled = false;
            btnEliminarPersona.Enabled = false;
            CargarComboTiposDocumentos();
            CargarComboAñoEscolar();
            CargarComboIdGrupo();
            CargarGrilla();

        }



        private void CargarGrilla()
        {
            try
            {
                gdrPersonas.DataSource = Personas_AD.ObtenerListadoPersonasReducido();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener personas");
            }

        }

        private void CargarComboTiposDocumentos()
        {
            try
            {
                cmbIdDocumento.DataSource = Personas_AD.ObtenerTiposDeDocumentos();
                cmbIdDocumento.DisplayMember = "nombre";
                cmbIdDocumento.ValueMember = "id";
                cmbIdDocumento.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipo de documentos");
            }

        }

        private void CargarComboAñoEscolar()
        {
            try
            {
                cmbAñoEscolar.DataSource = Personas_AD.ObtenerAñosEscolares();
                cmbAñoEscolar.DisplayMember = "nombre";
                cmbAñoEscolar.ValueMember = "id";
                cmbAñoEscolar.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo años escolares");
            }

        }

        private void CargarComboIdGrupo()
        {
            try
            {
                cmbIdGrupo.DataSource = Personas_AD.ObtenerGrupos();
                cmbIdGrupo.DisplayMember = "nombre";
                cmbIdGrupo.ValueMember = "id";
                cmbIdGrupo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo Grupos");
            }

        }




        private Persona ObtenerDatosPersona()
        {
            Persona p = new Persona();
            p.Nombre = txtNombrePersona.Text.Trim();
            p.Apellido = txtApellidoPersona.Text.Trim();
            p.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);

            if (rdHombre.Checked)
            {
                p.IdSexo = 1;
            }
            else if (rdMujer.Checked)
            {
                p.IdSexo = 2;
            }
            else
            {
                p.IdSexo = 3;
            }

            p.IdDocumento = (int)cmbIdDocumento.SelectedValue;
            p.Documento = int.Parse(txtDocumento.Text.Trim());
            p.Direccion = txtDireccion.Text;
            p.Telefono = txtTelefono.Text.Trim();
            p.InstitucionAcademica = txtInstitucion.Text;
            p.CorreoElectronico = txtCorreoElectronico.Text.Trim();
            p.AñoEscolar = (int)cmbAñoEscolar.SelectedValue;
            p.IdGrupo = (int)cmbIdGrupo.SelectedValue;

            return p;
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            Persona p = ObtenerDatosPersona();
            bool resultado = Personas_AD.AgregarPersonaABD(p);
            if (resultado)
            {
                MessageBox.Show("Persona agregada con éxito");
                LimpiarCampos();
                CargarComboAñoEscolar();
                CargarComboTiposDocumentos();
                CargarComboIdGrupo();
                
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar la persona");
            }

        }



       /* private void AgregarPersonaAGrilla(Persona per)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaDocumento = new DataGridViewTextBoxCell();
            celdaDocumento.Value = per.Documento;
            fila.Cells.Add(celdaDocumento);

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = per.Nombre;
            fila.Cells.Add(celdaNombre);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = per.Apellido;
            fila.Cells.Add(celdaApellido);

            gdrPersonas.Rows.Add(fila);
            MessageBox.Show("Persona agregada con éxito");
            LimpiarCampos();
            txtNombrePersona.Focus();


        } */

      

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombrePersona.Text = "";
            txtApellidoPersona.Text = "";
            txtFechaNacimiento.Text = "";
            txtDocumento.Text = "";
            rdHombre.Checked = true;
            txtCorreoElectronico.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtInstitucion.Text = "";
            
        }

        /*private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < gdrPersonas.Rows.Count; i++)
            {
                if (gdrPersonas.Rows[i].Cells["dni"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }
        */
        private void gdrPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrPersonas.Rows[index];
            MessageBox.Show(filaSeleccionada.Cells["dni"].Value.ToString());
        }

        private void gdrPersonas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnModificarPersona.Enabled = true;
            btnAgregarPersona.Enabled = false;
            btnEliminarPersona.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrPersonas.Rows[indice];
            string documento = filaSeleccionada.Cells["dni"].Value.ToString();
            Persona p = Personas_AD.ObtenerPersona(documento);
            LimpiarCampos();
            CargarCampos(p);

        }

        private void CargarCampos(Persona p)
        {
            txtNombrePersona.Text = p.Nombre;
            txtApellidoPersona.Text = p.Apellido;
            DateTime fecha = p.FechaNacimiento;
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();
            txtFechaNacimiento.Text = dia + mes + año;
            
          
            if (p.IdSexo == 1)
            {
                rdHombre.Checked = true;
            }
            else if (p.IdSexo == 2)
            {
                rdMujer.Checked = true;
            }
            else
            {
                rdOtro.Checked = true;
            }

            cmbIdDocumento.SelectedValue = p.IdDocumento;

           txtDocumento.Text = p.Documento.ToString();
            txtDireccion.Text = p.Direccion;
            txtTelefono.Text = p.Telefono;
            txtCorreoElectronico.Text = p.CorreoElectronico;
            txtInstitucion.Text = p.InstitucionAcademica;

            cmbAñoEscolar.SelectedValue = p.AñoEscolar;
            cmbIdGrupo.SelectedValue = p.IdGrupo;
        }

      

        private void btnModificarPersona_Click(object sender, EventArgs e)
        {
            Persona p = ObtenerDatosPersona();
            bool resultado = Personas_AD.ActualizarPersona(p);
            if (resultado)
            {
                MessageBox.Show("Persona actualizada con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboAñoEscolar();
                CargarComboIdGrupo();
                CargarComboTiposDocumentos();
            }
            else
            {
                MessageBox.Show("Error al actualizar persona");
            }
            btnAgregarPersona.Enabled = true;
            btnModificarPersona.Enabled = false;
            btnEliminarPersona.Enabled = false;
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            Persona p = ObtenerDatosPersona();
            bool resultado = Personas_AD.EliminarPersona(p);
            if (resultado)
            {
                MessageBox.Show("Persona Eliminada con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboAñoEscolar();
                CargarComboIdGrupo();
                CargarComboTiposDocumentos();
            }
            else
            {
                MessageBox.Show("Error al eliminar persona");
            }

            btnAgregarPersona.Enabled = true;
            btnModificarPersona.Enabled = false;
            btnEliminarPersona.Enabled = false;

        }
    }
}
