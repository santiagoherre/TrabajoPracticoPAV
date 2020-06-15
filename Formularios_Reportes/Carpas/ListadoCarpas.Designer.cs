namespace Juventus.Formularios
{
    partial class ListadoCarpas
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
            this.rpvListadoCarpas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvListadoCarpas
            // 
            this.rpvListadoCarpas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvListadoCarpas.LocalReport.ReportEmbeddedResource = "Juventus.Informes.ListadoCarpas.rdlc";
            this.rpvListadoCarpas.Location = new System.Drawing.Point(0, 0);
            this.rpvListadoCarpas.Name = "rpvListadoCarpas";
            this.rpvListadoCarpas.ServerReport.BearerToken = null;
            this.rpvListadoCarpas.Size = new System.Drawing.Size(685, 343);
            this.rpvListadoCarpas.TabIndex = 0;
            this.rpvListadoCarpas.Load += new System.EventHandler(this.rpvListadoCarpas_Load);
            // 
            // ListadoCarpas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 343);
            this.Controls.Add(this.rpvListadoCarpas);
            this.Name = "ListadoCarpas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de carpas";
            this.Load += new System.EventHandler(this.ListadoCarpas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvListadoCarpas;
    }
}