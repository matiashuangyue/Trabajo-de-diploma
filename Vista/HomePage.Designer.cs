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
            this.panelInformeSubmenu = new System.Windows.Forms.Panel();
            this.btnVentaRealizada = new System.Windows.Forms.Button();
            this.btnCompraRealizada = new System.Windows.Forms.Button();
            this.btnInforme = new FontAwesome.Sharp.IconButton();
            this.panelControlSubmenu = new System.Windows.Forms.Panel();
            this.btnIngresarStock = new System.Windows.Forms.Button();
            this.btnControlStock = new FontAwesome.Sharp.IconButton();
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
            this.panelMenu.Controls.Add(this.panelInformeSubmenu);
            this.panelMenu.Controls.Add(this.btnInforme);
            this.panelMenu.Controls.Add(this.panelControlSubmenu);
            this.panelMenu.Controls.Add(this.btnControlStock);
            this.panelMenu.Controls.Add(this.panelUsuarioSubmenu);
            this.panelMenu.Controls.Add(this.btnUsuario);
            this.panelMenu.Controls.Add(this.panelProductoSubmenu);
            this.panelMenu.Controls.Add(this.btnProducto);
            this.panelMenu.Controls.Add(this.btnCompra);
            this.panelMenu.Controls.Add(this.btnVenta);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Name = "panelMenu";
            // 
            // panelInformeSubmenu
            // 
            this.panelInformeSubmenu.BackColor = System.Drawing.Color.Azure;
            this.panelInformeSubmenu.Controls.Add(this.btnVentaRealizada);
            this.panelInformeSubmenu.Controls.Add(this.btnCompraRealizada);
            resources.ApplyResources(this.panelInformeSubmenu, "panelInformeSubmenu");
            this.panelInformeSubmenu.Name = "panelInformeSubmenu";
            // 
            // btnVentaRealizada
            // 
            this.btnVentaRealizada.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnVentaRealizada, "btnVentaRealizada");
            this.btnVentaRealizada.FlatAppearance.BorderSize = 0;
            this.btnVentaRealizada.Name = "btnVentaRealizada";
            this.btnVentaRealizada.UseVisualStyleBackColor = false;
            this.btnVentaRealizada.Click += new System.EventHandler(this.btnVentaRealizada_Click);
            // 
            // btnCompraRealizada
            // 
            this.btnCompraRealizada.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnCompraRealizada, "btnCompraRealizada");
            this.btnCompraRealizada.FlatAppearance.BorderSize = 0;
            this.btnCompraRealizada.Name = "btnCompraRealizada";
            this.btnCompraRealizada.UseVisualStyleBackColor = false;
            this.btnCompraRealizada.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnInforme, "btnInforme");
            this.btnInforme.FlatAppearance.BorderSize = 0;
            this.btnInforme.ForeColor = System.Drawing.Color.White;
            this.btnInforme.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnInforme.IconColor = System.Drawing.Color.White;
            this.btnInforme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInforme.IconSize = 32;
            this.btnInforme.Name = "btnInforme";
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
            this.btnIngresarStock.UseVisualStyleBackColor = false;
            this.btnIngresarStock.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnControlStock
            // 
            this.btnControlStock.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnControlStock, "btnControlStock");
            this.btnControlStock.FlatAppearance.BorderSize = 0;
            this.btnControlStock.ForeColor = System.Drawing.Color.White;
            this.btnControlStock.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            this.btnControlStock.IconColor = System.Drawing.Color.White;
            this.btnControlStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnControlStock.IconSize = 32;
            this.btnControlStock.Name = "btnControlStock";
            this.btnControlStock.UseVisualStyleBackColor = false;
            this.btnControlStock.Click += new System.EventHandler(this.btnControlStock_Click);
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
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnAgregarUsuario, "btnAgregarUsuario");
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
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
            this.btnModificacionProducto.UseVisualStyleBackColor = false;
            this.btnModificacionProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnAddProducto, "btnAddProducto");
            this.btnAddProducto.FlatAppearance.BorderSize = 0;
            this.btnAddProducto.Name = "btnAddProducto";
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.lblRol);
            this.panel2.Controls.Add(this.lblTitleChildForm);
            this.panel2.Controls.Add(this.iconCurrentChildForm);
            this.panel2.Controls.Add(this.iconPerfil);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblRol
            // 
            resources.ApplyResources(this.lblRol, "lblRol");
            this.lblRol.Name = "lblRol";
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
            this.iconCurrentChildForm.IconSize = 53;
            resources.ApplyResources(this.iconCurrentChildForm, "iconCurrentChildForm");
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.TabStop = false;
            // 
            // iconPerfil
            // 
            this.iconPerfil.BackColor = System.Drawing.Color.CadetBlue;
            this.iconPerfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPerfil.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconPerfil.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPerfil.IconSize = 65;
            resources.ApplyResources(this.iconPerfil, "iconPerfil");
            this.iconPerfil.Name = "iconPerfil";
            this.iconPerfil.TabStop = false;
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
            this.Name = "HomePage";
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
        private FontAwesome.Sharp.IconButton btnControlStock;
        private System.Windows.Forms.Panel panelInformeSubmenu;
        private System.Windows.Forms.Button btnCompraRealizada;
        private System.Windows.Forms.Button btnVentaRealizada;
    }
}