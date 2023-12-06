namespace Vista
{
    partial class FormAddDetalleCompra
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
            this.btnGuardarDetalle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarDetalle
            // 
            this.btnGuardarDetalle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGuardarDetalle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarDetalle.Location = new System.Drawing.Point(492, 291);
            this.btnGuardarDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarDetalle.Name = "btnGuardarDetalle";
            this.btnGuardarDetalle.Size = new System.Drawing.Size(246, 49);
            this.btnGuardarDetalle.TabIndex = 12;
            this.btnGuardarDetalle.Text = "Modificar";
            this.btnGuardarDetalle.UseVisualStyleBackColor = false;
            this.btnGuardarDetalle.Click += new System.EventHandler(this.btnGuardarDetalle_Click);
            // 
            // FormAddDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarDetalle);
            this.Name = "FormAddDetalleCompra";
            this.Text = "FormAddDetalleCompra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarDetalle;
    }
}