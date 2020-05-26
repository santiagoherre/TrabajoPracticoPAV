namespace Juventus.Vehiculo
{
    partial class Frm_Vehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Vehiculos));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grillaVehiculos = new System.Windows.Forms.DataGridView();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKilometraje = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtKilometraje = new System.Windows.Forms.MaskedTextBox();
            this.lvlFechaDeCompra = new System.Windows.Forms.Label();
            this.txtFechaDeCompra = new System.Windows.Forms.MaskedTextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(182, 249);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 29);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grillaVehiculos
            // 
            this.grillaVehiculos.AllowUserToAddRows = false;
            this.grillaVehiculos.AllowUserToDeleteRows = false;
            this.grillaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patente,
            this.Kilometraje,
            this.fechaDeCompra});
            this.grillaVehiculos.Location = new System.Drawing.Point(285, 55);
            this.grillaVehiculos.Name = "grillaVehiculos";
            this.grillaVehiculos.ReadOnly = true;
            this.grillaVehiculos.Size = new System.Drawing.Size(416, 223);
            this.grillaVehiculos.TabIndex = 21;
            this.grillaVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaVehiculos_CellClick);
            // 
            // Patente
            // 
            this.Patente.DataPropertyName = "patente";
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            // 
            // Kilometraje
            // 
            this.Kilometraje.DataPropertyName = "kilometraje";
            this.Kilometraje.HeaderText = "Kilometraje";
            this.Kilometraje.Name = "Kilometraje";
            this.Kilometraje.ReadOnly = true;
            // 
            // fechaDeCompra
            // 
            this.fechaDeCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaDeCompra.DataPropertyName = "fechaDeCompra";
            this.fechaDeCompra.HeaderText = "Fecha De Compra";
            this.fechaDeCompra.Name = "fechaDeCompra";
            this.fechaDeCompra.ReadOnly = true;
            // 
            // lblKilometraje
            // 
            this.lblKilometraje.AutoSize = true;
            this.lblKilometraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometraje.Location = new System.Drawing.Point(84, 149);
            this.lblKilometraje.Name = "lblKilometraje";
            this.lblKilometraje.Size = new System.Drawing.Size(78, 16);
            this.lblKilometraje.TabIndex = 18;
            this.lblKilometraje.Text = "Kilometraje:";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(108, 109);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(57, 16);
            this.lblPatente.TabIndex = 17;
            this.lblPatente.Text = "Patente:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(81, 55);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(106, 25);
            this.lblVehiculo.TabIndex = 16;
            this.lblVehiculo.Text = "Vehiculos";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(171, 109);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(72, 20);
            this.txtPatente.TabIndex = 23;
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(171, 149);
            this.txtKilometraje.Mask = "9999999";
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(72, 20);
            this.txtKilometraje.TabIndex = 24;
            this.txtKilometraje.ValidatingType = typeof(int);
            // 
            // lvlFechaDeCompra
            // 
            this.lvlFechaDeCompra.AutoSize = true;
            this.lvlFechaDeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlFechaDeCompra.Location = new System.Drawing.Point(45, 180);
            this.lvlFechaDeCompra.Name = "lvlFechaDeCompra";
            this.lvlFechaDeCompra.Size = new System.Drawing.Size(117, 16);
            this.lvlFechaDeCompra.TabIndex = 25;
            this.lvlFechaDeCompra.Text = "Fecha de compra:";
            // 
            // txtFechaDeCompra
            // 
            this.txtFechaDeCompra.Location = new System.Drawing.Point(171, 180);
            this.txtFechaDeCompra.Mask = "00/00/0000";
            this.txtFechaDeCompra.Name = "txtFechaDeCompra";
            this.txtFechaDeCompra.Size = new System.Drawing.Size(72, 20);
            this.txtFechaDeCompra.TabIndex = 26;
            this.txtFechaDeCompra.ValidatingType = typeof(System.DateTime);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(74, 249);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 29);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(613, 288);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 29);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Frm_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 329);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtFechaDeCompra);
            this.Controls.Add(this.lvlFechaDeCompra);
            this.Controls.Add(this.txtKilometraje);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grillaVehiculos);
            this.Controls.Add(this.lblKilometraje);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblVehiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Vehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar vehiculos";
            this.Load += new System.EventHandler(this.Frm_Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView grillaVehiculos;
        private System.Windows.Forms.Label lblKilometraje;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.MaskedTextBox txtKilometraje;
        private System.Windows.Forms.Label lvlFechaDeCompra;
        private System.Windows.Forms.MaskedTextBox txtFechaDeCompra;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeCompra;
    }
}