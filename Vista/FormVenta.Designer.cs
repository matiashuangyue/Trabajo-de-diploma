﻿namespace Vista
{
    partial class FormVenta
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
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnCerrarVenta = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.txtPrecioDetalleVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarDetallePedido = new System.Windows.Forms.Button();
            this.txtNombDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoDetalle = new System.Windows.Forms.TextBox();
            this.ID_Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.White;
            this.panelDetalle.Controls.Add(this.dgvDetalles);
            this.panelDetalle.Controls.Add(this.btnCerrarVenta);
            this.panelDetalle.Controls.Add(this.btnBuscarProducto);
            this.panelDetalle.Controls.Add(this.groupBox2);
            this.panelDetalle.Controls.Add(this.label10);
            this.panelDetalle.Controls.Add(this.txtCodigoDetalle);
            this.panelDetalle.Location = new System.Drawing.Point(12, 12);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(897, 558);
            this.panelDetalle.TabIndex = 19;
            this.panelDetalle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDetalle_Paint);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Detalle,
            this.ID_Producto,
            this.Cantidad,
            this.Precio_Venta,
            this.CantidadPrecio});
            this.dgvDetalles.GridColor = System.Drawing.Color.Black;
            this.dgvDetalles.Location = new System.Drawing.Point(71, 351);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 27;
            this.dgvDetalles.Size = new System.Drawing.Size(684, 184);
            this.dgvDetalles.TabIndex = 19;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvDetalles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwDetalles_CellFormatting);
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCerrarVenta.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarVenta.Location = new System.Drawing.Point(762, 381);
            this.btnCerrarVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(131, 154);
            this.btnCerrarVenta.TabIndex = 18;
            this.btnCerrarVenta.Text = "Finalizar la Venta";
            this.btnCerrarVenta.UseVisualStyleBackColor = false;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(601, 6);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(170, 63);
            this.btnBuscarProducto.TabIndex = 17;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.lblCliente);
            this.groupBox2.Controls.Add(this.txtPorcentaje);
            this.groupBox2.Controls.Add(this.lblPorcentaje);
            this.groupBox2.Controls.Add(this.txtPrecioDetalleVenta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAgregarDetallePedido);
            this.groupBox2.Controls.Add(this.txtNombDetalle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(67, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 258);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Productos";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCliente.Location = new System.Drawing.Point(265, 220);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(224, 28);
            this.txtCliente.TabIndex = 23;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(12, 223);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(93, 19);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "ID Cliente:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPorcentaje.Location = new System.Drawing.Point(265, 86);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(284, 28);
            this.txtPorcentaje.TabIndex = 21;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPorcentaje.ForeColor = System.Drawing.Color.Black;
            this.lblPorcentaje.Location = new System.Drawing.Point(12, 86);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(194, 19);
            this.lblPorcentaje.TabIndex = 20;
            this.lblPorcentaje.Text = "Porcentaje Ganancia :";
            // 
            // txtPrecioDetalleVenta
            // 
            this.txtPrecioDetalleVenta.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPrecioDetalleVenta.Enabled = false;
            this.txtPrecioDetalleVenta.Location = new System.Drawing.Point(265, 129);
            this.txtPrecioDetalleVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioDetalleVenta.Name = "txtPrecioDetalleVenta";
            this.txtPrecioDetalleVenta.Size = new System.Drawing.Size(284, 28);
            this.txtPrecioDetalleVenta.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Precio :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCantidad.Location = new System.Drawing.Point(265, 182);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(224, 28);
            this.txtCantidad.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ingresar Cantidad :";
            // 
            // btnAgregarDetallePedido
            // 
            this.btnAgregarDetallePedido.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAgregarDetallePedido.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDetallePedido.Location = new System.Drawing.Point(531, 188);
            this.btnAgregarDetallePedido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarDetallePedido.Name = "btnAgregarDetallePedido";
            this.btnAgregarDetallePedido.Size = new System.Drawing.Size(151, 54);
            this.btnAgregarDetallePedido.TabIndex = 12;
            this.btnAgregarDetallePedido.Text = "Agregar Detalle Pedido";
            this.btnAgregarDetallePedido.UseVisualStyleBackColor = false;
            this.btnAgregarDetallePedido.Click += new System.EventHandler(this.btnAgregarDetallePedido_Click);
            // 
            // txtNombDetalle
            // 
            this.txtNombDetalle.BackColor = System.Drawing.Color.Cornsilk;
            this.txtNombDetalle.Location = new System.Drawing.Point(265, 42);
            this.txtNombDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombDetalle.Name = "txtNombDetalle";
            this.txtNombDetalle.Size = new System.Drawing.Size(284, 28);
            this.txtNombDetalle.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(41, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Codigo De Producto";
            // 
            // txtCodigoDetalle
            // 
            this.txtCodigoDetalle.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCodigoDetalle.Location = new System.Drawing.Point(288, 14);
            this.txtCodigoDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoDetalle.Name = "txtCodigoDetalle";
            this.txtCodigoDetalle.Size = new System.Drawing.Size(284, 25);
            this.txtCodigoDetalle.TabIndex = 14;
            // 
            // ID_Detalle
            // 
            this.ID_Detalle.HeaderText = "ID_Detalle";
            this.ID_Detalle.MinimumWidth = 6;
            this.ID_Detalle.Name = "ID_Detalle";
            this.ID_Detalle.Width = 125;
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID_Producto";
            this.ID_Producto.MinimumWidth = 6;
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.HeaderText = "Precio_Venta";
            this.Precio_Venta.MinimumWidth = 6;
            this.Precio_Venta.Name = "Precio_Venta";
            this.Precio_Venta.Width = 125;
            // 
            // CantidadPrecio
            // 
            this.CantidadPrecio.HeaderText = "CantidadPrecio";
            this.CantidadPrecio.MinimumWidth = 6;
            this.CantidadPrecio.Name = "CantidadPrecio";
            this.CantidadPrecio.Width = 125;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 599);
            this.Controls.Add(this.panelDetalle);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnCerrarVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecioDetalleVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarDetallePedido;
        private System.Windows.Forms.TextBox txtNombDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoDetalle;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPrecio;
    }
}