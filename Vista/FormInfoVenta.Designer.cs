namespace Vista
{
    partial class FormInfoVenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVentasVendedor = new System.Windows.Forms.DataGridView();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoDeDiplomaDataSet2 = new Vista.TrabajoDeDiplomaDataSet2();
            this.trabajoDeDiplomaDataSet = new Vista.TrabajoDeDiplomaDataSet();
            this.trabajoDeDiplomaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new Vista.TrabajoDeDiplomaDataSet2TableAdapters.PedidosTableAdapter();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cbVendedores = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasVendedor
            // 
            this.dgvVentasVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentasVendedor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentasVendedor.Location = new System.Drawing.Point(53, 374);
            this.dgvVentasVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVentasVendedor.Name = "dgvVentasVendedor";
            this.dgvVentasVendedor.RowHeadersWidth = 51;
            this.dgvVentasVendedor.RowTemplate.Height = 27;
            this.dgvVentasVendedor.Size = new System.Drawing.Size(1854, 686);
            this.dgvVentasVendedor.TabIndex = 1;
            this.dgvVentasVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentasVendedor_CellContentClick);
            this.dgvVentasVendedor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.trabajoDeDiplomaDataSet2;
            // 
            // trabajoDeDiplomaDataSet2
            // 
            this.trabajoDeDiplomaDataSet2.DataSetName = "TrabajoDeDiplomaDataSet2";
            this.trabajoDeDiplomaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trabajoDeDiplomaDataSet
            // 
            this.trabajoDeDiplomaDataSet.DataSetName = "TrabajoDeDiplomaDataSet";
            this.trabajoDeDiplomaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trabajoDeDiplomaDataSetBindingSource
            // 
            this.trabajoDeDiplomaDataSetBindingSource.DataSource = this.trabajoDeDiplomaDataSet;
            this.trabajoDeDiplomaDataSetBindingSource.Position = 0;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(70, 307);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(317, 28);
            this.lblEmpleado.TabIndex = 6;
            this.lblEmpleado.Text = "Seleccionar el Empleado :";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendedores.FormattingEnabled = true;
            this.cbVendedores.Location = new System.Drawing.Point(1415, 299);
            this.cbVendedores.Margin = new System.Windows.Forms.Padding(4);
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Size = new System.Drawing.Size(470, 36);
            this.cbVendedores.TabIndex = 5;
            this.cbVendedores.SelectedIndexChanged += new System.EventHandler(this.cbVendedores_SelectedIndexChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(1339, 207);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(546, 37);
            this.dtpFechaFin.TabIndex = 19;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(1339, 137);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(546, 37);
            this.dtpFechaInicio.TabIndex = 20;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 4, 8, 20, 25, 35, 0);
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(254, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hasta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha Inicio DESDE :";
            // 
            // FormInfoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2104, 1302);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cbVendedores);
            this.Controls.Add(this.dgvVentasVendedor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInfoVenta";
            this.Text = "FormInfoVenta";
            this.Load += new System.EventHandler(this.FormInfoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasVendedor;
        private TrabajoDeDiplomaDataSet trabajoDeDiplomaDataSet;
        private System.Windows.Forms.BindingSource trabajoDeDiplomaDataSetBindingSource;
        private TrabajoDeDiplomaDataSet2 trabajoDeDiplomaDataSet2;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private TrabajoDeDiplomaDataSet2TableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cbVendedores;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}