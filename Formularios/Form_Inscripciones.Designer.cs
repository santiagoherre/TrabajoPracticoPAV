namespace Juventus.Formularios
{
    partial class Inscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripciones));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdInscripcion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbTipoActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscarActividades = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.txtApellidoPersona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarPersona = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id incripcion:";
            // 
            // txtIdInscripcion
            // 
            this.txtIdInscripcion.Enabled = false;
            this.txtIdInscripcion.Location = new System.Drawing.Point(85, 6);
            this.txtIdInscripcion.Name = "txtIdInscripcion";
            this.txtIdInscripcion.Size = new System.Drawing.Size(32, 20);
            this.txtIdInscripcion.TabIndex = 1;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(58, 37);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(75, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 40);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo documento:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(105, 68);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDocumento.TabIndex = 5;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(15, 105);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(68, 102);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNroDoc.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(495, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 20);
            this.textBox2.TabIndex = 10;
            // 
            // cmbTipoActividad
            // 
            this.cmbTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoActividad.FormattingEnabled = true;
            this.cmbTipoActividad.Location = new System.Drawing.Point(338, 68);
            this.cmbTipoActividad.Name = "cmbTipoActividad";
            this.cmbTipoActividad.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoActividad.TabIndex = 9;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(245, 71);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(89, 13);
            this.lblActividad.TabIndex = 8;
            this.lblActividad.Text = "Tipo de actividad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 193);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actividades disponibles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fechaInicio,
            this.fechaFin,
            this.descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(515, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBuscarActividades
            // 
            this.btnBuscarActividades.Location = new System.Drawing.Point(384, 95);
            this.btnBuscarActividades.Name = "btnBuscarActividades";
            this.btnBuscarActividades.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarActividades.TabIndex = 13;
            this.btnBuscarActividades.Text = "Buscar actividades";
            this.btnBuscarActividades.UseVisualStyleBackColor = true;
            this.btnBuscarActividades.Click += new System.EventHandler(this.btnBuscarActividades_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.Location = new System.Drawing.Point(471, 375);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(75, 23);
            this.btnInscripcion.TabIndex = 14;
            this.btnInscripcion.Text = "Incribir";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            // 
            // txtApellidoPersona
            // 
            this.txtApellidoPersona.Enabled = false;
            this.txtApellidoPersona.Location = new System.Drawing.Point(192, 131);
            this.txtApellidoPersona.Name = "txtApellidoPersona";
            this.txtApellidoPersona.Size = new System.Drawing.Size(70, 20);
            this.txtApellidoPersona.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellido:";
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Enabled = false;
            this.txtNombrePersona.Location = new System.Drawing.Point(68, 131);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(65, 20);
            this.txtNombrePersona.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre:";
            // 
            // btnBuscarPersona
            // 
            this.btnBuscarPersona.Location = new System.Drawing.Point(174, 102);
            this.btnBuscarPersona.Name = "btnBuscarPersona";
            this.btnBuscarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPersona.TabIndex = 19;
            this.btnBuscarPersona.Text = "Buscar actividades";
            this.btnBuscarPersona.UseVisualStyleBackColor = true;
            this.btnBuscarPersona.Click += new System.EventHandler(this.btnBuscarPersona_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.DataPropertyName = "fechaInicio";
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // fechaFin
            // 
            this.fechaFin.DataPropertyName = "fechaFin";
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 405);
            this.Controls.Add(this.btnBuscarPersona);
            this.Controls.Add(this.txtNombrePersona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidoPersona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInscripcion);
            this.Controls.Add(this.btnBuscarActividades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmbTipoActividad);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtIdInscripcion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.Inscripciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdInscripcion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbTipoActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscarActividades;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.TextBox txtApellidoPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}