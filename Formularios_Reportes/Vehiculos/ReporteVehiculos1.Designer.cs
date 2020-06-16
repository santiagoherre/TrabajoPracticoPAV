namespace Juventus
{
    partial class ReporteVehiculos1
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
            this.rvVehiculo2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvVehiculo2
            // 
            this.rvVehiculo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvVehiculo2.LocalReport.ReportEmbeddedResource = "Juventus.Informes.Vechiculos.ReporteVehiculo1.rdlc";
            this.rvVehiculo2.Location = new System.Drawing.Point(0, 0);
            this.rvVehiculo2.Name = "rvVehiculo2";
            this.rvVehiculo2.ServerReport.BearerToken = null;
            this.rvVehiculo2.Size = new System.Drawing.Size(800, 450);
            this.rvVehiculo2.TabIndex = 0;
            this.rvVehiculo2.Load += new System.EventHandler(this.rvVehiculo2_Load);
            // 
            // ReporteVehiculos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvVehiculo2);
            this.Name = "ReporteVehiculos1";
            this.Text = "ReporteVehiculos1";
            this.Load += new System.EventHandler(this.ReporteVehiculos1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvVehiculo2;
    }
}