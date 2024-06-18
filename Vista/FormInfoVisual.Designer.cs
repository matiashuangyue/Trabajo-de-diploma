namespace Vista
{
    partial class FormInfoVisual
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInfoVisual = new System.Windows.Forms.Panel();
            this.datePickerFin = new System.Windows.Forms.DateTimePicker();
            this.datePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDownloadInforme = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.panelInfoVisual.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(39, 144);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(893, 546);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(1083, 144);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(842, 546);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(39, 787);
            this.chart3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(893, 419);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(1083, 787);
            this.chart4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(842, 418);
            this.chart4.TabIndex = 2;
            this.chart4.Text = "chart4";
            // 
            // panelInfoVisual
            // 
            this.panelInfoVisual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInfoVisual.Controls.Add(this.btnFiltrar);
            this.panelInfoVisual.Controls.Add(this.datePickerFin);
            this.panelInfoVisual.Controls.Add(this.datePickerInicio);
            this.panelInfoVisual.Controls.Add(this.chart3);
            this.panelInfoVisual.Controls.Add(this.label10);
            this.panelInfoVisual.Controls.Add(this.chart4);
            this.panelInfoVisual.Controls.Add(this.chart2);
            this.panelInfoVisual.Controls.Add(this.btnDownloadInforme);
            this.panelInfoVisual.Controls.Add(this.chart1);
            this.panelInfoVisual.Location = new System.Drawing.Point(12, 13);
            this.panelInfoVisual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelInfoVisual.Name = "panelInfoVisual";
            this.panelInfoVisual.Size = new System.Drawing.Size(2068, 1327);
            this.panelInfoVisual.TabIndex = 21;
            this.panelInfoVisual.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfoVisual_Paint);
            // 
            // datePickerFin
            // 
            this.datePickerFin.Location = new System.Drawing.Point(50, 743);
            this.datePickerFin.Name = "datePickerFin";
            this.datePickerFin.Size = new System.Drawing.Size(371, 28);
            this.datePickerFin.TabIndex = 21;
            // 
            // datePickerInicio
            // 
            this.datePickerInicio.Location = new System.Drawing.Point(50, 709);
            this.datePickerInicio.Name = "datePickerInicio";
            this.datePickerInicio.Size = new System.Drawing.Size(371, 28);
            this.datePickerInicio.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(739, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 47);
            this.label10.TabIndex = 20;
            this.label10.Text = "Informes Visual";
            // 
            // btnDownloadInforme
            // 
            this.btnDownloadInforme.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDownloadInforme.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadInforme.ForeColor = System.Drawing.Color.Black;
            this.btnDownloadInforme.Location = new System.Drawing.Point(1312, 698);
            this.btnDownloadInforme.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownloadInforme.Name = "btnDownloadInforme";
            this.btnDownloadInforme.Size = new System.Drawing.Size(374, 83);
            this.btnDownloadInforme.TabIndex = 18;
            this.btnDownloadInforme.Text = "Download Informe";
            this.btnDownloadInforme.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(558, 696);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(374, 83);
            this.btnFiltrar.TabIndex = 22;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // FormInfoVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2025, 1260);
            this.Controls.Add(this.panelInfoVisual);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInfoVisual";
            this.Text = "Informe Visual";
            this.Load += new System.EventHandler(this.FormInfoVisual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.panelInfoVisual.ResumeLayout(false);
            this.panelInfoVisual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Panel panelInfoVisual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDownloadInforme;
        private System.Windows.Forms.DateTimePicker datePickerFin;
        private System.Windows.Forms.DateTimePicker datePickerInicio;
        private System.Windows.Forms.Button btnFiltrar;
    }
}