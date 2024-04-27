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
            this.btnCrearNuevoRol = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombRol = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbRoles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clbPermisos = new System.Windows.Forms.CheckedListBox();
            this.gbAddRoles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(654, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(485, 43);
            this.label10.TabIndex = 16;
            this.label10.Text = "Gestionar Roles y Permisos";
            // 
            // cbRoles
            // 
            this.cbRoles.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(273, 1229);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(535, 42);
            this.cbRoles.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 1237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 115;
            this.label1.Text = "Roles";
            // 
            // gbAddRoles
            // 
            this.gbAddRoles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAddRoles.Controls.Add(this.label3);
            this.gbAddRoles.Controls.Add(this.btnCrearNuevoRol);
            this.gbAddRoles.Controls.Add(this.txtNombRol);
            this.gbAddRoles.Controls.Add(this.label6);
            this.gbAddRoles.Controls.Add(this.clbPermisos);
            this.gbAddRoles.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddRoles.Location = new System.Drawing.Point(92, 205);
            this.gbAddRoles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAddRoles.Name = "gbAddRoles";
            this.gbAddRoles.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAddRoles.Size = new System.Drawing.Size(1512, 457);
            this.gbAddRoles.TabIndex = 117;
            this.gbAddRoles.TabStop = false;
            this.gbAddRoles.Text = "Crear Roles";
            // 
            // btnCrearNuevoRol
            // 
            this.btnCrearNuevoRol.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCrearNuevoRol.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearNuevoRol.ForeColor = System.Drawing.Color.Black;
            this.btnCrearNuevoRol.Location = new System.Drawing.Point(1000, 289);
            this.btnCrearNuevoRol.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearNuevoRol.Name = "btnCrearNuevoRol";
            this.btnCrearNuevoRol.Size = new System.Drawing.Size(497, 132);
            this.btnCrearNuevoRol.TabIndex = 12;
            this.btnCrearNuevoRol.Text = "Crear Nuevo Rol";
            this.btnCrearNuevoRol.UseVisualStyleBackColor = false;
            this.btnCrearNuevoRol.Click += new System.EventHandler(this.btnCrearNuevoRol_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre :";
            // 
            // txtNombRol
            // 
            this.txtNombRol.BackColor = System.Drawing.Color.Cornsilk;
            this.txtNombRol.Enabled = false;
            this.txtNombRol.Location = new System.Drawing.Point(523, 43);
            this.txtNombRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombRol.Name = "txtNombRol";
            this.txtNombRol.Size = new System.Drawing.Size(470, 42);
            this.txtNombRol.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 716);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1512, 457);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Permisos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 34;
            this.listBox1.Location = new System.Drawing.Point(20, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(871, 242);
            this.listBox1.TabIndex = 118;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(948, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(497, 132);
            this.button1.TabIndex = 12;
            this.button1.Text = "Crear Nuevo Permiso";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(421, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 42);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre :";
            // 
            // lsbRoles
            // 
            this.lsbRoles.FormattingEnabled = true;
            this.lsbRoles.ItemHeight = 18;
            this.lsbRoles.Location = new System.Drawing.Point(-11, 1277);
            this.lsbRoles.Name = "lsbRoles";
            this.lsbRoles.Size = new System.Drawing.Size(871, 238);
            this.lsbRoles.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 34);
            this.label3.TabIndex = 120;
            this.label3.Text = "Permisos :";
            // 
            // clbPermisos
            // 
            this.clbPermisos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPermisos.FormattingEnabled = true;
            this.clbPermisos.Items.AddRange(new object[] {
            "1321",
            "123"});
            this.clbPermisos.Location = new System.Drawing.Point(252, 105);
            this.clbPermisos.Name = "clbPermisos";
            this.clbPermisos.Size = new System.Drawing.Size(741, 316);
            this.clbPermisos.TabIndex = 17;
            // 
            // FormGestionarPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2046, 1558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsbRoles);
            this.Controls.Add(this.gbAddRoles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGestionarPermiso";
            this.Load += new System.EventHandler(this.FormGestionarPermiso_Load);
            this.gbAddRoles.ResumeLayout(false);
            this.gbAddRoles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbRoles;
        private System.Windows.Forms.CheckedListBox clbPermisos;
    }
}