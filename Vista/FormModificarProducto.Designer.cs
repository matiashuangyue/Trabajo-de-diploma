namespace Vista
{
    partial class FormModificarProducto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAddProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtNombProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.btnAddProducto);
            this.groupBox1.Controls.Add(this.txtNombProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(82, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 421);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Productos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDescripcion.Location = new System.Drawing.Point(243, 146);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(284, 106);
            this.txtDescripcion.TabIndex = 14;
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAddProducto.Location = new System.Drawing.Point(421, 337);
            this.btnAddProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.Size = new System.Drawing.Size(151, 54);
            this.btnAddProducto.TabIndex = 12;
            this.btnAddProducto.Text = "Agregar Producto";
            this.btnAddProducto.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo De Producto";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCodProducto.Location = new System.Drawing.Point(270, 34);
            this.txtCodProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(284, 25);
            this.txtCodProducto.TabIndex = 0;
            // 
            // txtNombProducto
            // 
            this.txtNombProducto.BackColor = System.Drawing.Color.Cornsilk;
            this.txtNombProducto.Location = new System.Drawing.Point(243, 87);
            this.txtNombProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombProducto.Name = "txtNombProducto";
            this.txtNombProducto.Size = new System.Drawing.Size(284, 28);
            this.txtNombProducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(612, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodProducto);
            this.Name = "FormModificarProducto";
            this.Text = "FormModificarProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAddProducto;
        private System.Windows.Forms.TextBox txtNombProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Button button1;
    }
}