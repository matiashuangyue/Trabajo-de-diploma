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
using Controladora;

namespace Vista
{
    public partial class FormAuditorias : Form
    {
        private int Rol;
        private int DNI;
        private ControlDGV controlDGV = new ControlDGV();
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
            dgvAuditoria.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            dgvDetallesAuditoria.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
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
    }
}
