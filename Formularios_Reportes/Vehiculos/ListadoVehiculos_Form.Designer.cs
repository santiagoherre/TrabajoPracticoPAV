namespace Juventus.Formularios_Reportes.Vehiculos
{
    partial class ListadoVehiculos_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportviewerListadoVehiculos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportviewerListadoVehiculos
            // 
            this.reportviewerListadoVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportviewerListadoVehiculos.LocalReport.ReportEmbeddedResource = "Juventus.Informes.Vechiculos.ListadoVehiculos.rdlc";
            this.reportviewerListadoVehiculos.Location = new System.Drawing.Point(0, 0);
            this.reportviewerListadoVehiculos.Name = "reportviewerListadoVehiculos";
            this.reportviewerListadoVehiculos.ServerReport.BearerToken = null;
            this.reportviewerListadoVehiculos.Size = new System.Drawing.Size(800, 450);
            this.reportviewerListadoVehiculos.TabIndex = 0;
            this.reportviewerListadoVehiculos.Load += new System.EventHandler(this.reportviewerListadoVehiculos_Load);
            // 
            // ListadoVehiculos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportviewerListadoVehiculos);
            this.Name = "ListadoVehiculos_Form";
            this.Text = "Listado de vehiculos";
            this.Load += new System.EventHandler(this.ListadoVehiculos_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportviewerListadoVehiculos;
    }
}