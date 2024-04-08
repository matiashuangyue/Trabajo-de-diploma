namespace Vista
{
    partial class FormInfoHistoriaCompraVenta
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
            this.btnHistoriaCompra = new System.Windows.Forms.Button();
            this.btnHistoriaVenta = new System.Windows.Forms.Button();
            this.gpbHistoriaCompra = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgwHistoriaCompra = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.gpbHistoriaVenta = new System.Windows.Forms.GroupBox();
            this.dgwHistoriaVenta = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbHistoriaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistoriaCompra)).BeginInit();
            this.gpbHistoriaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistoriaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistoriaCompra
            // 
            this.btnHistoriaCompra.BackColor = System.Drawing.Color.Cornsilk;
            this.btnHistoriaCompra.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoriaCompra.ForeColor = System.Drawing.Color.Black;
            this.btnHistoriaCompra.Location = new System.Drawing.Point(312, 226);
            this.btnHistoriaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistoriaCompra.Name = "btnHistoriaCompra";
            this.btnHistoriaCompra.Size = new System.Drawing.Size(266, 86);
            this.btnHistoriaCompra.TabIndex = 12;
            this.btnHistoriaCompra.Text = "Historia Compra";
            this.btnHistoriaCompra.UseVisualStyleBackColor = false;
            this.btnHistoriaCompra.Click += new System.EventHandler(this.btnGuardarDetalle_Click);
            // 
            // btnHistoriaVenta
            // 
            this.btnHistoriaVenta.BackColor = System.Drawing.Color.Cornsilk;
            this.btnHistoriaVenta.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoriaVenta.ForeColor = System.Drawing.Color.Black;
            this.btnHistoriaVenta.Location = new System.Drawing.Point(722, 226);
            this.btnHistoriaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistoriaVenta.Name = "btnHistoriaVenta";
            this.btnHistoriaVenta.Size = new System.Drawing.Size(266, 86);
            this.btnHistoriaVenta.TabIndex = 12;
            this.btnHistoriaVenta.Text = "Historia Venta";
            this.btnHistoriaVenta.UseVisualStyleBackColor = false;
            this.btnHistoriaVenta.Click += new System.EventHandler(this.btnGuardarDetalle_Click);
            // 
            // gpbHistoriaCompra
            // 
            this.gpbHistoriaCompra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpbHistoriaCompra.Controls.Add(this.dgwHistoriaCompra);
            this.gpbHistoriaCompra.Controls.Add(this.label2);
            this.gpbHistoriaCompra.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbHistoriaCompra.Location = new System.Drawing.Point(85, 346);
            this.gpbHistoriaCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbHistoriaCompra.Name = "gpbHistoriaCompra";
            this.gpbHistoriaCompra.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbHistoriaCompra.Size = new System.Drawing.Size(1326, 691);
            this.gpbHistoriaCompra.TabIndex = 13;
            this.gpbHistoriaCompra.TabStop = false;
            this.gpbHistoriaCompra.Text = "Historia Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio DESDE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 34);
            this.label2.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(1125, 101);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(298, 81);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // dgwHistoriaCompra
            // 
            this.dgwHistoriaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHistoriaCompra.Location = new System.Drawing.Point(35, 141);
            this.dgwHistoriaCompra.Name = "dgwHistoriaCompra";
            this.dgwHistoriaCompra.RowHeadersWidth = 62;
            this.dgwHistoriaCompra.RowTemplate.Height = 30;
            this.dgwHistoriaCompra.Size = new System.Drawing.Size(1093, 500);
            this.dgwHistoriaCompra.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(573, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "EN PROCESOS";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(555, 92);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(470, 37);
            this.dtpFechaInicio.TabIndex = 14;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 4, 8, 20, 25, 35, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(264, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasta :";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(555, 162);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(470, 37);
            this.dtpFechaFin.TabIndex = 14;
            // 
            // gpbHistoriaVenta
            // 
            this.gpbHistoriaVenta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpbHistoriaVenta.Controls.Add(this.dgwHistoriaVenta);
            this.gpbHistoriaVenta.Controls.Add(this.label5);
            this.gpbHistoriaVenta.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbHistoriaVenta.Location = new System.Drawing.Point(1440, 346);
            this.gpbHistoriaVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbHistoriaVenta.Name = "gpbHistoriaVenta";
            this.gpbHistoriaVenta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbHistoriaVenta.Size = new System.Drawing.Size(1326, 691);
            this.gpbHistoriaVenta.TabIndex = 15;
            this.gpbHistoriaVenta.TabStop = false;
            this.gpbHistoriaVenta.Text = "Historia Compra";
            // 
            // dgwHistoriaVenta
            // 
            this.dgwHistoriaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHistoriaVenta.Location = new System.Drawing.Point(35, 141);
            this.dgwHistoriaVenta.Name = "dgwHistoriaVenta";
            this.dgwHistoriaVenta.RowHeadersWidth = 62;
            this.dgwHistoriaVenta.RowTemplate.Height = 30;
            this.dgwHistoriaVenta.Size = new System.Drawing.Size(1093, 500);
            this.dgwHistoriaVenta.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 34);
            this.label5.TabIndex = 4;
            // 
            // FormInfoHistoriaCompraVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2046, 1244);
            this.Controls.Add(this.gpbHistoriaVenta);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.gpbHistoriaCompra);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnHistoriaVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHistoriaCompra);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInfoHistoriaCompraVenta";
            this.Text = "Historia de compra y venta";
            this.gpbHistoriaCompra.ResumeLayout(false);
            this.gpbHistoriaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistoriaCompra)).EndInit();
            this.gpbHistoriaVenta.ResumeLayout(false);
            this.gpbHistoriaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistoriaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHistoriaCompra;
        private System.Windows.Forms.Button btnHistoriaVenta;
        private System.Windows.Forms.GroupBox gpbHistoriaCompra;
        private System.Windows.Forms.DataGridView dgwHistoriaCompra;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.GroupBox gpbHistoriaVenta;
        private System.Windows.Forms.DataGridView dgwHistoriaVenta;
        private System.Windows.Forms.Label label5;
    }
}