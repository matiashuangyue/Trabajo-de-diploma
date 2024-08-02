using Controladora;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static Controladora.ControlAuditoria;

namespace Vista
{
    public partial class FormAuditorias : Form
    {
        private int Rol;
        private int DNI;
        private ControlDGV controlDGV = new ControlDGV();
        private ControlAuditoria controlAuditoria = ControlAuditoria.Instance;
        public FormAuditorias(int dni, int rol)
        {
            InitializeComponent();
            this.Rol = rol;
            this.DNI = dni;
        }

        private void Actualizar(DateTime fechaInicio, DateTime fechaFin)
        {
            // Obtener los pedidos del vendedor dentro del rango de fechas
            DataTable dataTable = controlDGV.ObtenrInfoAuditoriaPorFecha(fechaInicio, fechaFin);

            // Suscribir el evento CellFormatting
            dgvAuditoria.CellFormatting += (sender, e) =>
            {
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Nulo"; // O el valor que desees mostrar para DBNull
                    e.FormattingApplied = true;
                }
            };

            dgvAuditoria.DataSource = dataTable;
        }

        private void CargarDetallesAuditoria(string auditoriaID)
        {
            ControlDGV controlDGV = new ControlDGV();
            DataTable dataTable = controlDGV.ObtenerDetallesAuditoria(auditoriaID);
            dgvDetallesAuditoria.DataSource = dataTable;
        }



        private void FormAuditorias_Load(object sender, EventArgs e)
        {
           AjustarDGV();
            dtpFechaInicio.Value = new DateTime(2020, 1, 1);
        }

        private void AjustarDGV()
        {
            dgvAuditoria.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            dgvAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            dgvDetallesAuditoria.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            dgvDetallesAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void panelAuditoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            Actualizar(dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            Actualizar(dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void dgvAuditoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                // Establecer el color del texto en las celdas de encabezado a negro
                e.CellStyle.ForeColor = Color.Black;
            }
            else
            {
                // Establecer el color del texto en las celdas de datos a negro
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAuditoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAuditoria.Rows[e.RowIndex];
                string auditoriaID = row.Cells["ID"].Value.ToString(); // Asegúrate de que el nombre de la columna sea "ID"

                // Llama a un método para cargar los detalles usando el auditoriaID
                CargarDetallesAuditoria(auditoriaID);
            }
        }

        private void dgvDetallesAuditoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                // Establecer el color del texto en las celdas de encabezado a negro
                e.CellStyle.ForeColor = Color.Black;
            }
            else
            {
                // Establecer el color del texto en las celdas de datos a negro
                e.CellStyle.ForeColor = Color.Black;
            }
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

        private void ExportarDGVsAPdf()
        {
            string nombreArchivoPredeterminado = $"Informe Auditoria {dtpFechaInicio.Value:yyyy-MM-dd} a {dtpFechaFin.Value:yyyy-MM-dd}.pdf";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Guardar Informe de Auditoría como PDF",
                FileName = nombreArchivoPredeterminado
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Añadir título
                Paragraph paragraph = new Paragraph("Informe de Auditoría", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD))
                {
                    Alignment = Element.ALIGN_CENTER
                };
                document.Add(paragraph);
                document.Add(new Paragraph("\n"));

                // Añadir DataGridView de Auditoria
                AgregarDGVAPdf(document, dgvAuditoria, "Auditorías");

                // Añadir DataGridView de Detalles Auditoria
                AgregarDGVAPdf(document, dgvDetallesAuditoria, "Detalles de Auditoría");

                document.Close();

                MessageBox.Show("Informe guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDescargarInformeAuditoria_Click(object sender, EventArgs e)
        {
            ExportarDGVsAPdf();
            controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Exportar Informe");
        }
    }
}
