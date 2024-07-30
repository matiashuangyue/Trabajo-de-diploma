namespace Vista
{
    partial class FormAuditorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAuditoria = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDetallesAuditoria = new System.Windows.Forms.DataGridView();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.btnDescargarInformeAuditoria = new System.Windows.Forms.Button();
            this.panelAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesAuditoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAuditoria
            // 
            this.panelAuditoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAuditoria.Controls.Add(this.label3);
            this.panelAuditoria.Controls.Add(this.dgvDetallesAuditoria);
            this.panelAuditoria.Controls.Add(this.dtpFechaFin);
            this.panelAuditoria.Controls.Add(this.dtpFechaInicio);
            this.panelAuditoria.Controls.Add(this.label4);
            this.panelAuditoria.Controls.Add(this.label2);
            this.panelAuditoria.Controls.Add(this.label1);
            this.panelAuditoria.Controls.Add(this.label10);
            this.panelAuditoria.Controls.Add(this.dgvAuditoria);
            this.panelAuditoria.Controls.Add(this.btnDescargarInformeAuditoria);
            this.panelAuditoria.Location = new System.Drawing.Point(28, 31);
            this.panelAuditoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAuditoria.Name = "panelAuditoria";
            this.panelAuditoria.Size = new System.Drawing.Size(2068, 1327);
            this.panelAuditoria.TabIndex = 20;
            this.panelAuditoria.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAuditoria_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 619);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Detalles";
            // 
            // dgvDetallesAuditoria
            // 
            this.dgvDetallesAuditoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetallesAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetallesAuditoria.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetallesAuditoria.Enabled = false;
            this.dgvDetallesAuditoria.GridColor = System.Drawing.Color.Black;
            this.dgvDetallesAuditoria.Location = new System.Drawing.Point(39, 674);
            this.dgvDetallesAuditoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetallesAuditoria.Name = "dgvDetallesAuditoria";
            this.dgvDetallesAuditoria.RowHeadersWidth = 51;
            this.dgvDetallesAuditoria.RowTemplate.Height = 27;
            this.dgvDetallesAuditoria.Size = new System.Drawing.Size(1848, 321);
            this.dgvDetallesAuditoria.TabIndex = 26;
            this.dgvDetallesAuditoria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetallesAuditoria_CellFormatting);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(1341, 167);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(546, 37);
            this.dtpFechaFin.TabIndex = 24;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(1341, 97);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(546, 37);
            this.dtpFechaInicio.TabIndex = 25;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 4, 8, 20, 25, 35, 0);
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1071, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 34);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hasta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(886, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha Inicio DESDE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Login and LogOut(Haga Click Para Ver Detalles)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(851, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 47);
            this.label10.TabIndex = 20;
            this.label10.Text = "Auditorías";
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuditoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuditoria.GridColor = System.Drawing.Color.Black;
            this.dgvAuditoria.Location = new System.Drawing.Point(39, 280);
            this.dgvAuditoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 51;
            this.dgvAuditoria.RowTemplate.Height = 27;
            this.dgvAuditoria.Size = new System.Drawing.Size(1848, 321);
            this.dgvAuditoria.TabIndex = 19;
            this.dgvAuditoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellClick);
            this.dgvAuditoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellContentClick);
            this.dgvAuditoria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAuditoria_CellFormatting);
            // 
            // btnDescargarInformeAuditoria
            // 
            this.btnDescargarInformeAuditoria.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDescargarInformeAuditoria.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarInformeAuditoria.ForeColor = System.Drawing.Color.Black;
            this.btnDescargarInformeAuditoria.Location = new System.Drawing.Point(1410, 1003);
            this.btnDescargarInformeAuditoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargarInformeAuditoria.Name = "btnDescargarInformeAuditoria";
            this.btnDescargarInformeAuditoria.Size = new System.Drawing.Size(477, 202);
            this.btnDescargarInformeAuditoria.TabIndex = 18;
            this.btnDescargarInformeAuditoria.Text = "Descargar Informe Auditorias";
            this.btnDescargarInformeAuditoria.UseVisualStyleBackColor = false;
            this.btnDescargarInformeAuditoria.Click += new System.EventHandler(this.btnDescargarInformeAuditoria_Click);
            // 
            // FormAuditorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2563, 1271);
            this.Controls.Add(this.panelAuditoria);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAuditorias";
            this.Text = "Auditorias";
            this.Load += new System.EventHandler(this.FormAuditorias_Load);
            this.panelAuditoria.ResumeLayout(false);
            this.panelAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesAuditoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAuditoria;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Button btnDescargarInformeAuditoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetallesAuditoria;
        private System.Windows.Forms.Label label3;
    }
}