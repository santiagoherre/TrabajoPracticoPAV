namespace Juventus
{
    partial class Carpas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carpas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.cmbTipoCarpa = new System.Windows.Forms.ComboBox();
            this.lblDormitorios = new System.Windows.Forms.Label();
            this.lblCaños = new System.Windows.Forms.Label();
            this.lblTipoCarpa = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtDormitorios = new System.Windows.Forms.MaskedTextBox();
            this.txtCaños = new System.Windows.Forms.MaskedTextBox();
            this.grdCarpas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCarpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantCaños = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantDormitorios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarpas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.cmbTipoCarpa);
            this.groupBox1.Controls.Add(this.lblDormitorios);
            this.groupBox1.Controls.Add(this.lblCaños);
            this.groupBox1.Controls.Add(this.lblTipoCarpa);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Controls.Add(this.txtDormitorios);
            this.groupBox1.Controls.Add(this.txtCaños);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestionar carpas";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(114, 119);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(34, 20);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(22, 122);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(86, 13);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "Id carpa elegida:";
            this.lblid.Visible = false;
            // 
            // cmbTipoCarpa
            // 
            this.cmbTipoCarpa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCarpa.FormattingEnabled = true;
            this.cmbTipoCarpa.Location = new System.Drawing.Point(104, 22);
            this.cmbTipoCarpa.Name = "cmbTipoCarpa";
            this.cmbTipoCarpa.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCarpa.TabIndex = 7;
            // 
            // lblDormitorios
            // 
            this.lblDormitorios.AutoSize = true;
            this.lblDormitorios.Location = new System.Drawing.Point(22, 94);
            this.lblDormitorios.Name = "lblDormitorios";
            this.lblDormitorios.Size = new System.Drawing.Size(120, 13);
            this.lblDormitorios.TabIndex = 6;
            this.lblDormitorios.Text = "Cantidad de dormitorios:";
            // 
            // lblCaños
            // 
            this.lblCaños.AutoSize = true;
            this.lblCaños.Location = new System.Drawing.Point(22, 61);
            this.lblCaños.Name = "lblCaños";
            this.lblCaños.Size = new System.Drawing.Size(99, 13);
            this.lblCaños.TabIndex = 5;
            this.lblCaños.Text = "Cantidad de caños:";
            // 
            // lblTipoCarpa
            // 
            this.lblTipoCarpa.AutoSize = true;
            this.lblTipoCarpa.Location = new System.Drawing.Point(22, 25);
            this.lblTipoCarpa.Name = "lblTipoCarpa";
            this.lblTipoCarpa.Size = new System.Drawing.Size(76, 13);
            this.lblTipoCarpa.TabIndex = 4;
            this.lblTipoCarpa.Text = "Tipo de carpa:";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(92, 158);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver carpas";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(173, 158);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtDormitorios
            // 
            this.txtDormitorios.Location = new System.Drawing.Point(148, 91);
            this.txtDormitorios.Mask = "999";
            this.txtDormitorios.Name = "txtDormitorios";
            this.txtDormitorios.Size = new System.Drawing.Size(27, 20);
            this.txtDormitorios.TabIndex = 1;
            this.txtDormitorios.ValidatingType = typeof(int);
            // 
            // txtCaños
            // 
            this.txtCaños.Location = new System.Drawing.Point(127, 58);
            this.txtCaños.Mask = "99";
            this.txtCaños.Name = "txtCaños";
            this.txtCaños.Size = new System.Drawing.Size(27, 20);
            this.txtCaños.TabIndex = 0;
            this.txtCaños.ValidatingType = typeof(int);
            // 
            // grdCarpas
            // 
            this.grdCarpas.AllowUserToAddRows = false;
            this.grdCarpas.AllowUserToDeleteRows = false;
            this.grdCarpas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCarpas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipoCarpa,
            this.cantCaños,
            this.cantDormitorios});
            this.grdCarpas.Location = new System.Drawing.Point(302, 25);
            this.grdCarpas.Name = "grdCarpas";
            this.grdCarpas.ReadOnly = true;
            this.grdCarpas.Size = new System.Drawing.Size(360, 150);
            this.grdCarpas.TabIndex = 1;
            this.grdCarpas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCarpas_CellClick);
            this.grdCarpas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCarpas_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // tipoCarpa
            // 
            this.tipoCarpa.DataPropertyName = "tipoCarpa";
            this.tipoCarpa.HeaderText = "Tipo carpa";
            this.tipoCarpa.Name = "tipoCarpa";
            this.tipoCarpa.ReadOnly = true;
            this.tipoCarpa.Width = 80;
            // 
            // cantCaños
            // 
            this.cantCaños.DataPropertyName = "cantidadCaños";
            this.cantCaños.HeaderText = "Cantidad caños";
            this.cantCaños.Name = "cantCaños";
            this.cantCaños.ReadOnly = true;
            // 
            // cantDormitorios
            // 
            this.cantDormitorios.DataPropertyName = "cantidadDormitorios";
            this.cantDormitorios.HeaderText = "Cantidad dormitorios";
            this.cantDormitorios.Name = "cantDormitorios";
            this.cantDormitorios.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(587, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(506, 193);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Carpas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 233);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grdCarpas);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carpas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar carpas";
            this.Load += new System.EventHandler(this.Carpas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarpas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoCarpa;
        private System.Windows.Forms.Label lblDormitorios;
        private System.Windows.Forms.Label lblCaños;
        private System.Windows.Forms.Label lblTipoCarpa;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.MaskedTextBox txtDormitorios;
        private System.Windows.Forms.MaskedTextBox txtCaños;
        private System.Windows.Forms.DataGridView grdCarpas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCarpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantCaños;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantDormitorios;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblid;
    }
}