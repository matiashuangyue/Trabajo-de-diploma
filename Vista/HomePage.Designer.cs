namespace Vista
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnGestionarPermisos = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSession = new FontAwesome.Sharp.IconButton();
            this.panelInformeSubmenu = new System.Windows.Forms.Panel();
            this.btnInformeVisual = new System.Windows.Forms.Button();
            this.btnVentaRealizada = new System.Windows.Forms.Button();
            this.btnCompraRealizada = new System.Windows.Forms.Button();
            this.btnInforme = new FontAwesome.Sharp.IconButton();
            this.panelControlSubmenu = new System.Windows.Forms.Panel();
            this.btnIngresarStock = new System.Windows.Forms.Button();
            this.btnControlCaja = new FontAwesome.Sharp.IconButton();
            this.panelUsuarioSubmenu = new System.Windows.Forms.Panel();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.panelProductoSubmenu = new System.Windows.Forms.Panel();
            this.btnModificacionProducto = new System.Windows.Forms.Button();
            this.btnAddProducto = new System.Windows.Forms.Button();
            this.btnProducto = new FontAwesome.Sharp.IconButton();
            this.btnCompra = new FontAwesome.Sharp.IconButton();
            this.btnVenta = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.iconPerfil = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelInformeSubmenu.SuspendLayout();
            this.panelControlSubmenu.SuspendLayout();
            this.panelUsuarioSubmenu.SuspendLayout();
            this.panelProductoSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnGestionarPermisos);
            this.panelMenu.Controls.Add(this.btnCerrarSession);
            this.panelMenu.Controls.Add(this.panelInformeSubmenu);
            this.panelMenu.Controls.Add(this.btnInforme);
            this.panelMenu.Controls.Add(this.panelControlSubmenu);
            this.panelMenu.Controls.Add(this.btnControlCaja);
            this.panelMenu.Controls.Add(this.panelUsuarioSubmenu);
            this.panelMenu.Controls.Add(this.btnUsuario);
            this.panelMenu.Controls.Add(this.panelProductoSubmenu);
            this.panelMenu.Controls.Add(this.btnProducto);
            this.panelMenu.Controls.Add(this.btnCompra);
            this.panelMenu.Controls.Add(this.btnVenta);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Name = "panelMenu";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.iconButton2, "iconButton2");
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Tag = "Resguardo y Restauracion";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.iconButton1, "iconButton1");
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Tag = "Gestionar Auditorias";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnGestionarPermisos
            // 
            this.btnGestionarPermisos.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnGestionarPermisos, "btnGestionarPermisos");
            this.btnGestionarPermisos.FlatAppearance.BorderSize = 0;
            this.btnGestionarPermisos.ForeColor = System.Drawing.Color.White;
            this.btnGestionarPermisos.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnGestionarPermisos.IconColor = System.Drawing.Color.White;
            this.btnGestionarPermisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionarPermisos.IconSize = 32;
            this.btnGestionarPermisos.Name = "btnGestionarPermisos";
            this.btnGestionarPermisos.Tag = "Gestionar Permisos";
            this.btnGestionarPermisos.UseVisualStyleBackColor = false;
            this.btnGestionarPermisos.Click += new System.EventHandler(this.btnGestionarPermisos_Click);
            // 
            // btnCerrarSession
            // 
            this.btnCerrarSession.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCerrarSession.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCerrarSession, "btnCerrarSession");
            this.btnCerrarSession.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSession.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnCerrarSession.IconColor = System.Drawing.Color.White;
            this.btnCerrarSession.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSession.IconSize = 32;
            this.btnCerrarSession.Name = "btnCerrarSession";
            this.btnCerrarSession.UseVisualStyleBackColor = false;
            this.btnCerrarSession.Click += new System.EventHandler(this.btnCerrarSession_Click);
            // 
            // panelInformeSubmenu
            // 
            this.panelInformeSubmenu.BackColor = System.Drawing.Color.Azure;
            this.panelInformeSubmenu.Controls.Add(this.btnInformeVisual);
            this.panelInformeSubmenu.Controls.Add(this.btnVentaRealizada);
            this.panelInformeSubmenu.Controls.Add(this.btnCompraRealizada);
            resources.ApplyResources(this.panelInformeSubmenu, "panelInformeSubmenu");
            this.panelInformeSubmenu.Name = "panelInformeSubmenu";
            // 
            // btnInformeVisual
            // 
            this.btnInformeVisual.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnInformeVisual, "btnInformeVisual");
            this.btnInformeVisual.FlatAppearance.BorderSize = 0;
            this.btnInformeVisual.Name = "btnInformeVisual";
            this.btnInformeVisual.Tag = "Ver Informe";
            this.btnInformeVisual.UseVisualStyleBackColor = false;
            this.btnInformeVisual.Click += new System.EventHandler(this.btnInformeVisual_Click);
            // 
            // btnVentaRealizada
            // 
            this.btnVentaRealizada.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnVentaRealizada, "btnVentaRealizada");
            this.btnVentaRealizada.FlatAppearance.BorderSize = 0;
            this.btnVentaRealizada.Name = "btnVentaRealizada";
            this.btnVentaRealizada.Tag = "Ver Informe";
            this.btnVentaRealizada.UseVisualStyleBackColor = false;
            this.btnVentaRealizada.Click += new System.EventHandler(this.btnVentaRealizada_Click);
            // 
            // btnCompraRealizada
            // 
            this.btnCompraRealizada.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnCompraRealizada, "btnCompraRealizada");
            this.btnCompraRealizada.FlatAppearance.BorderSize = 0;
            this.btnCompraRealizada.Name = "btnCompraRealizada";
            this.btnCompraRealizada.Tag = "Ver Informe";
            this.btnCompraRealizada.UseVisualStyleBackColor = false;
            this.btnCompraRealizada.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnInforme, "btnInforme");
            this.btnInforme.FlatAppearance.BorderSize = 0;
            this.btnInforme.ForeColor = System.Drawing.Color.White;
            this.btnInforme.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnInforme.IconColor = System.Drawing.Color.White;
            this.btnInforme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInforme.IconSize = 32;
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Tag = "Ver Informe";
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // panelControlSubmenu
            // 
            this.panelControlSubmenu.BackColor = System.Drawing.Color.Azure;
            this.panelControlSubmenu.Controls.Add(this.btnIngresarStock);
            resources.ApplyResources(this.panelControlSubmenu, "panelControlSubmenu");
            this.panelControlSubmenu.Name = "panelControlSubmenu";
            // 
            // btnIngresarStock
            // 
            this.btnIngresarStock.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnIngresarStock, "btnIngresarStock");
            this.btnIngresarStock.FlatAppearance.BorderSize = 0;
            this.btnIngresarStock.Name = "btnIngresarStock";
            this.btnIngresarStock.Tag = "Controlar Caja";
            this.btnIngresarStock.UseVisualStyleBackColor = false;
            this.btnIngresarStock.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnControlCaja
            // 
            this.btnControlCaja.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnControlCaja, "btnControlCaja");
            this.btnControlCaja.FlatAppearance.BorderSize = 0;
            this.btnControlCaja.ForeColor = System.Drawing.Color.White;
            this.btnControlCaja.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            this.btnControlCaja.IconColor = System.Drawing.Color.White;
            this.btnControlCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnControlCaja.IconSize = 32;
            this.btnControlCaja.Name = "btnControlCaja";
            this.btnControlCaja.Tag = "Controlar Caja";
            this.btnControlCaja.UseVisualStyleBackColor = false;
            this.btnControlCaja.Click += new System.EventHandler(this.btnControlStock_Click);
            // 
            // panelUsuarioSubmenu
            // 
            this.panelUsuarioSubmenu.BackColor = System.Drawing.Color.Azure;
            this.panelUsuarioSubmenu.Controls.Add(this.btnModificarUsuario);
            this.panelUsuarioSubmenu.Controls.Add(this.btnAgregarUsuario);
            resources.ApplyResources(this.panelUsuarioSubmenu, "panelUsuarioSubmenu");
            this.panelUsuarioSubmenu.Name = "panelUsuarioSubmenu";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnModificarUsuario, "btnModificarUsuario");
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Tag = "Gestionar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnAgregarUsuario, "btnAgregarUsuario");
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Tag = "Gestionar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnUsuario, "btnUsuario");
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuario.IconColor = System.Drawing.Color.White;
            this.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuario.IconSize = 32;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Tag = "Gestionar Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click_1);
            // 
            // panelProductoSubmenu
            // 
            this.panelProductoSubmenu.BackColor = System.Drawing.Color.Azure;
            this.panelProductoSubmenu.Controls.Add(this.btnModificacionProducto);
            this.panelProductoSubmenu.Controls.Add(this.btnAddProducto);
            resources.ApplyResources(this.panelProductoSubmenu, "panelProductoSubmenu");
            this.panelProductoSubmenu.Name = "panelProductoSubmenu";
            // 
            // btnModificacionProducto
            // 
            this.btnModificacionProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnModificacionProducto, "btnModificacionProducto");
            this.btnModificacionProducto.FlatAppearance.BorderSize = 0;
            this.btnModificacionProducto.Name = "btnModificacionProducto";
            this.btnModificacionProducto.Tag = "Gestionar Producto";
            this.btnModificacionProducto.UseVisualStyleBackColor = false;
            this.btnModificacionProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnAddProducto, "btnAddProducto");
            this.btnAddProducto.FlatAppearance.BorderSize = 0;
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.Tag = "Gestionar Producto";
            this.btnAddProducto.UseVisualStyleBackColor = false;
            this.btnAddProducto.Click += new System.EventHandler(this.btnAddProducto_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnProducto, "btnProducto");
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.btnProducto.IconColor = System.Drawing.Color.White;
            this.btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducto.IconSize = 32;
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Tag = "Gestionar Producto";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnCompra, "btnCompra");
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.ForeColor = System.Drawing.Color.White;
            this.btnCompra.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCompra.IconColor = System.Drawing.Color.White;
            this.btnCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompra.IconSize = 32;
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Tag = "Compra";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnVenta, "btnVenta");
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btnVenta.IconColor = System.Drawing.Color.White;
            this.btnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenta.IconSize = 32;
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Tag = "Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Vista.Properties.Resources.Star_CG1;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Name = "btnHome";
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblRol);
            this.panel2.Controls.Add(this.lblTitleChildForm);
            this.panel2.Controls.Add(this.iconCurrentChildForm);
            this.panel2.Controls.Add(this.iconPerfil);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblRol
            // 
            resources.ApplyResources(this.lblRol, "lblRol");
            this.lblRol.Name = "lblRol";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // lblTitleChildForm
            // 
            resources.ApplyResources(this.lblTitleChildForm, "lblTitleChildForm");
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.CadetBlue;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 64;
            resources.ApplyResources(this.iconCurrentChildForm, "iconCurrentChildForm");
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.TabStop = false;
            // 
            // iconPerfil
            // 
            this.iconPerfil.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.iconPerfil, "iconPerfil");
            this.iconPerfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPerfil.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconPerfil.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPerfil.IconSize = 96;
            this.iconPerfil.Name = "iconPerfil";
            this.iconPerfil.TabStop = false;
            this.iconPerfil.Click += new System.EventHandler(this.iconPerfil_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDesktop.Controls.Add(this.panel1);
            resources.ApplyResources(this.panelDesktop, "panelDesktop");
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // HomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelInformeSubmenu.ResumeLayout(false);
            this.panelControlSubmenu.ResumeLayout(false);
            this.panelUsuarioSubmenu.ResumeLayout(false);
            this.panelProductoSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnCompra;
        private FontAwesome.Sharp.IconButton btnVenta;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPerfil;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Panel panelProductoSubmenu;
        private System.Windows.Forms.Panel panelUsuarioSubmenu;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private System.Windows.Forms.Button btnModificacionProducto;
        private System.Windows.Forms.Button btnAddProducto;
        private FontAwesome.Sharp.IconButton btnInforme;
        private System.Windows.Forms.Panel panelControlSubmenu;
        private System.Windows.Forms.Button btnIngresarStock;
        private FontAwesome.Sharp.IconButton btnControlCaja;
        private System.Windows.Forms.Panel panelInformeSubmenu;
        private System.Windows.Forms.Button btnCompraRealizada;
        private System.Windows.Forms.Button btnVentaRealizada;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCerrarSession;
        private FontAwesome.Sharp.IconButton btnGestionarPermisos;
        private System.Windows.Forms.Button btnInformeVisual;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}