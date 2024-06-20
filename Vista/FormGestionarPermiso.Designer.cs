namespace Vista
{
    partial class FormGestionarPermiso
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
            this.label10 = new System.Windows.Forms.Label();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAddRoles = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.lsbRoles = new System.Windows.Forms.ListBox();
            this.btnCrearNuevoRol = new System.Windows.Forms.Button();
            this.txtNombRol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbPermisos = new System.Windows.Forms.ListBox();
            this.btnCrearNuevoPermiso = new System.Windows.Forms.Button();
            this.txtNombPermiso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPermisosSegunRol = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarPermisoDeRol = new System.Windows.Forms.Button();
            this.gbAddRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosSegunRol)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(694, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(485, 43);
            this.label10.TabIndex = 16;
            this.label10.Text = "Gestionar Roles y Permisos";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbRoles
            // 
            this.cbRoles.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(267, 47);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(535, 42);
            this.cbRoles.TabIndex = 114;
            this.cbRoles.SelectedIndexChanged += new System.EventHandler(this.cbRoles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 115;
            this.label1.Text = "Roles";
            // 
            // gbAddRoles
            // 
            this.gbAddRoles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAddRoles.Controls.Add(this.label5);
            this.gbAddRoles.Controls.Add(this.dgvPermisos);
            this.gbAddRoles.Controls.Add(this.lblPermiso);
            this.gbAddRoles.Controls.Add(this.lsbRoles);
            this.gbAddRoles.Controls.Add(this.btnCrearNuevoRol);
            this.gbAddRoles.Controls.Add(this.txtNombRol);
            this.gbAddRoles.Controls.Add(this.label6);
            this.gbAddRoles.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddRoles.Location = new System.Drawing.Point(47, 468);
            this.gbAddRoles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAddRoles.Name = "gbAddRoles";
            this.gbAddRoles.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAddRoles.Size = new System.Drawing.Size(1918, 472);
            this.gbAddRoles.TabIndex = 117;
            this.gbAddRoles.TabStop = false;
            this.gbAddRoles.Text = "Crear Roles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1373, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 34);
            this.label5.TabIndex = 121;
            this.label5.Text = "Roles Existentes :";
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPermisos.Location = new System.Drawing.Point(42, 175);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.RowHeadersWidth = 62;
            this.dgvPermisos.RowTemplate.Height = 30;
            this.dgvPermisos.Size = new System.Drawing.Size(1259, 283);
            this.dgvPermisos.TabIndex = 119;
            this.dgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seleccionar";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Permiso";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPermiso.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermiso.ForeColor = System.Drawing.Color.Black;
            this.lblPermiso.Location = new System.Drawing.Point(7, 130);
            this.lblPermiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(528, 34);
            this.lblPermiso.TabIndex = 120;
            this.lblPermiso.Text = "Seleccionar Permisos Para Rol Nuevo:";
            this.lblPermiso.Click += new System.EventHandler(this.lblPermiso_Click);
            // 
            // lsbRoles
            // 
            this.lsbRoles.FormattingEnabled = true;
            this.lsbRoles.ItemHeight = 34;
            this.lsbRoles.Location = new System.Drawing.Point(1379, 216);
            this.lsbRoles.Name = "lsbRoles";
            this.lsbRoles.Size = new System.Drawing.Size(492, 242);
            this.lsbRoles.TabIndex = 118;
            // 
            // btnCrearNuevoRol
            // 
            this.btnCrearNuevoRol.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCrearNuevoRol.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearNuevoRol.ForeColor = System.Drawing.Color.Black;
            this.btnCrearNuevoRol.Location = new System.Drawing.Point(1379, 43);
            this.btnCrearNuevoRol.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearNuevoRol.Name = "btnCrearNuevoRol";
            this.btnCrearNuevoRol.Size = new System.Drawing.Size(492, 91);
            this.btnCrearNuevoRol.TabIndex = 12;
            this.btnCrearNuevoRol.Text = "Crear Nuevo Rol";
            this.btnCrearNuevoRol.UseVisualStyleBackColor = false;
            this.btnCrearNuevoRol.Click += new System.EventHandler(this.btnCrearNuevoRol_Click);
            // 
            // txtNombRol
            // 
            this.txtNombRol.BackColor = System.Drawing.Color.Cornsilk;
            this.txtNombRol.Location = new System.Drawing.Point(831, 55);
            this.txtNombRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombRol.Name = "txtNombRol";
            this.txtNombRol.Size = new System.Drawing.Size(470, 42);
            this.txtNombRol.TabIndex = 2;
            this.txtNombRol.TextChanged += new System.EventHandler(this.txtNombRol_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(474, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ingresar Nombre Para Nuevo Rol :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lsbPermisos);
            this.groupBox1.Controls.Add(this.btnCrearNuevoPermiso);
            this.groupBox1.Controls.Add(this.txtNombPermiso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 948);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1918, 290);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Permisos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1142, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 34);
            this.label3.TabIndex = 122;
            this.label3.Text = "Permisos Existentes :";
            // 
            // lsbPermisos
            // 
            this.lsbPermisos.FormattingEnabled = true;
            this.lsbPermisos.ItemHeight = 34;
            this.lsbPermisos.Location = new System.Drawing.Point(1148, 100);
            this.lsbPermisos.Name = "lsbPermisos";
            this.lsbPermisos.Size = new System.Drawing.Size(708, 174);
            this.lsbPermisos.TabIndex = 118;
            // 
            // btnCrearNuevoPermiso
            // 
            this.btnCrearNuevoPermiso.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCrearNuevoPermiso.ForeColor = System.Drawing.Color.Black;
            this.btnCrearNuevoPermiso.Location = new System.Drawing.Point(487, 148);
            this.btnCrearNuevoPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearNuevoPermiso.Name = "btnCrearNuevoPermiso";
            this.btnCrearNuevoPermiso.Size = new System.Drawing.Size(551, 132);
            this.btnCrearNuevoPermiso.TabIndex = 12;
            this.btnCrearNuevoPermiso.Text = "Crear Nuevo Permiso";
            this.btnCrearNuevoPermiso.UseVisualStyleBackColor = false;
            this.btnCrearNuevoPermiso.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombPermiso
            // 
            this.txtNombPermiso.BackColor = System.Drawing.Color.Cornsilk;
            this.txtNombPermiso.Location = new System.Drawing.Point(568, 35);
            this.txtNombPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombPermiso.Name = "txtNombPermiso";
            this.txtNombPermiso.Size = new System.Drawing.Size(470, 42);
            this.txtNombPermiso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar Nuevo Permiso :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dgvPermisosSegunRol);
            this.groupBox2.Controls.Add(this.btnModificarPermisoDeRol);
            this.groupBox2.Controls.Add(this.cbRoles);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(47, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1914, 394);
            this.groupBox2.TabIndex = 119;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Permisos";
            // 
            // dgvPermisosSegunRol
            // 
            this.dgvPermisosSegunRol.AllowUserToAddRows = false;
            this.dgvPermisosSegunRol.AllowUserToDeleteRows = false;
            this.dgvPermisosSegunRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosSegunRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dgvPermisosSegunRol.Location = new System.Drawing.Point(26, 116);
            this.dgvPermisosSegunRol.Name = "dgvPermisosSegunRol";
            this.dgvPermisosSegunRol.RowHeadersWidth = 62;
            this.dgvPermisosSegunRol.RowTemplate.Height = 30;
            this.dgvPermisosSegunRol.Size = new System.Drawing.Size(1259, 259);
            this.dgvPermisosSegunRol.TabIndex = 120;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Permiso";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // btnModificarPermisoDeRol
            // 
            this.btnModificarPermisoDeRol.BackColor = System.Drawing.Color.Cornsilk;
            this.btnModificarPermisoDeRol.ForeColor = System.Drawing.Color.Black;
            this.btnModificarPermisoDeRol.Location = new System.Drawing.Point(1364, 116);
            this.btnModificarPermisoDeRol.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarPermisoDeRol.Name = "btnModificarPermisoDeRol";
            this.btnModificarPermisoDeRol.Size = new System.Drawing.Size(492, 127);
            this.btnModificarPermisoDeRol.TabIndex = 12;
            this.btnModificarPermisoDeRol.Text = "Modificar Permiso";
            this.btnModificarPermisoDeRol.UseVisualStyleBackColor = false;
            this.btnModificarPermisoDeRol.Click += new System.EventHandler(this.btnModificarPermisoDeRol_Click);
            // 
            // FormGestionarPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2046, 1558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAddRoles);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGestionarPermiso";
            this.Load += new System.EventHandler(this.FormGestionarPermiso_Load);
            this.gbAddRoles.ResumeLayout(false);
            this.gbAddRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosSegunRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAddRoles;
        private System.Windows.Forms.Button btnCrearNuevoRol;
        private System.Windows.Forms.TextBox txtNombRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPermiso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbPermisos;
        private System.Windows.Forms.Button btnCrearNuevoPermiso;
        private System.Windows.Forms.TextBox txtNombPermiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbRoles;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificarPermisoDeRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPermisosSegunRol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}