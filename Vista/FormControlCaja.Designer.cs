namespace Vista
{
    partial class FormControlCaja
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
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.gbTipoComprobante = new System.Windows.Forms.GroupBox();
            this.gbMedioCobro = new System.Windows.Forms.GroupBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.gbTipoComprobante.SuspendLayout();
            this.gbMedioCobro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(220, 181);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(466, 38);
            this.cbVendedor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendedor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha final :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha inicio :";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(220, 110);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(699, 37);
            this.dtpFinal.TabIndex = 1;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(220, 45);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(699, 37);
            this.dtpInicio.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(756, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(846, 196);
            this.dataGridView2.TabIndex = 0;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.cbVendedor);
            this.gbFiltro.Controls.Add(this.dtpInicio);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.dtpFinal);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.Location = new System.Drawing.Point(28, 34);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(1842, 247);
            this.gbFiltro.TabIndex = 2;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro Para Generar Informe";
            // 
            // gbTipoComprobante
            // 
            this.gbTipoComprobante.Controls.Add(this.dataGridView1);
            this.gbTipoComprobante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoComprobante.Location = new System.Drawing.Point(35, 385);
            this.gbTipoComprobante.Name = "gbTipoComprobante";
            this.gbTipoComprobante.Size = new System.Drawing.Size(853, 336);
            this.gbTipoComprobante.TabIndex = 3;
            this.gbTipoComprobante.TabStop = false;
            this.gbTipoComprobante.Text = "Tipo de Comprobante :";
            // 
            // gbMedioCobro
            // 
            this.gbMedioCobro.Controls.Add(this.dataGridView2);
            this.gbMedioCobro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedioCobro.Location = new System.Drawing.Point(916, 385);
            this.gbMedioCobro.Name = "gbMedioCobro";
            this.gbMedioCobro.Size = new System.Drawing.Size(929, 336);
            this.gbMedioCobro.TabIndex = 3;
            this.gbMedioCobro.TabStop = false;
            this.gbMedioCobro.Text = "Medios de Cobros : ";
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(720, 305);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(299, 49);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Filtrar";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FormControlCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 972);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.gbMedioCobro);
            this.Controls.Add(this.gbTipoComprobante);
            this.Controls.Add(this.gbFiltro);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormControlCaja";
            this.Text = "Control Caja";
            this.Load += new System.EventHandler(this.FormControlStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbTipoComprobante.ResumeLayout(false);
            this.gbMedioCobro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.GroupBox gbTipoComprobante;
        private System.Windows.Forms.GroupBox gbMedioCobro;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}