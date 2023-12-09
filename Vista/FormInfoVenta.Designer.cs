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
            this.dgvVentasVendedor = new System.Windows.Forms.DataGridView();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoDeDiplomaDataSet2 = new Vista.TrabajoDeDiplomaDataSet2();
            this.trabajoDeDiplomaDataSet = new Vista.TrabajoDeDiplomaDataSet();
            this.trabajoDeDiplomaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new Vista.TrabajoDeDiplomaDataSet2TableAdapters.PedidosTableAdapter();
            this.lblVendedor = new System.Windows.Forms.Label();
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
            this.dgvVentasVendedor.Location = new System.Drawing.Point(30, 92);
            this.dgvVentasVendedor.Name = "dgvVentasVendedor";
            this.dgvVentasVendedor.RowHeadersWidth = 51;
            this.dgvVentasVendedor.RowTemplate.Height = 27;
            this.dgvVentasVendedor.Size = new System.Drawing.Size(921, 402);
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
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(27, 47);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(207, 15);
            this.lblVendedor.TabIndex = 6;
            this.lblVendedor.Text = "Seleccionar el Vendedor :";
            // 
            // cbVendedores
            // 
            this.cbVendedores.FormattingEnabled = true;
            this.cbVendedores.Location = new System.Drawing.Point(333, 44);
            this.cbVendedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Size = new System.Drawing.Size(379, 23);
            this.cbVendedores.TabIndex = 5;
            this.cbVendedores.SelectedIndexChanged += new System.EventHandler(this.cbVendedores_SelectedIndexChanged);
            // 
            // FormInfoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 612);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.cbVendedores);
            this.Controls.Add(this.dgvVentasVendedor);
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
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cbVendedores;
    }
}