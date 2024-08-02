using Controladora;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Controladora.ControlAuditoria;

namespace Vista
{
    public partial class FormInfoVisual : Form
    {
        private int Rol;
        private int DNI;
        private ControlInforme controlInforme = ControlInforme.Instance;
        private ControlAuditoria controlAuditoria = ControlAuditoria.Instance;

        public FormInfoVisual(int dni, int rol)
        {
            InitializeComponent();
            this.Rol = rol;
            this.DNI = dni;

            DateTime fechaInicio = DateTime.Today; // Inicio del día de hoy
            DateTime fechaFin = DateTime.Today.AddDays(1);
            dtpInicio.Value = fechaInicio;
            dtpFinal.Value = fechaFin;
        }

        private void FormInfoVisual_Load(object sender, EventArgs e)
        {
            
            Filtrado();
        }
        private void Filtrado()
        {
            CargarProductoMásVendidosPorFecha();
            CargarVentasPorFechaEnChart();
            CargarMargenesDeGananciaPorFechaEnChart();
            CargarVentasPorVendedorPorFechaEnChart();
        }

        private void CargarVentasPorFechaEnChart()
        {
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFinal.Value.Date;

            Console.WriteLine($"Fecha Inicio: {fechaInicio}, Fecha Fin: {fechaFin}"); // Depuración

            DataTable dataTable = controlInforme.ObtenerVentaPorFecha(fechaInicio, fechaFin);

            Console.WriteLine($"Número de filas obtenidas: {dataTable.Rows.Count}"); // Depuración

            chart3.Series.Clear();
            chart3.Titles.Clear();
            chart3.ChartAreas.Clear();

            // Configura el área del gráfico
            ChartArea chartArea = new ChartArea();
            chart3.ChartAreas.Add(chartArea);

            // Título del gráfico
            chart3.Titles.Add("Ventas por Mes");

            // Configura la serie
            Series series = new Series("Ventas Totales")
            {
                ChartType = SeriesChartType.Line,
                XValueMember = "Mes",
                YValueMembers = "VentasTotales"
            };
            chart3.Series.Add(series);

            // Configura los ejes
            chart3.ChartAreas[0].AxisX.Title = "Mes";
            chart3.ChartAreas[0].AxisY.Title = "Ventas Totales";
            chart3.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rota las etiquetas del eje X para mejor legibilidad
            chart3.ChartAreas[0].AxisX.Interval = 1; // Asegura que todas las etiquetas se muestren
            chart3.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; // Quita las líneas de la cuadrícula principal del eje X
            chart3.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray; // Color de las líneas de la cuadrícula principal del eje Y

            // Rellenar datos en el chart
            chart3.DataSource = dataTable;
            chart3.DataBind();

            // Configura las etiquetas de los puntos de datos
            foreach (DataPoint point in series.Points)
            {
                point.Label = point.YValues[0].ToString();
                point.LabelForeColor = Color.Black;
                point.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            }

            // Opcional: Cambiar el color de las líneas
            series.Color = Color.FromArgb(0, 102, 204); // Color azul oscuro

            // Opcional: Añadir un borde alrededor de las líneas
            series.BorderWidth = 2;
            series.BorderColor = Color.Black;
        }

        private void CargarProductoMásVendidosPorFecha()//Chart1 muestra los productos más vendidos
        {
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFinal.Value.Date;

            DataTable dataTable = controlInforme.ObtenerProductosMasVendidos(fechaInicio, fechaFin);

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();

            // Configura el área del gráfico
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Título del gráfico
            chart1.Titles.Add("Productos Más Vendidos");

            // Configura la serie
            Series series = new Series("Cantidad Vendida")
            {
                ChartType = SeriesChartType.Bar,
                XValueMember = "Nombre",
                YValueMembers = "CantidadTotalVendida"
            };
            chart1.Series.Add(series);

            // Configura los ejes
            chart1.ChartAreas[0].AxisX.Title = "Productos";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad Total Vendida";
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rota las etiquetas del eje X para mejor legibilidad
            chart1.ChartAreas[0].AxisX.Interval = 1; // Asegura que todas las etiquetas se muestren
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; // Quita las líneas de la cuadrícula principal del eje X
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray; // Color de las líneas de la cuadrícula principal del eje Y

            // Rellenar datos en el chart
            chart1.DataSource = dataTable;
            chart1.DataBind();

            // Configura las etiquetas de los puntos de datos
            foreach (DataPoint point in series.Points)
            {
                point.Label = point.YValues[0].ToString();
                point.LabelForeColor = Color.Black;
                point.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            }

            // Opcional: Cambiar el color de las barras
            foreach (DataPoint point in series.Points)
            {
                point.Color = Color.FromArgb(0, 102, 204); // Color azul oscuro
            }

            // Opcional: Añadir un borde alrededor de las barras
            series.BorderWidth = 1;
            series.BorderColor = Color.Black;
        }

