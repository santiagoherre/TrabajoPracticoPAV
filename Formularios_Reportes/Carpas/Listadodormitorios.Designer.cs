namespace Juventus.Formularios_Reportes.Carpas
{
    partial class Listadodormitorios
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
            this.rpvDormitorios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvDormitorios
            // 
            this.rpvDormitorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvDormitorios.LocalReport.ReportEmbeddedResource = "Juventus.Informes.Carpas.ListadoDormitorios.rdlc";
            this.rpvDormitorios.Location = new System.Drawing.Point(0, 0);
            this.rpvDormitorios.Name = "rpvDormitorios";
            this.rpvDormitorios.ServerReport.BearerToken = null;
            this.rpvDormitorios.Size = new System.Drawing.Size(800, 450);
            this.rpvDormitorios.TabIndex = 0;
            this.rpvDormitorios.Load += new System.EventHandler(this.rpvDormitorios_Load);
            // 
            // Listadodormitorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvDormitorios);
            this.Name = "Listadodormitorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de dormitorios";
            this.Load += new System.EventHandler(this.Listadodormitorios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDormitorios;
    }
}