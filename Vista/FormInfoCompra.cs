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

        private void CargarDatos(int DNI,int Estado)
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
            if (cbEstado.SelectedItem == "Alta")
            {
              Estado = 1;
            }
            else
            {
               Estado = 0;
            }
            cambiarDGV();
        }


        private void cambiarDGV()
        {
            dgvCompras.DataSource = null;
            string NombreVendedor = cbProveedor.SelectedItem.ToString();
            int DNIVendedor = controlUsuario.GetDNI(NombreVendedor);
            int estado = Estado;
            CargarDatos(DNIVendedor,estado);
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void FILTRAR(int DNI, DateTime fechaInicio, DateTime fechaFin)
        {
            // Obtener los pedidos del vendedor dentro del rango de fechas
            DataTable dataTable = controlDGV.ObtenerPedidoPorFecha(DNI, fechaInicio, fechaFin);

            // Suscribir el evento CellFormatting
            dgvCompras.CellFormatting += (sender, e) =>
            {
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Nulo"; // O el valor que desees mostrar para DBNull
                    e.FormattingApplied = true;
                }
            };

            dgvCompras.DataSource = dataTable;
        }

        private void ActualizarDGV()
        {
            string NombreProveedor = cbProveedor.SelectedItem?.ToString();
            if (NombreProveedor != null)
            {
                int DNIProveedor = controlUsuario.GetDNI(NombreProveedor);
                FILTRAR(DNIProveedor, dtpFechaInicio.Value, dtpFechaFin.Value);
            }
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                // Obtiene el ID de la compra, el DNI y el estado de la fila seleccionada
                long IDCompra = Convert.ToInt64(dgvCompras.SelectedRows[0].Cells["ID_Compra"].Value);
                int DNI = Convert.ToInt32(dgvCompras.SelectedRows[0].Cells["DNI_Usuario"].Value);
                int estado = Convert.ToInt32(dgvCompras.SelectedRows[0].Cells["ID_Estado"].Value);

                // Verifica si el estado actual es baja (0) o alta (1)
                if (estado == 0)
                {
                    // Si está en baja, preguntar si quiere dar de alta
                    DialogResult result = MessageBox.Show("¿Está seguro de cambiar el estado de esta compra a alta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario confirma la acción
                    if (result == DialogResult.Yes)
                    {
                        // Cambia el estado a alta (1)
                        estado = 1;
                        controlCompra.CambiarEstadoCompra(IDCompra, estado);
                        MessageBox.Show("La compra ha sido cambiada a estado de alta con éxito!");

                        // Actualiza el ComboBox de estado
                        cbEstado.SelectedItem = "Alta";
                        // Actualiza el DataGridView
                        CargarDatos(DNI, estado);
                    }
                }
                else if (estado == 1)
                {
                    // Si está en alta, preguntar si quiere dar de baja
                    DialogResult result = MessageBox.Show("¿Está seguro de cambiar el estado de esta compra a baja?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario confirma la acción
                    if (result == DialogResult.Yes)
                    {
                        // Cambia el estado a baja (0)
                        estado = 0;
                        controlCompra.CambiarEstadoCompra(IDCompra, estado);
                        MessageBox.Show("La compra ha sido cambiada a estado de baja con éxito!");

                        // Actualiza el ComboBox de estado
                        cbEstado.SelectedItem = "Baja";
                        // Actualiza el DataGridView
                        CargarDatos(DNI, estado);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una compra para cambiar su estado.");
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
