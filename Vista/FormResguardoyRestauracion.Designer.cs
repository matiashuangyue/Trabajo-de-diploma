namespace Vista
{
    partial class FormResguardoyRestauracion
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
            this.panelResguardoyRestauracion = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnResguardo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panelResguardoyRestauracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResguardoyRestauracion
            // 
            this.panelResguardoyRestauracion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResguardoyRestauracion.Controls.Add(this.button1);
            this.panelResguardoyRestauracion.Controls.Add(this.txtArchivo);
            this.panelResguardoyRestauracion.Controls.Add(this.txtRuta);
            this.panelResguardoyRestauracion.Controls.Add(this.btnRuta);
            this.panelResguardoyRestauracion.Controls.Add(this.label4);
            this.panelResguardoyRestauracion.Controls.Add(this.btnRestaurar);
            this.panelResguardoyRestauracion.Controls.Add(this.label3);
            this.panelResguardoyRestauracion.Controls.Add(this.label2);
            this.panelResguardoyRestauracion.Controls.Add(this.label1);
            this.panelResguardoyRestauracion.Controls.Add(this.label10);
            this.panelResguardoyRestauracion.Controls.Add(this.btnResguardo);
            this.panelResguardoyRestauracion.Location = new System.Drawing.Point(10, 10);
            this.panelResguardoyRestauracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelResguardoyRestauracion.Name = "panelResguardoyRestauracion";
            this.panelResguardoyRestauracion.Size = new System.Drawing.Size(1378, 885);
            this.panelResguardoyRestauracion.TabIndex = 21;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRestaurar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.Black;
            this.btnRestaurar.Location = new System.Drawing.Point(564, 651);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(298, 72);
            this.btnRestaurar.TabIndex = 24;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Restaurar datas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Resguardo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Seleccionar Archivo (*.bak)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(451, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(411, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "RESGUARDO Y RESTAURACION";
            // 
            // btnResguardo
            // 
            this.btnResguardo.BackColor = System.Drawing.Color.Cornsilk;
            this.btnResguardo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResguardo.ForeColor = System.Drawing.Color.Black;
            this.btnResguardo.Location = new System.Drawing.Point(564, 259);
            this.btnResguardo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResguardo.Name = "btnResguardo";
            this.btnResguardo.Size = new System.Drawing.Size(298, 69);
            this.btnResguardo.TabIndex = 18;
            this.btnResguardo.Text = "Realizar BackUp";
            this.btnResguardo.UseVisualStyleBackColor = false;
            this.btnResguardo.Click += new System.EventHandler(this.btnResguardo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(85, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Selecciona el ruta para realizar el BackUp: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRuta.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuta.ForeColor = System.Drawing.Color.Black;
            this.btnRuta.Location = new System.Drawing.Point(790, 173);
            this.btnRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(343, 55);
            this.btnRuta.TabIndex = 27;
            this.btnRuta.Text = "Seleccionar Ruta";
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.Cornsilk;
            this.txtRuta.Enabled = false;
            this.txtRuta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(278, 188);
            this.txtRuta.Multiline = true;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(466, 29);
            this.txtRuta.TabIndex = 28;
            // 
            // txtArchivo
            // 
            this.txtArchivo.BackColor = System.Drawing.Color.Cornsilk;
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo.Location = new System.Drawing.Point(278, 546);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(466, 29);
            this.txtArchivo.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "SQL SERVER Database Backup Files (*.bak)|*.bak";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(790, 531);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 55);
            this.button1.TabIndex = 30;
            this.button1.Text = "Seleccionar Archivo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormResguardoyRestauracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 849);
            this.Controls.Add(this.panelResguardoyRestauracion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormResguardoyRestauracion";
            this.Text = "FormResguardoyRestauracion";
            this.panelResguardoyRestauracion.ResumeLayout(false);
            this.panelResguardoyRestauracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResguardoyRestauracion;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnResguardo;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}