        private void CargarVentasPorVendedorPorFechaEnChart()
        {
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFinal.Value.Date;
            DataTable dataTable = controlInforme.ObtenerVentasPorVendedor(fechaInicio,fechaFin);

            chart2.Series.Clear();
            chart2.Titles.Clear();
            chart2.ChartAreas.Clear();

            // Configura el área del gráfico
            ChartArea chartArea = new ChartArea();
            chart2.ChartAreas.Add(chartArea);

            // Título del gráfico
            chart2.Titles.Add("Ventas por Vendedor");

            // Configura la serie
            Series series = new Series("Ventas Totales")
            {
                ChartType = SeriesChartType.Bar,
                XValueMember = "Nombre",
                YValueMembers = "VentasTotales"
            };
            chart2.Series.Add(series);

            // Configura los ejes
            chart2.ChartAreas[0].AxisX.Title = "Vendedor";
            chart2.ChartAreas[0].AxisY.Title = "Ventas Totales";
            chart2.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rota las etiquetas del eje X para mejor legibilidad
            chart2.ChartAreas[0].AxisX.Interval = 1; // Asegura que todas las etiquetas se muestren
            chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; // Quita las líneas de la cuadrícula principal del eje X
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray; // Color de las líneas de la cuadrícula principal del eje Y

            // Rellenar datos en el chart
            chart2.DataSource = dataTable;
            chart2.DataBind();

            // Configura las etiquetas de los puntos de datos
            foreach (DataPoint point in series.Points)
            {
                point.Label = point.YValues[0].ToString();
                point.LabelForeColor = Color.Black;
                point.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            }

            // Opcional: Cambiar el color de las barras
            foreach (DataPoint point in series.Points)
            {
                point.Color = Color.FromArgb(0, 102, 204); // Color azul oscuro
            }

            // Opcional: Añadir un borde alrededor de las barras
            series.BorderWidth = 1;
            series.BorderColor = Color.Black;
        }

        private void CargarMargenesDeGananciaPorFechaEnChart()
        {
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFinal.Value.Date;

            DataTable dataTable = controlInforme.ObtenerMargenesDeGanancia(fechaInicio,fechaFin);

            chart4.Series.Clear();
            chart4.Titles.Clear();
            chart4.ChartAreas.Clear();

            // Configura el área del gráfico
            ChartArea chartArea = new ChartArea();
            chart4.ChartAreas.Add(chartArea);

            // Título del gráfico
            chart4.Titles.Add("Márgenes de Ganancia por Producto");

            // Configura la serie de costos
            Series serieCosto = new Series("Costo")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Nombre",
                YValueMembers = "Costo"
            };
            chart4.Series.Add(serieCosto);

            // Configura la serie de precios de venta promedio
            Series seriePrecioVenta = new Series("Precio Venta Promedio")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Nombre",
                YValueMembers = "PrecioVentaPromedio"
            };
            chart4.Series.Add(seriePrecioVenta);

            // Configura la serie de márgenes de ganancia total
            Series serieGanancia = new Series("Ganancia Total")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Nombre",
                YValueMembers = "GananciaTotal"
            };
            chart4.Series.Add(serieGanancia);

            // Configura los ejes
            chart4.ChartAreas[0].AxisX.Title = "Producto";
            chart4.ChartAreas[0].AxisY.Title = "Valor";
            chart4.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rota las etiquetas del eje X para mejor legibilidad
            chart4.ChartAreas[0].AxisX.Interval = 1; // Asegura que todas las etiquetas se muestren
            chart4.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; // Quita las líneas de la cuadrícula principal del eje X
            chart4.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray; // Color de las líneas de la cuadrícula principal del eje Y

            // Rellenar datos en el chart
            chart4.DataSource = dataTable;
            chart4.DataBind();

            // Configura las etiquetas de los puntos de datos
            foreach (Series series in chart4.Series)
            {
                foreach (DataPoint point in series.Points)
                {
                    point.Label = point.YValues[0].ToString("N2");
                    point.LabelForeColor = Color.Black;
                    point.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                }
            }

            // Opcional: Cambiar el color de las columnas
            serieCosto.Color = Color.FromArgb(204, 0, 0); // Color rojo oscuro
            seriePrecioVenta.Color = Color.FromArgb(0, 102, 204); // Color azul oscuro
            serieGanancia.Color = Color.FromArgb(0, 204, 102); // Color verde oscuro

            // Opcional: Añadir un borde alrededor de las columnas
            foreach (Series series in chart4.Series)
            {
                series.BorderWidth = 1;
                series.BorderColor = Color.Black;
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            // Actualiza el gráfico cuando se cambia la fecha seleccionada
           Filtrado();
        }

        private void panelInfoVisual_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrado();
        }

        private void btnDownloadInforme_Click(object sender, EventArgs e)
        {
            ExportarChartsAPdf();
            controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Exportar Informe");
        }

        private void AgregarChartAPdf(Document document, PdfWriter writer, Chart chart, string titulo)
        {
            document.NewPage();

            // Añadir título
            Paragraph paragraph = new Paragraph(titulo, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD))
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(paragraph);
            document.Add(new Paragraph("\n"));

            // Guardar el chart como imagen
            using (MemoryStream memoryStream = new MemoryStream())
            {
                chart.SaveImage(memoryStream, ChartImageFormat.Png);
                iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
                chartImage.ScaleToFit(document.PageSize.Width - 50, document.PageSize.Height - 100);
                chartImage.Alignment = Element.ALIGN_CENTER;
                document.Add(chartImage);
            }
        }

        private void ExportarChartsAPdf()
        {
            string nombreArchivo = "InformeVisual_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".pdf";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Guardar Informe como PDF",
                FileName = nombreArchivo
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Añadir el contenido de los gráficos al PDF
                AgregarChartAPdf(document, writer, chart1, "Productos Más Vendidos");
                AgregarChartAPdf(document, writer, chart2, "Ventas por Vendedor");
                AgregarChartAPdf(document, writer, chart3, "Ventas por Fecha");
                AgregarChartAPdf(document, writer, chart4, "Márgenes de Ganancia");

                document.Close();

                MessageBox.Show("Informe guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void datePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            Filtrado();
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            Filtrado();
        }
    }
}
