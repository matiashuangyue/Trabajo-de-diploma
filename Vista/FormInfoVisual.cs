using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Vista
{
    public partial class FormInfoVisual : Form
    {
        private int Rol;
        private int DNI;
        private ControlInforme controlInforme;

        public FormInfoVisual(int dni, int rol)
        {
            InitializeComponent();
            this.Rol = rol;
            this.DNI = dni;
            this.controlInforme = new ControlInforme();

            this.datePickerInicio = new DateTimePicker();
            this.datePickerInicio.Format = DateTimePickerFormat.Short;
            this.datePickerInicio.ValueChanged += new EventHandler(this.DatePicker_ValueChanged);
            this.Controls.Add(this.datePickerInicio);

            this.datePickerFin = new DateTimePicker();
            this.datePickerFin.Format = DateTimePickerFormat.Short;
            this.datePickerFin.ValueChanged += new EventHandler(this.DatePicker_ValueChanged);
            this.Controls.Add(this.datePickerFin);
            DateTime fechaEspecifica = new DateTime(2022, 1, 1);
            datePickerInicio.Value = fechaEspecifica;
        }
        private void FormInfoVisual_Load(object sender, EventArgs e)
        {
            CargarProductoMásVendidos();
            CargarVentasPorVendedorEnChart();
            CargarVentasPorFechaEnChart();
        }
 private void CargarVentasPorFechaEnChart()
        {
            DateTime fechaInicio = datePickerInicio.Value.Date;
            DateTime fechaFin = datePickerFin.Value.Date;

            DataTable dataTable = controlInforme.ObtenerVentaPorFecha(fechaInicio, fechaFin);

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
                point.Font = new Font("Arial", 10, FontStyle.Bold);
            }

            // Opcional: Cambiar el color de las líneas
            series.Color = Color.FromArgb(0, 102, 204); // Color azul oscuro

            // Opcional: Añadir un borde alrededor de las líneas
            series.BorderWidth = 2;
            series.BorderColor = Color.Black;
        }

        private void CargarProductoMásVendidos()//Chart1 muestra los productos más vendidos
        {
            DataTable dataTable = controlInforme.ObtenerProductosMasVendidos();

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
                point.Font = new Font("Arial", 10, FontStyle.Bold);
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



        private void CargarVentasPorVendedorEnChart()
        {
            DataTable dataTable = controlInforme.ObtenerVentasPorVendedor();

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
                point.Font = new Font("Arial", 10, FontStyle.Bold);
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




        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            // Actualiza el gráfico cuando se cambia la fecha seleccionada
            CargarVentasPorFechaEnChart();
        }

        private void panelInfoVisual_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
