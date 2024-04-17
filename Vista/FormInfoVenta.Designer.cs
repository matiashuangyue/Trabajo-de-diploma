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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVentasVendedor = new System.Windows.Forms.DataGridView();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoDeDiplomaDataSet2 = new Vista.TrabajoDeDiplomaDataSet2();
            this.trabajoDeDiplomaDataSet = new Vista.TrabajoDeDiplomaDataSet();
            this.trabajoDeDiplomaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new Vista.TrabajoDeDiplomaDataSet2TableAdapters.PedidosTableAdapter();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cbVendedores = new System.Windows.Forms.ComboBox();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentasVendedor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentasVendedor.Location = new System.Drawing.Point(53, 167);
            this.dgvVentasVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVentasVendedor.Name = "dgvVentasVendedor";
            this.dgvVentasVendedor.RowHeadersWidth = 51;
            this.dgvVentasVendedor.RowTemplate.Height = 27;
            this.dgvVentasVendedor.Size = new System.Drawing.Size(1854, 893);
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
            this.lblEmpleado.Location = new System.Drawing.Point(48, 89);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(317, 28);
            this.lblEmpleado.TabIndex = 6;
            this.lblEmpleado.Text = "Seleccionar el Empleado :";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendedores.FormattingEnabled = true;
            this.cbVendedores.Location = new System.Drawing.Point(1506, 89);
            this.cbVendedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Size = new System.Drawing.Size(401, 36);
            this.cbVendedores.TabIndex = 5;
            this.cbVendedores.SelectedIndexChanged += new System.EventHandler(this.cbVendedores_SelectedIndexChanged);
            // 
            // FormInfoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2104, 1302);
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
    }
}