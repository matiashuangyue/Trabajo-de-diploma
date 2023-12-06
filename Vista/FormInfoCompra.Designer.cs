namespace Vista
{
    partial class FormInfoCompra
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
            this.iDCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoDeDiplomaDataSet = new Vista.TrabajoDeDiplomaDataSet();
            this.comprasTableAdapter = new Vista.TrabajoDeDiplomaDataSetTableAdapters.ComprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCompraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.importeTotalDataGridViewTextBoxColumn,
            this.iDProveedorDataGridViewTextBoxColumn,
            this.dNIUsuarioDataGridViewTextBoxColumn,
            this.iDEstadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comprasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(835, 452);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // iDCompraDataGridViewTextBoxColumn
            // 
            this.iDCompraDataGridViewTextBoxColumn.DataPropertyName = "ID_Compra";
            this.iDCompraDataGridViewTextBoxColumn.HeaderText = "ID_Compra";
            this.iDCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCompraDataGridViewTextBoxColumn.Name = "iDCompraDataGridViewTextBoxColumn";
            this.iDCompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // importeTotalDataGridViewTextBoxColumn
            // 
            this.importeTotalDataGridViewTextBoxColumn.DataPropertyName = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn.HeaderText = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importeTotalDataGridViewTextBoxColumn.Name = "importeTotalDataGridViewTextBoxColumn";
            this.importeTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "ID_Proveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "ID_Proveedor";
            this.iDProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // dNIUsuarioDataGridViewTextBoxColumn
            // 
            this.dNIUsuarioDataGridViewTextBoxColumn.DataPropertyName = "DNI_Usuario";
            this.dNIUsuarioDataGridViewTextBoxColumn.HeaderText = "DNI_Usuario";
            this.dNIUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNIUsuarioDataGridViewTextBoxColumn.Name = "dNIUsuarioDataGridViewTextBoxColumn";
            this.dNIUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDEstadoDataGridViewTextBoxColumn
            // 
            this.iDEstadoDataGridViewTextBoxColumn.DataPropertyName = "ID_Estado";
            this.iDEstadoDataGridViewTextBoxColumn.HeaderText = "ID_Estado";
            this.iDEstadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDEstadoDataGridViewTextBoxColumn.Name = "iDEstadoDataGridViewTextBoxColumn";
            this.iDEstadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.trabajoDeDiplomaDataSet;
            // 
            // trabajoDeDiplomaDataSet
            // 
            this.trabajoDeDiplomaDataSet.DataSetName = "TrabajoDeDiplomaDataSet";
            this.trabajoDeDiplomaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // FormInfoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 590);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormInfoCompra";
            this.Text = "FormInfoCompra";
            this.Load += new System.EventHandler(this.FormInfoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoDeDiplomaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TrabajoDeDiplomaDataSet trabajoDeDiplomaDataSet;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private TrabajoDeDiplomaDataSetTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEstadoDataGridViewTextBoxColumn;
    }
}