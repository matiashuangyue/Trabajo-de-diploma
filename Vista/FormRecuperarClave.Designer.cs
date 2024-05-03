namespace Vista
{
    partial class FormRecuperarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecuperarClave));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSolicitarCodigo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 61);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 15;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(137, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDNI.Location = new System.Drawing.Point(378, 44);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Multiline = true;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(470, 35);
            this.txtDNI.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(195, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(195, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 34);
            this.label10.TabIndex = 9;
            this.label10.Text = "DNI";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Cornsilk;
            this.txtMail.Location = new System.Drawing.Point(378, 103);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(470, 35);
            this.txtMail.TabIndex = 8;
            // 
            // btnSolicitarCodigo
            // 
            this.btnSolicitarCodigo.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSolicitarCodigo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarCodigo.ForeColor = System.Drawing.Color.Black;
            this.btnSolicitarCodigo.Location = new System.Drawing.Point(498, 194);
            this.btnSolicitarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSolicitarCodigo.Name = "btnSolicitarCodigo";
            this.btnSolicitarCodigo.Size = new System.Drawing.Size(350, 107);
            this.btnSolicitarCodigo.TabIndex = 12;
            this.btnSolicitarCodigo.Text = "Solicitar Codigo De Verificacion";
            this.btnSolicitarCodigo.UseVisualStyleBackColor = false;
            this.btnSolicitarCodigo.Click += new System.EventHandler(this.btnSolicitarCodigo_Click);
            // 
            // FormRecuperarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.btnSolicitarCodigo);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRecuperarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProveedor";
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSolicitarCodigo;
    }
}