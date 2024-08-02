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
using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using static Controladora.ControlAuditoria;


namespace Vista
{
    public partial class FormControlCaja : Form
    {
        private int RoleID;
        private int UserDNI;

        private ControlDGV controlDGV = new ControlDGV(); 
        private ControlUsuario controlUsuario = ControlUsuario.Instance;
        public FormControlCaja(int RoleID,int UserDNI)
        {
            InitializeComponent();
            this.RoleID = RoleID;
            this.UserDNI = UserDNI;
            CargarNombreCombobox();

            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;

            dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            dtpFechaFinal.CustomFormat = "dd/MM/yyyy";

            dtpHoraInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);

            dtpHoraFinal.Value = DateTime.Now;

        }

        private void FormControlStock_Load(object sender, EventArgs e)
        {
            OrdenarDGV();
            CargarNombreCombobox();
        }

        private void CargarNombreCombobox()
        {
            var nombresEmpleados = controlDGV.ObtenerNombresVendedores(2);
            var nombresAdmin = controlDGV.ObtenerNombresVendedores(1);
            var nombresVendedores = nombresAdmin.Concat(nombresEmpleados).ToList();
            if (nombresVendedores != null)
            {
                cbVendedores.DataSource = nombresVendedores;
            }
            else
            {
                MessageBox.Show("Error al cargar los nombres de vendedores.");
            }
        }



        private void OrdenarDGV()
        {
            dgvTipoComprobante.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            dgvTipoComprobante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoComprobante.ForeColor = Color.Black;


            dgvMediosCobros.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            dgvMediosCobros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMediosCobros.ForeColor = Color.Black;
        }

        private void AplicarFiltros()
        {

            string NombreVendedor = cbVendedores.SelectedItem.ToString();
            int DNIVendedor = controlUsuario.GetDNI(NombreVendedor);

            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime horaInicio = dtpHoraInicio.Value;
            DateTime fechaHoraInicio = fechaInicio.Add(horaInicio.TimeOfDay);

            DateTime fechaFin = dtpFechaFinal.Value;
            DateTime horaFin = dtpHoraFinal.Value;
            DateTime fechaHoraFin = fechaFin.Add(horaFin.TimeOfDay);

           

            var dtTiposDeComprobanteFiltrados = controlDGV.ObtenerTiposDeComprobante(DNIVendedor, fechaHoraInicio, fechaHoraFin);
            dgvTipoComprobante.DataSource = dtTiposDeComprobanteFiltrados;

            var dtMetodosDeCobroFiltrados = controlDGV.ObtenerMetodosDeCobro(DNIVendedor, fechaHoraInicio, fechaHoraFin);
            dgvMediosCobros.DataSource = dtMetodosDeCobroFiltrados;

            calcularTotal(dgvMediosCobros);
        }

        private void calcularTotal(DataGridView dgv)
        {
            decimal cantidad = 0;
            decimal totalImporte = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                cantidad += Convert.ToDecimal(row.Cells[1].Value);
                totalImporte += Convert.ToDecimal(row.Cells[2].Value);
            }
           
            lblCantidad.Text ="Cantidad:"+ cantidad.ToString();
            lblTotal.Text = "$" + totalImporte.ToString("F2");
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ExportarDGVsAPdf(lblCantidad.Text, lblTotal.Text);
            ControlAuditoria controlAuditoria = new ControlAuditoria();
            controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, UserDNI, "Exportar Informe");
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void dtpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void dtpHoraFinal_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }


        private void AgregarDGVAPdf(Document document, DataGridView dgv, string titulo)
        {
            document.NewPage();

            // Añadir título
            Paragraph paragraph = new Paragraph(titulo, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD))
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(paragraph);
            document.Add(new Paragraph("\n"));

            // Crear tabla PDF
            if (dgv.ColumnCount > 0)
            {
                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount)
                {
                    WidthPercentage = 100
                };

                // Añadir encabezados
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    pdfTable.AddCell(cell);
                }

                // Añadir filas
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string cellValue = cell.Value == null ? "Nulo" : cell.Value.ToString();
                        pdfTable.AddCell(new PdfPCell(new Phrase(cellValue, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)))
                        {
                            HorizontalAlignment = Element.ALIGN_CENTER
                        });
                    }
                }

                document.Add(pdfTable);
            }
            else
            {
                document.Add(new Paragraph("No hay datos para mostrar.", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12)));
            }

        }

        private void ExportarDGVsAPdf(string cantidad, string total)
        {
            string nombreArchivoPredeterminado = $"Informe Control Caja {dtpFechaInicio.Value:yyyy-MM-dd} a {dtpFechaFinal.Value:yyyy-MM-dd}.pdf";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Guardar Informe de Control Caja como PDF",
                FileName = nombreArchivoPredeterminado
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Añadir título
                Paragraph paragraph = new Paragraph("Informe de Control Caja", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD))
                {
                    Alignment = Element.ALIGN_CENTER
                };
                document.Add(paragraph);
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("Resumen:", new iTextSharp.text.Font(iTextSharp.text.FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.BOLD))));
                float cantidadFloat;
                if (float.TryParse(cantidad.Replace("Cantidad:", ""), out cantidadFloat))
                {
                    document.Add(new Paragraph("Cantidad Venta: " + cantidadFloat.ToString(), new iTextSharp.text.Font(iTextSharp.text.FontFactory.GetFont("Helvetica", 12))));
                }

                float totalFloat;
                if (float.TryParse(total.Replace("$", ""), out totalFloat))
                {
                    document.Add(new Paragraph("Importe Total: $" + totalFloat.ToString("F2"), new iTextSharp.text.Font(iTextSharp.text.FontFactory.GetFont("Helvetica", 12))));
                }
              

                // Añadir DataGridView de Auditoria
                AgregarDGVAPdf(document, dgvTipoComprobante, "Tipos de Comprobantes");

                // Añadir DataGridView de Detalles Auditoria
                AgregarDGVAPdf(document, dgvMediosCobros, "Medios de Cobros");
                document.Add(new Paragraph("\n"));

                document.Close();

                MessageBox.Show("Informe guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
