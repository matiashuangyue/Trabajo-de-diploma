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
    public partial class FormInfoVenta : Form
    {
        private int Rol;
        private int DNIRol;

        private ControlDGV controlDGV =new ControlDGV();
        private ControlUsuario controlUsuario = new ControlUsuario();
        public FormInfoVenta(int Rol,int DNI)
        {
            InitializeComponent();
            CargarNombreCombobox(2);
            this.Rol = Rol;
            this.DNIRol = DNI;
        }
        private void CargarNombreCombobox(int IDROL)
        {
            // Llama al método de la controladora para obtener los nombres de los vendedores
            var nombresVendedores = controlDGV.ObtenerNombresVendedores(IDROL);

            // Luego, puedes hacer lo que necesites con la lista de nombres, por ejemplo, cargarlos en un ComboBox
            if (nombresVendedores != null)
            {
                cbVendedores.DataSource = nombresVendedores;
            }
            else
            {
                MessageBox.Show("Error al cargar los nombres de vendedores.");
            }
        }

        private void FormInfoVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeDiplomaDataSet2.Pedidos' Puede moverla o quitarla según sea necesario.
           // this.pedidosTableAdapter.Fill(this.trabajoDeDiplomaDataSet2.Pedidos);

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

        private void cbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvVentasVendedor.DataSource = null;
            string NombreVendedor = cbVendedores.SelectedItem.ToString();
            int DNIVendedor =controlUsuario.GetDNI(NombreVendedor);
            CargarDatos(DNIVendedor);
        }


        private void CargarDatos(int DNI)
        {
            //dgwDetalles.DataSource = controlPedido.ObtenerDetallePedido(detallePediddo);
            DataTable dataTable = controlDGV.ObtenerPedido(DNI);

            // Suscribir el evento CellFormatting
            dgvVentasVendedor.CellFormatting += (sender, e) =>
            {
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Nulo"; // O el valor que desees mostrar para DBNull
                    e.FormattingApplied = true;
                }
            };

            dgvVentasVendedor.DataSource = dataTable;
        }

        private void loadNameVendedores()
        {
            cbVendedores.Items.Clear();

        }

        private void dgvVentasVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
