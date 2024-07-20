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
            this.cbVendedores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvTipoComprobante = new System.Windows.Forms.DataGridView();
            this.dgvMediosCobros = new System.Windows.Forms.DataGridView();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.gbTipoComprobante = new System.Windows.Forms.GroupBox();
            this.gbMedioCobro = new System.Windows.Forms.GroupBox();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediosCobros)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.gbTipoComprobante.SuspendLayout();
            this.gbMedioCobro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbVendedores
            // 
            this.cbVendedores.FormattingEnabled = true;
            this.cbVendedores.Location = new System.Drawing.Point(552, 196);
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Size = new System.Drawing.Size(466, 38);
            this.cbVendedores.TabIndex = 3;
            this.cbVendedores.SelectedIndexChanged += new System.EventHandler(this.cbVendedores_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendedor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha final :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha inicio :";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFinal.Location = new System.Drawing.Point(552, 117);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(699, 37);
            this.dtpFechaFinal.TabIndex = 1;
            this.dtpFechaFinal.Value = new System.DateTime(2024, 7, 20, 0, 0, 0, 0);
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Location = new System.Drawing.Point(552, 52);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(699, 37);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 7, 20, 0, 0, 0, 0);
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dgvTipoComprobante
            // 
            this.dgvTipoComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoComprobante.Location = new System.Drawing.Point(6, 53);
            this.dgvTipoComprobante.Name = "dgvTipoComprobante";
            this.dgvTipoComprobante.RowHeadersWidth = 62;
            this.dgvTipoComprobante.RowTemplate.Height = 30;
            this.dgvTipoComprobante.Size = new System.Drawing.Size(1723, 277);
            this.dgvTipoComprobante.TabIndex = 0;
            // 
            // dgvMediosCobros
            // 
            this.dgvMediosCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediosCobros.Location = new System.Drawing.Point(6, 51);
            this.dgvMediosCobros.Name = "dgvMediosCobros";
            this.dgvMediosCobros.RowHeadersWidth = 62;
            this.dgvMediosCobros.RowTemplate.Height = 30;
            this.dgvMediosCobros.Size = new System.Drawing.Size(1717, 326);
            this.dgvMediosCobros.TabIndex = 0;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.cbVendedores);
            this.gbFiltro.Controls.Add(this.dtpHoraFinal);
            this.gbFiltro.Controls.Add(this.dtpHoraInicio);
            this.gbFiltro.Controls.Add(this.dtpFechaInicio);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.dtpFechaFinal);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.ForeColor = System.Drawing.Color.Black;
            this.gbFiltro.Location = new System.Drawing.Point(28, 34);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(1842, 247);
            this.gbFiltro.TabIndex = 2;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro Para Generar Informe";
            // 
            // gbTipoComprobante
            // 
            this.gbTipoComprobante.Controls.Add(this.dgvTipoComprobante);
            this.gbTipoComprobante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoComprobante.Location = new System.Drawing.Point(37, 385);
            this.gbTipoComprobante.Name = "gbTipoComprobante";
            this.gbTipoComprobante.Size = new System.Drawing.Size(1729, 336);
            this.gbTipoComprobante.TabIndex = 3;
            this.gbTipoComprobante.TabStop = false;
            this.gbTipoComprobante.Text = "Tipo de Comprobante :";
            // 
            // gbMedioCobro
            // 
            this.gbMedioCobro.Controls.Add(this.dgvMediosCobros);
            this.gbMedioCobro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedioCobro.Location = new System.Drawing.Point(43, 748);
            this.gbMedioCobro.Name = "gbMedioCobro";
            this.gbMedioCobro.Size = new System.Drawing.Size(1723, 431);
            this.gbMedioCobro.TabIndex = 3;
            this.gbMedioCobro.TabStop = false;
            this.gbMedioCobro.Text = "Medios de Cobros : ";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnExportar.IconColor = System.Drawing.Color.Black;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(1297, 296);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(469, 92);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar informe";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(711, 1229);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(245, 51);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(1348, 1229);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(141, 51);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total :";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(1257, 52);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(259, 37);
            this.dtpHoraInicio.TabIndex = 0;
            this.dtpHoraInicio.ValueChanged += new System.EventHandler(this.dtpHoraInicio_ValueChanged);
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.CustomFormat = "HH:mm";
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFinal.Location = new System.Drawing.Point(1257, 117);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(259, 37);
            this.dtpHoraFinal.TabIndex = 0;
            this.dtpHoraFinal.ValueChanged += new System.EventHandler(this.dtpHoraFinal_ValueChanged);
            // 
            // FormControlCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 1369);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.gbMedioCobro);
            this.Controls.Add(this.gbTipoComprobante);
            this.Controls.Add(this.gbFiltro);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormControlCaja";
            this.Text = "Control Caja";
            this.Load += new System.EventHandler(this.FormControlStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediosCobros)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbTipoComprobante.ResumeLayout(false);
            this.gbMedioCobro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cbVendedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTipoComprobante;
        private System.Windows.Forms.DataGridView dgvMediosCobros;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.GroupBox gbTipoComprobante;
        private System.Windows.Forms.GroupBox gbMedioCobro;
        private FontAwesome.Sharp.IconButton btnExportar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
    }
}