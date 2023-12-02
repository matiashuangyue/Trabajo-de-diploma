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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCompra = new FontAwesome.Sharp.IconButton();
            this.btnVenta = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProducto = new FontAwesome.Sharp.IconButton();
            this.btnProveedor = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.btnBaseDeDatos = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.btnBaseDeDatos);
            this.panel2.Controls.Add(this.btnUsuario);
            this.panel2.Controls.Add(this.iconButton4);
            this.panel2.Controls.Add(this.btnProveedor);
            this.panel2.Controls.Add(this.btnProducto);
            this.panel2.Controls.Add(this.btnCompra);
            this.panel2.Controls.Add(this.btnVenta);
            this.panel2.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnCompra
            // 
            resources.ApplyResources(this.btnCompra, "btnCompra");
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCompra.IconColor = System.Drawing.Color.White;
            this.btnCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompra.IconSize = 32;
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // btnVenta
            // 
            resources.ApplyResources(this.btnVenta, "btnVenta");
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btnVenta.IconColor = System.Drawing.Color.White;
            this.btnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenta.IconSize = 32;
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnProducto
            // 
            resources.ApplyResources(this.btnProducto, "btnProducto");
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.btnProducto.IconColor = System.Drawing.Color.White;
            this.btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducto.IconSize = 32;
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnProveedor
            // 
            resources.ApplyResources(this.btnProveedor, "btnProveedor");
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnProveedor.IconColor = System.Drawing.Color.White;
            this.btnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedor.IconSize = 32;
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            resources.ApplyResources(this.iconButton4, "iconButton4");
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            resources.ApplyResources(this.btnUsuario, "btnUsuario");
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuario.IconColor = System.Drawing.Color.White;
            this.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuario.IconSize = 32;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnBaseDeDatos
            // 
            resources.ApplyResources(this.btnBaseDeDatos, "btnBaseDeDatos");
            this.btnBaseDeDatos.FlatAppearance.BorderSize = 0;
            this.btnBaseDeDatos.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnBaseDeDatos.IconColor = System.Drawing.Color.White;
            this.btnBaseDeDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaseDeDatos.IconSize = 32;
            this.btnBaseDeDatos.Name = "btnBaseDeDatos";
            this.btnBaseDeDatos.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCompra;
        private FontAwesome.Sharp.IconButton btnVenta;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnBaseDeDatos;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnProveedor;
        private FontAwesome.Sharp.IconButton btnProducto;
    }
}