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
using Entidades;
using System.Data;
using static Controladora.ControlAuditoria;

namespace Vista
{
    public partial class FormInfoCompra : Form
    {
        private int Rol;
        private int DNI;
        private int Estado;
        private ControlDGV controlDGV = new ControlDGV();
        private ControlUsuario controlUsuario = new ControlUsuario();
        private ControlCompra controlCompra = new ControlCompra();

        public FormInfoCompra(int rol, int dNI)
        {
            InitializeComponent();
            CargarNombreCombobox(3);
            this.Rol = rol;
            this.DNI = dNI;
            cbEstado.SelectedItem = "Alta";
            dtpFechaInicio.Value = new DateTime(2020, 1, 1);
        }

        private void CargarNombreCombobox(int IDROL)
        {
            // Llama al método de la controladora para obtener los nombres de los vendedores
            var nombresVendedores = controlDGV.ObtenerNombresVendedores(IDROL);

            // Luego, puedes hacer lo que necesites con la lista de nombres, por ejemplo, cargarlos en un ComboBox
            if (nombresVendedores != null)
            {
                cbProveedor.DataSource = nombresVendedores;
            }
            else
            {
                MessageBox.Show("Error al cargar los nombres de vendedores.");
            }
        }
        private void FormInfoCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeDiplomaDataSet.Compras' Puede moverla o quitarla según sea necesario.
            dgvCompras.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void CargarDatos2(int DNI,int Estado)
        {
            //dgwDetalles.DataSource = controlPedido.ObtenerDetallePedido(detallePediddo);
            DataTable dataTable = controlDGV.ObtenerCompra(DNI,Estado);

            // Suscribir el evento CellFormatting
            dgvCompras.CellFormatting += (sender, e) =>
            {
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Nulo"; // O el valor que desees mostrar para DBNull
                    e.FormattingApplied = true;
                }
            };
            if (dataTable.Rows.Count > 0)
            {
                dgvCompras.DataSource = dataTable;
            }
            
            // dgvCompras.DataSource = dataTable;
        }

        private void CargarDatos(int DNI, int Estado, DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            DataTable dataTable;
            if (fechaInicio.HasValue && fechaFin.HasValue)
            {
                dataTable = controlDGV.ObtenerCompraPorFechaYEstado(DNI, fechaInicio.Value, fechaFin.Value, Estado);
            }
            else
            {
                dataTable = controlDGV.ObtenerCompra(DNI, Estado);
            }

            dgvCompras.CellFormatting += (sender, e) =>
            {
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Nulo";
                    e.FormattingApplied = true;
                }
            };

            dgvCompras.DataSource = dataTable;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambiarDGV();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estado = cbEstado.SelectedItem.ToString() == "Alta" ? 1 : 0;
            cambiarDGV();
        }


        private void cambiarDGV()
        {
            dgvCompras.DataSource = null;
            string NombreVendedor = cbProveedor.SelectedItem?.ToString();
            if (NombreVendedor != null)
            {
                int DNIVendedor = controlUsuario.GetDNI(NombreVendedor);
                FILTRAR(DNIVendedor, dtpFechaInicio.Value, dtpFechaFin.Value, Estado);
            }
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void FILTRAR(int DNI, DateTime fechaInicio, DateTime fechaFin, int estado)
        {
            CargarDatos(DNI, estado, fechaInicio, fechaFin);
        }

      
        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                long IDCompra = Convert.ToInt64(dgvCompras.SelectedRows[0].Cells["ID_Compra"].Value);
                int DNI = Convert.ToInt32(dgvCompras.SelectedRows[0].Cells["DNI_Usuario"].Value);
                int estado = Convert.ToInt32(dgvCompras.SelectedRows[0].Cells["ID_Estado"].Value);

                DialogResult result = MessageBox.Show(estado == 0 ?
                    "¿Está seguro de cambiar el estado de esta compra a alta?" :
                    "¿Está seguro de cambiar el estado de esta compra a baja?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    estado = estado == 0 ? 1 : 0;
                    controlCompra.CambiarEstadoCompra(IDCompra, estado);
                    MessageBox.Show(estado == 0 ? "La compra ha sido cambiada a estado de baja con éxito!" :
                        "La compra ha sido cambiada a estado de alta con éxito!");
                    
                    ControlAuditoria controlAuditoria = new ControlAuditoria();
                    controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Ver Informe");

                    cbEstado.SelectedItem = estado == 0 ? "Baja" : "Alta";
                    CargarDatos(DNI, estado);
                    cambiarDGV();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una compra para cambiar su estado.");
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            cambiarDGV();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            cambiarDGV();
        }
    }
}
