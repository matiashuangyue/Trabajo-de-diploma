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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDVendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoDeDiplomaDataSet2 = new Vista.TrabajoDeDiplomaDataSet2();
            this.trabajoDeDiplomaDataSet = new Vista.TrabajoDeDiplomaDataSet();
            this.trabajoDeDiplomaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new Vista.TrabajoDeDiplomaDataSet2TableAdapters.PedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPedidoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.netosDataGridViewTextBoxColumn,
            this.iDVendedorDataGridViewTextBoxColumn,
            this.iDClienteDataGridViewTextBoxColumn,
            this.iDEstadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pedidosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(919, 441);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // iDPedidoDataGridViewTextBoxColumn
            // 
            this.iDPedidoDataGridViewTextBoxColumn.DataPropertyName = "ID_Pedido";
            this.iDPedidoDataGridViewTextBoxColumn.HeaderText = "ID_Pedido";
            this.iDPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPedidoDataGridViewTextBoxColumn.Name = "iDPedidoDataGridViewTextBoxColumn";
            this.iDPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.Width = 125;
            // 
            // netosDataGridViewTextBoxColumn
            // 
            this.netosDataGridViewTextBoxColumn.DataPropertyName = "Netos";
            this.netosDataGridViewTextBoxColumn.HeaderText = "Netos";
            this.netosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.netosDataGridViewTextBoxColumn.Name = "netosDataGridViewTextBoxColumn";
            this.netosDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDVendedorDataGridViewTextBoxColumn
            // 
            this.iDVendedorDataGridViewTextBoxColumn.DataPropertyName = "ID_Vendedor";
            this.iDVendedorDataGridViewTextBoxColumn.HeaderText = "ID_Vendedor";
            this.iDVendedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDVendedorDataGridViewTextBoxColumn.Name = "iDVendedorDataGridViewTextBoxColumn";
            this.iDVendedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDEstadoDataGridViewTextBoxColumn
            // 
            this.iDEstadoDataGridViewTextBoxColumn.DataPropertyName = "ID_Estado";
            this.iDEstadoDataGridViewTextBoxColumn.HeaderText = "ID_Estado";
            this.iDEstadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDEstadoDataGridViewTextBoxColumn.Name = "iDEstadoDataGridViewTextBoxColumn";
            this.iDEstadoDataGridViewTextBoxColumn.Width = 125;
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
            // FormInfoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 612);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormInfoVenta";
            this.Text = "FormInfoVenta";
            this.Load += new System.EventHandler(this.FormInfoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TrabajoDeDiplomaDataSet trabajoDeDiplomaDataSet;
        private System.Windows.Forms.BindingSource trabajoDeDiplomaDataSetBindingSource;
        private TrabajoDeDiplomaDataSet2 trabajoDeDiplomaDataSet2;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private TrabajoDeDiplomaDataSet2TableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEstadoDataGridViewTextBoxColumn;
    }
}