namespace Vista
{
    partial class FormCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCompra = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCompra = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCerrarCompra = new System.Windows.Forms.Button();
            this.txtPrecioDetalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionDetalle = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.txtNombDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoDetalle = new System.Windows.Forms.TextBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ID_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panelCompra.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(964, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(364, 59);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar Proveedor";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnCompra);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1326, 691);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 34);
            this.label8.TabIndex = 10;
            this.label8.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 34);
            this.label7.TabIndex = 9;
            this.label7.Text = "Telefono";
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCompra.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.Black;
            this.btnCompra.Location = new System.Drawing.Point(875, 495);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(364, 162);
            this.btnCompra.TabIndex = 11;
            this.btnCompra.Text = "Generar Nueva Compra";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(318, 311);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(470, 42);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Cornsilk;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(318, 248);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(470, 42);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Cornsilk;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(318, 106);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(470, 42);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Cornsilk;
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(318, 179);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(470, 42);
            this.txtMail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDNI.Location = new System.Drawing.Point(355, 29);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(470, 37);
            this.txtDNI.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "DNI";
            // 
            // panelCompra
            // 
            this.panelCompra.BackColor = System.Drawing.Color.White;
            this.panelCompra.Controls.Add(this.btnBuscar);
            this.panelCompra.Controls.Add(this.groupBox1);
            this.panelCompra.Controls.Add(this.txtDNI);
            this.panelCompra.Controls.Add(this.label2);
            this.panelCompra.Location = new System.Drawing.Point(29, 68);
            this.panelCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCompra.Name = "panelCompra";
            this.panelCompra.Size = new System.Drawing.Size(1794, 1082);
            this.panelCompra.TabIndex = 17;
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.White;
            this.panelDetalle.Controls.Add(this.dgvDetalles);
            this.panelDetalle.Controls.Add(this.btnBuscarProducto);
            this.panelDetalle.Controls.Add(this.groupBox2);
            this.panelDetalle.Controls.Add(this.label10);
            this.panelDetalle.Controls.Add(this.txtCodigoDetalle);
            this.panelDetalle.Location = new System.Drawing.Point(26, 68);
            this.panelDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(1955, 1477);
            this.panelDetalle.TabIndex = 18;
            this.panelDetalle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDetalle_Paint);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(1123, 9);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(278, 71);
            this.btnBuscarProducto.TabIndex = 17;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnCerrarCompra);
            this.groupBox2.Controls.Add(this.txtPrecioDetalle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDescripcionDetalle);
            this.groupBox2.Controls.Add(this.btnAgregarDetalle);
            this.groupBox2.Controls.Add(this.txtNombDetalle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(75, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1326, 691);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Productos";
            // 
            // btnCerrarCompra
            // 
            this.btnCerrarCompra.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCerrarCompra.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCompra.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarCompra.Location = new System.Drawing.Point(879, 529);
            this.btnCerrarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarCompra.Name = "btnCerrarCompra";
            this.btnCerrarCompra.Size = new System.Drawing.Size(425, 104);
            this.btnCerrarCompra.TabIndex = 18;
            this.btnCerrarCompra.Text = "Finalizar la compra";
            this.btnCerrarCompra.UseVisualStyleBackColor = false;
            this.btnCerrarCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPrecioDetalle.Enabled = false;
            this.txtPrecioDetalle.Location = new System.Drawing.Point(474, 248);
            this.txtPrecioDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.Size = new System.Drawing.Size(470, 42);
            this.txtPrecioDetalle.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Precio :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCantidad.Location = new System.Drawing.Point(474, 412);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(246, 42);
            this.txtCantidad.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ingresar Cantidad :";
            // 
            // txtDescripcionDetalle
            // 
            this.txtDescripcionDetalle.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDescripcionDetalle.Enabled = false;
            this.txtDescripcionDetalle.Location = new System.Drawing.Point(474, 106);
            this.txtDescripcionDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionDetalle.Multiline = true;
            this.txtDescripcionDetalle.Name = "txtDescripcionDetalle";
            this.txtDescripcionDetalle.Size = new System.Drawing.Size(470, 126);
            this.txtDescripcionDetalle.TabIndex = 14;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAgregarDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(807, 322);
            this.btnAgregarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(497, 132);
            this.btnAgregarDetalle.TabIndex = 12;
            this.btnAgregarDetalle.Text = "Agregar Detalle Compra";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // txtNombDetalle
            // 
            this.txtNombDetalle.BackColor = System.Drawing.Color.Cornsilk;
            this.txtNombDetalle.Enabled = false;
            this.txtNombDetalle.Location = new System.Drawing.Point(474, 50);
            this.txtNombDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombDetalle.Name = "txtNombDetalle";
            this.txtNombDetalle.Size = new System.Drawing.Size(470, 42);
            this.txtNombDetalle.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "Descripcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(52, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 34);
            this.label10.TabIndex = 15;
            this.label10.Text = "Codigo De Producto";
            // 
            // txtCodigoDetalle
            // 
            this.txtCodigoDetalle.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCodigoDetalle.Location = new System.Drawing.Point(569, 29);
            this.txtCodigoDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoDetalle.Multiline = true;
            this.txtCodigoDetalle.Name = "txtCodigoDetalle";
            this.txtCodigoDetalle.Size = new System.Drawing.Size(470, 42);
            this.txtCodigoDetalle.TabIndex = 14;
            // 
            // dgvDetalles
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Compra,
            this.ID_Producto,
            this.Cantidad,
            this.PrecioUnitario});
            this.dgvDetalles.Location = new System.Drawing.Point(74, 825);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 62;
            this.dgvDetalles.RowTemplate.Height = 30;
            this.dgvDetalles.Size = new System.Drawing.Size(1326, 584);
            this.dgvDetalles.TabIndex = 18;
            // 
            // ID_Compra
            // 
            this.ID_Compra.HeaderText = "ID de Compra";
            this.ID_Compra.MinimumWidth = 8;
            this.ID_Compra.Name = "ID_Compra";
            this.ID_Compra.Width = 150;
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID de Producto";
            this.ID_Producto.MinimumWidth = 8;
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 8;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 150;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2046, 1558);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelCompra);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelCompra.ResumeLayout(false);
            this.panelCompra.PerformLayout();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCompra;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecioDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.TextBox txtNombDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoDetalle;
        private System.Windows.Forms.Button btnCerrarCompra;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
    }
}