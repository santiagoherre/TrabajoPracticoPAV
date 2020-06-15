namespace Juventus.Formularios_Reportes
{
    partial class EstadisticaDormitoriosCarpas
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
            this.rpvCantTiposCarpas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvCantTiposCarpas
            // 
            this.rpvCantTiposCarpas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvCantTiposCarpas.LocalReport.ReportEmbeddedResource = "Juventus.Informes.EstadisticaCantTiposCarpas.rdlc";
            this.rpvCantTiposCarpas.Location = new System.Drawing.Point(0, 0);
            this.rpvCantTiposCarpas.Name = "rpvCantTiposCarpas";
            this.rpvCantTiposCarpas.ServerReport.BearerToken = null;
            this.rpvCantTiposCarpas.Size = new System.Drawing.Size(729, 349);
            this.rpvCantTiposCarpas.TabIndex = 0;
            this.rpvCantTiposCarpas.Load += new System.EventHandler(this.rpvCantTiposCarpas_Load);
            // 
            // EstadisticaDormitoriosCarpas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 349);
            this.Controls.Add(this.rpvCantTiposCarpas);
            this.Name = "EstadisticaDormitoriosCarpas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica de dormitorios por carpas";
            this.Load += new System.EventHandler(this.EstadisticaDormitoriosCarpas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvCantTiposCarpas;
    }
}