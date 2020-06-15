namespace Juventus.Formularios_Reportes
{
    partial class CantidadDormitorios
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
            this.rpvCantDormitorios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvCantDormitorios
            // 
            this.rpvCantDormitorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvCantDormitorios.LocalReport.ReportEmbeddedResource = "Juventus.Informes.EstadisticaCantidadDormitorios.rdlc";
            this.rpvCantDormitorios.Location = new System.Drawing.Point(0, 0);
            this.rpvCantDormitorios.Name = "rpvCantDormitorios";
            this.rpvCantDormitorios.ServerReport.BearerToken = null;
            this.rpvCantDormitorios.Size = new System.Drawing.Size(800, 450);
            this.rpvCantDormitorios.TabIndex = 0;
            this.rpvCantDormitorios.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // CantidadDormitorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvCantDormitorios);
            this.Name = "CantidadDormitorios";
            this.Text = "Cantidad de dormitorios";
            this.Load += new System.EventHandler(this.CantidadDormitorios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvCantDormitorios;
    }
}